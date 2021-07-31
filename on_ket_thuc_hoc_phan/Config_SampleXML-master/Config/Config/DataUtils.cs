using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Config
{
    class DataUtils
    {
        string fileName;
        XmlDocument doc = new XmlDocument();
        XmlElement root;
        public DataUtils()
        {
            fileName = "data.xml";
            doc.Load(fileName);
            root = doc.DocumentElement;
        }
        public Config getData()
        {
            string user = root.SelectSingleNode("user").InnerText;
            string password = root.SelectSingleNode("password").InnerText;
            List<Book> books = new List<Book>();
            XmlNode books_XML = root.SelectSingleNode("books");
            XmlNodeList book_XML = books_XML.SelectNodes("book");
            foreach (XmlNode x in book_XML)
            {
                string author = x.Attributes[0].InnerText;
                string title = x.Attributes[1].InnerText;
                books.Add(new Book(author, title));
            }
            Config rs = new Config(user, password, books);
            return rs;
        }
        public void addBook(Book b)
        {
            XmlElement book = doc.CreateElement("book");
            book.SetAttribute("author", b.Author);
            book.SetAttribute("title", b.Title);
            XmlNode books = root.SelectSingleNode("books");
            books.AppendChild(book);
            doc.Save(fileName);
        }
        public void deleteBook(Book b)
        {
            XmlNode books = root.SelectSingleNode("books");
            XmlNodeList book = books.SelectNodes("book");   
            foreach(XmlNode item in book)
            {
                string author = item.Attributes[0].InnerText;
                string title = item.Attributes[1].InnerText;
                if (author.ToLower().CompareTo(b.Author.ToLower()) == 0
                    && title.ToLower().CompareTo(b.Title.ToLower()) == 0)
                {//tìm được có trong file
                    books.RemoveChild(item);
                    doc.Save(fileName);
                    return;
                }
            }
        }
    }
}

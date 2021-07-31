using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Book
{
    class DataUtil
    {
        XmlDocument doc;
        XmlElement root;
        string filename;
        public DataUtil()
        {
            doc = new XmlDocument();
            filename = "thuvien.xml";
            if (!File.Exists(filename))
            {
                XmlElement thuvien = doc.CreateElement("thuvien");
                root.AppendChild(thuvien);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }
        public string getuser()
        {
            return root.SelectSingleNode("user").InnerText;
        }
        public string getpass()
        {
            return root.SelectSingleNode("passwd").InnerText;
        }
        public List<book> getall()
        {

            XmlNode books = root.SelectSingleNode("books");
            List<book> li = new List<book>();
            XmlNodeList book = books.SelectNodes("book");
            foreach (XmlNode item2 in book)
            {
                book y = new book();
                y.author = item2.Attributes[0].InnerText;
                y.title = item2.Attributes[1].InnerText;
                li.Add(y);
            }
            return li;
        }
        public void addBook(book b)
        {
            XmlNode tg = root.SelectSingleNode("books/book[ @author='" + b.author + "']");
            if (tg == null)
            {
                XmlNode books = root.SelectSingleNode("books");
                XmlElement book = doc.CreateElement("book");
                book.SetAttribute("author", b.author);
                book.SetAttribute("title", b.title);
                books.AppendChild(book);
                root.AppendChild(books);
                doc.Save(filename);
            }
            else
            {
                MessageBox.Show("Đã có tac gia nay rồi nên không thêm được ! ");
            }
        }
        
        public void UpdateBook1(book b)
        {
            XmlNode tg = root.SelectSingleNode("books");
            XmlNode au = tg.SelectSingleNode("book[@author='" + b.author + "']");
            if (au != null)
            {
                XmlElement eleBook = doc.CreateElement("book");
                eleBook.SetAttribute("author", b.author);
                eleBook.SetAttribute("title", b.title);

                tg.ReplaceChild(eleBook, au);
                doc.Save(filename);
            }
            else
            {
                MessageBox.Show("Khong co author nay ! ");
            }
        }

        public book tim(string au)
        {
            XmlNode b = root.SelectSingleNode("books/book[@author='" + au + "']");
            book bv = null;
            if (b != null)
            {
                bv = new book();
                bv.author = b.Attributes[0].InnerText;
                bv.title = b.Attributes[1].InnerText;
            }
            return bv;
        }
        public void xoa(string author)
        {
            XmlNode books = root.SelectSingleNode("books");
            XmlNode book = root.SelectSingleNode("books/book[@author='" + author + "']");
            if (book != null)
            {
                books.RemoveChild(book);
                doc.Save(filename);
            }
            else
            {
                MessageBox.Show("Khong xoa duoc");
            }
        }
    }
}

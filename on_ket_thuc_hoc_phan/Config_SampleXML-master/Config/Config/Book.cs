using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    class Book
    {
        string author;
        string title;

        public Book()
        {

        }
        public Book(string author, string title)
        {
            this.author = author;
            this.title = title;
        }
        public string Author { get => author; set => author = value; }
        public string Title { get => title; set => title = value; }
    }
}

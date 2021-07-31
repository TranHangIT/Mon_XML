using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Config
{
    class Config
    {
        string user;
        string password;
        List<Book> books;

        public Config()
        {

        }
        public Config(string user, string password, List<Book> books)
        {
            this.user = user;
            this.password = password;
            this.books = books;
        }
        public string User { get => user; set => user = value; }
        public string Password { get => password; set => password = value; }
        internal List<Book> Books { get => books; set => books = value; }
    }
}

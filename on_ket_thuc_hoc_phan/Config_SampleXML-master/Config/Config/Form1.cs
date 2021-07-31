using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Config
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtils obj = new DataUtils();
        public void showData()
        {
            dgvBooks.DataSource = null;
            Config cf = obj.getData();
            dgvBooks.DataSource = cf.Books;
            lblUser.Text = cf.User;
            lblPassWord.Text = cf.Password;
        }
        public void Clear()
        {
            txtAuthor.Text = txtTitle.Text = "";
            ActiveControl = txtAuthor;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            showData();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            showData();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            Config cf = obj.getData();
            List<Book> books = cf.Books;
            foreach (var item in books)
            {
                if (item.Author.ToLower().CompareTo(author.ToLower()) == 0
                    && item.Title.ToLower().CompareTo(title.ToLower()) == 0
                    )
                {
                    MessageBox.Show("Sách này đã có trong file", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            obj.addBook(new Book(author, title));
            showData();
            Clear();
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgvBooks.CurrentRow;
            string author = viewRow.Cells[0].Value + "";
            string title = viewRow.Cells[1].Value + "";
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                obj.deleteBook(new Book(author, title));
                showData();
                Clear();
            }

        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow viewRow = dgvBooks.CurrentRow;
            txtAuthor.Text = viewRow.Cells[0].Value + "";
            txtTitle.Text = viewRow.Cells[1].Value + "";

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Book
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataUtil data = new DataUtil();
        private void Form1_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        private void loaddata()
        {
            lbluser1.Text = data.getuser();
            lblpass1.Text = data.getpass();
            dataGridView1.DataSource = data.getall();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGridView1.Rows[vitri];
            txtau.Text = Convert.ToString(row.Cells["author"].Value);
            txttitle.Text = Convert.ToString(row.Cells["title"].Value);
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            book b = new book();
            b.author = txtau.Text;
            b.title = txttitle.Text;
            data.addBook(b);
            cleartxt();
            loaddata();
        }

        private void cleartxt()
        {
            txtau.Clear();
            txttitle.Clear();
            ActiveControl = txtau;
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            string au = txtau.Text;
            book b = data.tim(au);
            if (b != null)
            {
                List<book> li = new List<book>();
                li.Add(b);
                dataGridView1.DataSource = li;
            }
            else
            {
                MessageBox.Show("khong thay");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            book bk = new book();
            bk.author = txtau.Text;
            bk.title = txttitle.Text;
            data.UpdateBook1(bk);
            loaddata();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string au = txtau.Text;
            data.xoa(au);
            loaddata();
            cleartxt();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

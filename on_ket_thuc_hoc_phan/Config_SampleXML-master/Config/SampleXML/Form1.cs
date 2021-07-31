using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleXML
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
            dgvColors.DataSource = null;
            dgvColors.DataSource = obj.getColors(); 
            dgvFruits.DataSource = null;
            dgvFruits.DataSource = obj.getFruits();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            showData();
        }
    }
}

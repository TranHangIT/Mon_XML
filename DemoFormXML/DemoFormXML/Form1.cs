using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoFormXML
{
    public partial class Form1 : Form
    {
        DataUtil data = new DataUtil();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string masp = txtTimKiem.Text;
                data.TimKiem(masp, dataGridView1);
            }
            catch (Exception)
            {
                MessageBox.Show("Chú ý dữ liệu nhập vào.");
            }
            
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {

            data.HienThi(dataGridView1, lblSoLuongSP, lblSoLuongCacSP);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham s = new SanPham();
                s.masp = txtMaSP.Text;
                s.tensp = txtTenSP.Text;
                s.soluong = int.Parse(checkedRadio());
                s.namsanxuat = int.Parse(txtNamSX.Text);
                s.mahang = txtMaHang.Text;
                s.tenhang = cbTenHang.Text;
                s.quocgia = txtQuocGia.Text;

                if (!data.Them(s))
                {
                    MessageBox.Show("Thêm không thành công.");
                    return;
                }

                ClearTxt();
                data.HienThi(dataGridView1, lblSoLuongSP, lblSoLuongCacSP);
            }
            catch (Exception)
            {
                MessageBox.Show("Chú ý dữ liệu nhập vào.");
            }
            
        }

        private string checkedRadio()
        {
            if (sl10.Checked == true)
                return sl10.Text;
            if (sl20.Checked == true)
                return sl20.Text;
            if (sl30.Checked == true)
                return sl30.Text;
            return 0.ToString();
        }

        private void ClearTxt()
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            sl10.Checked = true;
            txtNamSX.Clear();
            txtMaHang.Clear();
            cbTenHang.SelectedIndex = 0;
            txtQuocGia.Clear();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                SanPham s = new SanPham();
                s.masp = txtMaSP.Text;
                s.tensp = txtTenSP.Text;
                s.soluong = int.Parse(checkedRadio());
                s.namsanxuat = int.Parse(txtNamSX.Text);
                s.mahang = txtMaHang.Text;
                s.tenhang = cbTenHang.Text;
                s.quocgia = txtQuocGia.Text;
                
                if (!data.Sua(s))
                {
                    MessageBox.Show("Mã sản phẩm không hợp lệ.");
                    return;
                }
                ClearTxt();
                data.HienThi(dataGridView1, lblSoLuongSP, lblSoLuongCacSP);
            }
            catch (Exception)
            {
                MessageBox.Show("Chú ý dữ liệu nhập vào.");
            }
            
        }

        private void CellClickSV(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            txtMaSP.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txtTenSP.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            string soluong = dataGridView1.Rows[index].Cells[2].Value.ToString();
            if (soluong.Equals(sl10.Text))
            {
                sl10.Checked = true;
            } else if (soluong.Equals(sl20.Text))
            {
                sl20.Checked = true;
            } else if (soluong.Equals(sl30.Text))
            {
                sl30.Checked = true;
            }
            txtNamSX.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txtMaHang.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            cbTenHang.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txtQuocGia.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                string masp = txtMaSP.Text;
                DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa???","Thông báo", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == dr)
                {
                    if (!data.Xoa(masp))
                    {
                        MessageBox.Show("Mã sản phẩm không hợp lệ.");
                        return;
                    }
                    ClearTxt();
                    data.HienThi(dataGridView1, lblSoLuongSP, lblSoLuongCacSP);
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Yêu cầu nhập đầy đủ thông tin.");
            }
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            sl10.Checked = true;
        }

        private void btnTKHang(object sender, EventArgs e)
        {
            try
            {
                string mahang = txtTKHang.Text;
                data.timKiemMaHang(mahang, dataGridView1, lblSoLuongCacSP);
            }
            catch (Exception)
            {
                MessageBox.Show("Chú ý dữ liệu nhập vào.");
            }
        }
    }
}

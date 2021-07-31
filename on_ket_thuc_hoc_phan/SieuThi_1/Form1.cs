using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SieuThi_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }


        DataUtil data = new DataUtil();
        List<sanpham> li = new List<sanpham>();
        private void Form1_Load(object sender, EventArgs e)
        {
            // data.hienthi(dataGridView1);
            this.hienthidulieu();
        }
        private void hienthidulieu()
        {
            li = data.hienthi_2();
            dataGridView2.DataSource = li;
            lblSoSanPham.Text = li.Count + "";
            this.tongSoluong();
        }
        private void tongSoluong()
        {
            int sl = 0;
            foreach (sanpham item in li)
            {
                sl += int.Parse(item.soluong);
            }
            lblTongSoluongSP.Text = sl + "";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "" && txtTensp.Text != "" && txtNamsx.Text != "" && txtQuocgia.Text != "" && txtMahang.Text != "" && comTenhang.Text != "")
            {
                sanpham s = new sanpham();
                s.masp = txtMaSP.Text;
                s.tensp = txtTensp.Text;
                if (radSoluong.Checked) s.soluong = "10";
                else if (radSoluong2.Checked) s.soluong = "20";
                else s.soluong = "30";

                s.namsx = txtNamsx.Text;
                s.mahang = txtMahang.Text;
                s.tenhang = comTenhang.Text;
                s.quocgia = txtQuocgia.Text;

                data.them(s);
                // data.hienthi(dataGridView1);

                this.hienthidulieu();

            }
            else
            {
                MessageBox.Show("Không được để trống thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {




        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                sanpham s = new sanpham();
                s.masp = txtMaSP.Text;


                data.xoa(s);
                //data.hienthi(dataGridView1);
                this.hienthidulieu();
            }
            else
            {
                MessageBox.Show("Không được để trống mã sách !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "" && txtTensp.Text != "" && txtNamsx.Text != "" && txtQuocgia.Text != "" && txtMahang.Text != "" && comTenhang.Text != "")
            {
                sanpham s = new sanpham();
                s.masp = txtMaSP.Text;
                s.tensp = txtTensp.Text;
                if (radSoluong.Checked) s.soluong = "10";
                else if (radSoluong2.Checked) s.soluong = "20";
                else s.soluong = "30";

                s.namsx = txtNamsx.Text;
                s.mahang = txtMahang.Text;
                s.tenhang = comTenhang.Text;
                s.quocgia = txtQuocgia.Text;

                data.sua(s);
                //data.hienthi(dataGridView1);
                this.hienthidulieu();

            }
            else
            {
                MessageBox.Show("Không được để trống thông tin !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int hang = e.RowIndex;

                txtMaSP.Text = dataGridView2.Rows[hang].Cells[0].Value + "";
                txtTensp.Text = dataGridView2.Rows[hang].Cells[1].Value + "";
                txtNamsx.Text = dataGridView2.Rows[hang].Cells[3].Value + "";
                txtMahang.Text = dataGridView2.Rows[hang].Cells[4].Value + "";
                comTenhang.Text = dataGridView2.Rows[hang].Cells[5].Value + "";
                txtQuocgia.Text = dataGridView2.Rows[hang].Cells[6].Value + "";

                string k = dataGridView2.Rows[hang].Cells[2].Value + "";
                if (k == "10") radSoluong.Checked = true;
                else if (k == "20") radSoluong2.Checked = true;
                else radSoluong3.Checked = true;
            }
            catch (Exception ee)
            {
                MessageBox.Show("Lỗi " + ee.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTongslhang_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text != "")
            {
                li = data.hienthi_2();
                int z = 0;
                foreach (sanpham s in li)
                {
                    if (txtMahang.Text.Equals(s.mahang))
                    {
                        z += int.Parse(s.soluong);
                    }
                }
                if (z == 0)
                {
                    MessageBox.Show("Không có mã hãng này !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Tổng số lượng của hãng " + txtMahang.Text + " là: " + z, "Kết quả", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Bạn phải nhập vào mã hãng để tính tổng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                li = data.hienthi_2();
                sanpham s = new sanpham();
                s.masp = txtMaSP.Text;
                int index = li.IndexOf(s);
                if (index >= 0)
                {
                    foreach (sanpham item in li)
                    {
                        if (s.masp.Equals(item.masp))
                        {
                            s.tenhang = item.tenhang;
                            s.soluong = item.soluong;
                            s.namsx = item.namsx;
                            s.mahang = item.mahang;
                            s.tenhang = item.tenhang;
                            s.quocgia = item.quocgia;
                        }
                    }
                    li.Clear();
                    li.Add(s);

                    dataGridView2.DataSource = li;
                    lblSoSanPham.Text = li.Count + "";
                    this.tongSoluong();

                }
                else
                {
                    MessageBox.Show("Không tồn tại mã sp này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Không được để trống mã sản phẩm !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBanDau_Click(object sender, EventArgs e)
        {
            this.hienthidulieu();
        }

        private void btnTimkiemhang_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text != "")
            {
                li = data.hienthi_2();

                Boolean kiemtra = false;

                foreach (sanpham item in li)
                {
                    if (txtMahang.Text.Equals(item.mahang))
                    {
                        txtMahang.Text = item.mahang;
                        comTenhang.Text = item.tenhang;
                        txtQuocgia.Text = item.quocgia;

                        kiemtra = true;
                        break;
                    }
                }

                if (!kiemtra)
                {
                    MessageBox.Show("Không tồn tại mã hãng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                MessageBox.Show("Không được để trống mã hãng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimkiemsptheomahang_Click(object sender, EventArgs e)
        {
            if (txtMahang.Text != "")
            {
                li = data.hienthi_2();

                for (int i = 0; i < li.Count; i++)
                {
                    if (!txtMahang.Text.Equals(li[i].mahang))
                    {
                        li.Remove(li[i]);
                        i--;
                        
                    }
                }
             
                if (li.Count !=0)
                {
                    dataGridView2.DataSource = li;
                    lblSoSanPham.Text = li.Count + "";
                    this.tongSoluong();
                }
                else
                {
                    MessageBox.Show("Không tồn tại mã hãng này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                


            }
            else
            {
                MessageBox.Show("Không được để trống mã hãng !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WinFormsApp1
{
     public partial class Form_QLNV : Form
     {
          NhanVien_BUS nvBLL;
          public Form_QLNV()
          {
               InitializeComponent();
               nvBLL = new NhanVien_BUS();
               tongNV.Text = nvBLL.GetSumOfStaff().ToString();
          }

          public void ShowAllStaff()
          {
               DataTable dt = nvBLL.GetAllStaff();
               danhsachNhanVien.DataSource = dt;
          } 
         

          private void txtNgaySinh_TextChanged(object sender, EventArgs e)
          {

          }
          public bool CheckData()
          {
               if (string.IsNullOrEmpty(txtMaNV.Text))
               {
                    MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaNV.Focus();
                    return false;
               }
               return true;
          }
          private void TTNV_load(object sender, EventArgs e)
          {
               ShowAllStaff();
          }

          private void btnAdd_Click(object sender, EventArgs e)
          {
               if (CheckData()){
                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.MaNV = txtMaNV.Text;
                    if (string.IsNullOrEmpty(txtHoten.Text))
                    {
                         nv.HoTen = "";
                    }
                    else { nv.HoTen = txtHoten.Text; }
                    if (radioButton1_nam.Checked)
                    {
                         nv.GT = "Nam";
                    }
                    else if (radioButton2_nu.Checked)
                    {
                         nv.GT = "Nữ";
                    }
                    else if (radioButton3_chuaro.Checked)
                    {
                         nv.GT = "Chưa rõ";
                    }
                    else
                    {
                         nv.GT = "";
                    }
                    if (string.IsNullOrEmpty(txtdiachi.Text))
                    {
                         nv.DC ="";
                    }
                    else { nv.DC = txtdiachi.Text; }
                    // cont 26/4/2022 3:18

                    if (string.IsNullOrEmpty(txtLuong.Text))
                    {
                         nv.Luong = 0.0;
                    }
                    else { nv.Luong = double.Parse(txtLuong.Text); }
                    if (string.IsNullOrEmpty(txtMaPB.Text))
                    {
                         nv.MaPB = "";
                    }
                    else { nv.MaPB = txtMaPB.Text; }

                    if (string.IsNullOrEmpty(txtMaNGS.Text))
                    {
                         nv.Ma_NGS = "";
                    }
                    else { nv.Ma_NGS = txtMaNGS.Text; }
                    nv.NS = dateTimePicker1_NS.Value;
                    
                    if (nvBLL.InsertStaff(nv))
                    {
                         MessageBox.Show("Thêm thành công!");
                         ShowAllStaff();
                         tongNV.Text = nvBLL.GetSumOfStaff().ToString();
                    }
                    else
                    {
                         MessageBox.Show("Thêm lỗi!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    
               }

          }
          private void btnUpdate_Click(object sender, EventArgs e)
          {
               
               if (CheckData())
               {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.MaNV = txtMaNV.Text;
                    txtMaNV.Enabled = false;
                    if (string.IsNullOrEmpty(txtHoten.Text))
                    {
                         nv.HoTen = "";
                    }
                    else { nv.HoTen = txtHoten.Text; }
                    if (radioButton1_nam.Checked)
                    {
                         nv.GT = "Nam";
                    }
                    else if (radioButton2_nu.Checked)
                    {
                         nv.GT = "Nữ";
                    }
                    else if (radioButton3_chuaro.Checked)
                    {
                         nv.GT = "Chưa rõ";
                    }
                    else
                    {
                         nv.GT = "";
                    }
                    if (string.IsNullOrEmpty(txtdiachi.Text))
                    {
                         nv.DC = "";
                    }
                    else { nv.DC = txtdiachi.Text; }
                    // cont 26/4/2022 3:18

                    if (string.IsNullOrEmpty(txtLuong.Text))
                    {
                         nv.Luong = 0.0;
                    }
                    else { nv.Luong = double.Parse(txtLuong.Text); }
                    if (string.IsNullOrEmpty(txtMaPB.Text))
                    {
                         nv.MaPB = "";
                    }
                    else { nv.MaPB = txtMaPB.Text; }

                    if (string.IsNullOrEmpty(txtMaNGS.Text))
                    {
                         nv.Ma_NGS = "";
                    }
                    else { nv.Ma_NGS = txtMaNGS.Text; }
                    nv.NS = dateTimePicker1_NS.Value;

                    if (nvBLL.UpdateStaff(nv))
                    {
                         MessageBox.Show("Cập nhật thành công!");
                         ShowAllStaff();
                         tongNV.Text = nvBLL.GetSumOfStaff().ToString();
                    }
                    else
                    {
                         MessageBox.Show("Cập nhật lỗi!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                    txtMaNV.Enabled = true;
               }
               
          }


          private void dateTimePicker1_NS_ValueChanged(object sender, EventArgs e)
          {

          }

          private void danhsachNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
          {
               int index = e.RowIndex;
               if (index >= 0)
               {
                    txtMaNV.Text = danhsachNhanVien.Rows[index].Cells["MaNV"].Value.ToString();
                    txtMaPB.Text = danhsachNhanVien.Rows[index].Cells["MaPB"].Value.ToString();
                    txtHoten.Text = danhsachNhanVien.Rows[index].Cells["HoTen"].Value.ToString();
                    if (danhsachNhanVien.Rows[index].Cells["NS"].Value.ToString() != "")
                    {
                         dateTimePicker1_NS.Value = Convert.ToDateTime(danhsachNhanVien.Rows[index].Cells["NS"].Value);
                    }
                    txtLuong.Text = danhsachNhanVien.Rows[index].Cells["Luong"].Value.ToString();
                    txtdiachi.Text = danhsachNhanVien.Rows[index].Cells["DC"].Value.ToString();
                    if (danhsachNhanVien.Rows[index].Cells["GT"].Value.ToString() == "Nam")
                    {
                         radioButton1_nam.Checked=true;
                    }
                    else if (danhsachNhanVien.Rows[index].Cells["GT"].Value.ToString() == "Nữ")
                    {
                         radioButton2_nu.Checked = true;
                    }
                    else if (danhsachNhanVien.Rows[index].Cells["GT"].Value.ToString() == "Chưa rõ")
                    {
                         radioButton3_chuaro.Checked = true;
                    }
                    else
                    {
                         radioButton1_nam.Checked = false;
                         radioButton2_nu.Checked = false;
                         radioButton3_chuaro.Checked = false;
                    }

                    txtMaNGS.Text = danhsachNhanVien.Rows[index].Cells["Ma_NGS"].Value.ToString();


               }
          }

          private void panel1_Paint(object sender, PaintEventArgs e)
          {

          }

          private void txtHoten_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtMaPB_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtMaNV_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtMaNGS_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtLuong_TextChanged(object sender, EventArgs e)
          {

          }

          private void txtdiachi_TextChanged(object sender, EventArgs e)
          {

          }

          private void btnReset_Click(object sender, EventArgs e)
          {
               txtMaNV.Text = "";
               txtMaPB.Text = "";
               txtMaNGS.Text = "";
               radioButton1_nam.Checked = false;
               radioButton2_nu.Checked = false;
               radioButton3_chuaro.Checked = false;
               txtdiachi.Text = "";
               dateTimePicker1_NS.Value = DateTime.Today;
               txtLuong.Text = "";
               txtHoten.Text = "";
          }

          private void btnDelete_Click(object sender, EventArgs e)
          {
               if (CheckData())
               {
                    NhanVien_DTO nv = new NhanVien_DTO();
                    nv.MaNV = txtMaNV.Text;              
                    if (nvBLL.DeleteStaff(nv))
                    {
                         MessageBox.Show("Xoá thành công!");
                         ShowAllStaff();
                         tongNV.Text = nvBLL.GetSumOfStaff().ToString();
                    }
                    else
                    {
                         MessageBox.Show("Xoá lỗi!", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
               }
          }

          private void txtFindSV_TextChanged(object sender, EventArgs e)
          {
               string value = txtFindSV.Text;
               if (!string.IsNullOrEmpty(value))
               {
                    DataTable dt = nvBLL.FindStaff(value);
                    danhsachNhanVien.DataSource = dt;
               }
               else
               {
                    ShowAllStaff();
               }

          }
     }
     }


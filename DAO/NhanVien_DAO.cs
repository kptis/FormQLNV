using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
     class NhanVien_DAO
     {
          DataConnection_DAO dc;
          SqlDataAdapter da;
          SqlCommand cmd;
          public NhanVien_DAO()
          {
               dc = new DataConnection_DAO();

          }
          public DataTable GetAllStaff()
          {
               SqlConnection conn = dc.getConnect();
               da = new SqlDataAdapter("prd_GetAllStaff", conn);
               conn.Open();
               //SqlCommand cmd = new SqlCommand("prd_GetAllStaff", conn);
               //cmd.CommandType = CommandType.StoredProcedure;
               //cmd.ExecuteNonQuery();
               DataTable dt = new DataTable();
               da.Fill(dt);
               conn.Close();
               return dt;
          }
          public bool InsertStaff(NhanVien_DTO nv)
          {
               string sql = "prd_InsertStaff";
               SqlConnection conn = dc.getConnect();
               try
               {
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = nv.MaNV;
                    cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.HoTen;
                    cmd.Parameters.Add("@ns", SqlDbType.Date).Value = nv.NS;
                    cmd.Parameters.Add("@gt", SqlDbType.Char).Value = nv.GT;
                    cmd.Parameters.Add("@dc", SqlDbType.NVarChar).Value = nv.DC;
                    cmd.Parameters.Add("@luong", SqlDbType.Real).Value = nv.Luong;
                    cmd.Parameters.Add("@mangs", SqlDbType.NVarChar).Value = nv.Ma_NGS;
                    cmd.Parameters.Add("@mapb", SqlDbType.NVarChar).Value = nv.MaPB;
                    cmd.ExecuteNonQuery();

               }
               catch(Exception ex)
               {
                    MessageBox.Show(ex.ToString());
                    return false;
               }
               return true;

          }
          public bool UpdateStaff(NhanVien_DTO nv)
          {
               string sql = "prd_UpdateStaff";
               SqlConnection conn = dc.getConnect();
               try
               {
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = nv.MaNV;
                    cmd.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = nv.HoTen;
                    cmd.Parameters.Add("@ns", SqlDbType.Date).Value = nv.NS;
                    cmd.Parameters.Add("@gt", SqlDbType.NVarChar).Value = nv.GT;
                    cmd.Parameters.Add("@dc", SqlDbType.NVarChar).Value = nv.DC;
                    cmd.Parameters.Add("@luong", SqlDbType.Real).Value = nv.Luong;
                    cmd.Parameters.Add("@mangs", SqlDbType.NVarChar).Value = nv.Ma_NGS;
                    cmd.Parameters.Add("@mapb", SqlDbType.NVarChar).Value = nv.MaPB;
                    cmd.ExecuteNonQuery();

               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString());
                    return false;
               }
               return true;

          }
          public bool DeleteStaff(NhanVien_DTO nv) 
          {
               string sql = "prd_DeleteStaff";
               SqlConnection conn = dc.getConnect();
               try
               {
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@manv", SqlDbType.NVarChar).Value = nv.MaNV;
                    cmd.ExecuteNonQuery();

               }
               catch (Exception ex)
               {
                    MessageBox.Show(ex.ToString());
                    return false;
               }
               return true;

          }
          public int getSumOfStaff()
          {
               DataTable dt = new DataTable();
               string sql = "select count(MaNV) from NHANVIEN";
               SqlConnection conn = dc.getConnect();
               try
               {
                    da = new SqlDataAdapter(sql,conn);
                    
                    da.Fill(dt);
               }
               catch (Exception e)
               {
                    return -1;
               }
               return int.Parse(dt.Rows[0][0].ToString());

          }

          public DataTable FindStaff(string nv)
          {
               string sql = "SELECT * FROM dbo.NHANVIEN WHERE HoTen LIKE N'%" + nv + "%' OR MaNV LIKE N'%" + nv + "%'";
               SqlConnection conn = dc.getConnect();
               da = new SqlDataAdapter(sql, conn);
               conn.Open();
               DataTable dt = new DataTable() ;
               da.Fill(dt);
               conn.Close();
               return dt;

          }


     }
}

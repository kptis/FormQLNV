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
     public partial class Login_GUI : Form
     {
          public Login_GUI()
          {
               InitializeComponent();
          }

          private void btnLogin_Click(object sender, EventArgs e)
          {
               SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-JHBBPQ9\KPT;Initial Catalog=CONGTY;Integrated Security=True");
               conn.Open();
               string query = "select * from account where username = '" + txtTK.Text.Trim() + "' and password = '" + txtMK.Text.Trim() + "'";
               SqlDataAdapter da = new SqlDataAdapter(query, conn);
               DataTable dt = new DataTable();
               da.Fill(dt);
               conn.Close();
               if (dt.Rows.Count == 1)
               {
                    
                    if (int.Parse(dt.Rows[0][2].ToString()) == 1)
                    {
                         MessageBox.Show("Hello admin!");
                         this.Hide();
                         Form_QLNV f2 = new Form_QLNV();
                         f2.Show();
                    }
                    else
                    {
                         MessageBox.Show("Đăng nhập thành công!");
                         this.Hide();
                         Form_QLNV f2 = new Form_QLNV();
                         f2.Show();
                    }
               }
          }

          private void txtTK_TextChanged(object sender, EventArgs e)
          {

          }
     }
}

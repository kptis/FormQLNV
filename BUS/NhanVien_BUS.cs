using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
     class NhanVien_BUS
     {
          NhanVien_DAO dao_nv;
          public NhanVien_BUS()
          {
               dao_nv = new NhanVien_DAO();
          }
          public DataTable GetAllStaff()
          {
               return dao_nv.GetAllStaff();
          }
          public bool InsertStaff(NhanVien_DTO nv)
          {
               return dao_nv.InsertStaff(nv);
          }
          public bool UpdateStaff(NhanVien_DTO nv)
          {
               return dao_nv.UpdateStaff(nv);
          }
          public bool DeleteStaff(NhanVien_DTO nv)
          {
               return dao_nv.DeleteStaff(nv);
          }
          public int GetSumOfStaff()
          {
               return dao_nv.getSumOfStaff();
          }
     }
}

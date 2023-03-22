using DevExpress.XtraEditors;
using QuanLiBanThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanThuoc.DAO
{
    public partial class StaffDAO
    {
        public static List<Account> GetData()
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                return db.Accounts.ToList();
            }
        }



        public static void InsertStaff(Account unit)
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                Account checkID = db.Accounts.FirstOrDefault(u => u.Code_Account == unit.Code_Account);
                if (checkID == null)
                {
                    db.Accounts.Add(unit);
                    db.SaveChanges();
                    XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public static void UpdateStaff(Account unit)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            Account checkId = db.Accounts.FirstOrDefault(s => s.Code_Account == unit.Code_Account);


            if (checkId != null)
            {
                checkId.Code_Account = unit.Code_Account;
                checkId.DisplayName_Account = unit.DisplayName_Account;
                checkId.DateOfBirth = unit.DateOfBirth;
                checkId.PhoneNumber = unit.PhoneNumber;


                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Cập Nhật không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }
        public static void DeleteStaff(string id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            Account checkId = db.Accounts.FirstOrDefault(s => s.Code_Account == id);

            if (checkId != null)
            {
                db.Accounts.Remove(checkId);
                db.SaveChanges();
                XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                XtraMessageBox.Show("Xóa không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
        }

        public static bool Login(String userName, String passWord)
        {
            string query = "USP_Login @username , @password";
            DataTable result = DataProvider.ExecuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
            
        }
    }
}

using DevExpress.XtraEditors;
using QuanLiBanThuoc.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanThuoc.DAO
{
    public partial class CustomerDAO
    {
        public static List<Customer> GetData()
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                return db.Customers.ToList();
            }
        }



        public static void InsertCus(Customer unit)
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                Customer checkID = db.Customers.FirstOrDefault(u => u.Code_Customer == unit.Code_Customer);
                if (checkID == null)
                {
                    
                    db.Customers.Add(unit);
                    db.SaveChanges();
                    XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public static void UpdateCus(Customer unit)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            Customer checkId = db.Customers.FirstOrDefault(s => s.Code_Customer == unit.Code_Customer);


            if (checkId != null)
            {
                checkId.Code_Customer = unit.Code_Customer;
                checkId.Name_Customer = unit.Name_Customer;
                checkId.Address_Customer = unit.Address_Customer;
                checkId.PhoneNumber = unit.PhoneNumber;


                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Cập Nhật không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }
        public static void DeleteCus(string id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            Customer checkId = db.Customers.FirstOrDefault(s => s.Code_Customer == id);

            if (checkId != null)
            {
                db.Customers.Remove(checkId);
                db.SaveChanges();
                XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                XtraMessageBox.Show("Xóa không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
        }
    }
}

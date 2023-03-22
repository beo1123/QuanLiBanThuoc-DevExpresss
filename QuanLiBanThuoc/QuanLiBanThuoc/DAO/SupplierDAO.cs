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
    public partial class SupplierDAO
    {
        public static List<Supplier> GetData()
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                return db.Suppliers.ToList();
            }
        }

        public static void InsertUnit(Supplier sup)
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                Supplier checkID = db.Suppliers.FirstOrDefault(u => u.Code_Supplier == sup.Code_Supplier);
                if (checkID == null)
                {
                    db.Suppliers.Add(sup);
                    db.SaveChanges();
                    XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public static void UpdateUnit(Supplier sup)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            Supplier checkId = db.Suppliers.FirstOrDefault(s => s.Code_Supplier == sup.Code_Supplier);


            if (checkId != null)
            {
                checkId.Code_Supplier = sup.Code_Supplier;
                checkId.Name_Supplier = sup.Name_Supplier;
                checkId.Address_Supplier = sup.Address_Supplier;
                checkId.PhoneNumber = sup.PhoneNumber;




                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Cập Nhật không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }
        public static void DeleteUnit(string id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            Supplier checkId = db.Suppliers.FirstOrDefault(s => s.Code_Supplier == id);

            if (checkId != null)
            {
                db.Suppliers.Remove(checkId);
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

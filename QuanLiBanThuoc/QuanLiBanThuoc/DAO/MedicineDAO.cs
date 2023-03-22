using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLiBanThuoc.DTO;

namespace QuanLiBanThuoc.DAO
{
    public partial class MedicineDAO
    {
        public static List<Medicine> GetData()
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
              
                return db.Medicines.ToList();
            }
        }

        public static Medicine GetMedByID(int id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            return db.Medicines.FirstOrDefault(s => s.ID_Medicine == id);
        }

        public static void InsertMed(Medicine med)
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                Medicine checkID = db.Medicines.FirstOrDefault(u => u.Code_MEdicine == med.Code_MEdicine);
                if (checkID == null)
                {
                    db.Medicines.Add(med);
                    db.SaveChanges();
                    XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public static void UpdateMed(Medicine med)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            Medicine checkId = db.Medicines.FirstOrDefault(s => s.Code_MEdicine == med.Code_MEdicine);


            if (checkId != null)
            {
                checkId.Code_MEdicine = med.Code_MEdicine;
                checkId.Name_Medicine = med.Name_Medicine;
                checkId.ID_Unit = med.ID_Unit;
                checkId.ID_Supplier = med.ID_Supplier;
                checkId.Exprired_Day = med.Exprired_Day;
                checkId.Import_Price = med.Import_Price;
                checkId.Sale_Price = med.Sale_Price;
                checkId.Note = med.Note;
                checkId.Amount = med.Amount;




                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Cập Nhật không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }
        public static void DeleteMed(string id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            Medicine checkId = db.Medicines.FirstOrDefault(s => s.Code_MEdicine == id);

            if (checkId != null)
            {
                db.Medicines.Remove(checkId);
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

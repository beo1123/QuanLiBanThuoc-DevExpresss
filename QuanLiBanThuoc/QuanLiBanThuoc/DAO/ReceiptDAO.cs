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
    public partial class ReceiptDAO
    {
        public static List<Receipt> GetData()
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                return db.Receipts.ToList();
            }
        }

        public static List<ReceiptDetail> GetDataDetails()
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            return db.ReceiptDetails.ToList();

        }

        public static List<ReceiptDetail> GetDataDetailsByID(int id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            return db.ReceiptDetails.Where(x => x.ID_ReceiptDetails == id).ToList();

        }





        public static void InsertReceipt(Receipt unit)
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                Receipt checkID = db.Receipts.FirstOrDefault(u => u.Code_Reciept == unit.Code_Reciept);
                if (checkID == null)
                {
                    db.Receipts.Add(unit);
                    db.SaveChanges();
                    XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public static void UpdateReceipt(Receipt unit)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            Receipt checkId = db.Receipts.FirstOrDefault(s => s.Code_Reciept == unit.Code_Reciept);


            if (checkId != null)
            {
                checkId.Code_Reciept = unit.Code_Reciept;
                checkId.CreateDay = unit.CreateDay;
                checkId.ID_Account = unit.ID_Account;
                checkId.ID_Supplier = unit.ID_Supplier;


                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Cập Nhật không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }
        public static void DeleteReceipt(string id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            Receipt checkId = db.Receipts.FirstOrDefault(s => s.Code_Reciept == id);

            if (checkId != null)
            {
                db.Receipts.Remove(checkId);
                db.SaveChanges();
                XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                XtraMessageBox.Show("Xóa không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
        }


        public static void SaveReceiptDetails(ReceiptDetail unit)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            ReceiptDetail checkId = db.ReceiptDetails.FirstOrDefault(s => s.ID_Medicine == unit.ID_Medicine && s.ID_ReceiptDetails == unit.ID_ReceiptDetails);

            if (checkId != null)
            {
                checkId.Amount = unit.Amount;
                checkId.toTalPrice = unit.toTalPrice;
                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                db.ReceiptDetails.Add(unit);
                db.SaveChanges();
                XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }



        }



        public static void DeleteReceiptDetails(int id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            ReceiptDetail checkId = db.ReceiptDetails.FirstOrDefault(s => s.ID_ReceiptDetails == id);

            if (checkId != null)
            {
                db.ReceiptDetails.Remove(checkId);
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

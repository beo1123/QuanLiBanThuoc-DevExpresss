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
    public partial class InvoiceDAO
    {
        public static List<Invoice> GetData()
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                return db.Invoices.ToList();
            }
        }

        public static List<InvoiceDetail> GetDataDetails()
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            
            return db.InvoiceDetails.ToList();
            
        }

        public static List<InvoiceDetail> GetDataDetailsByID(int id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            return db.InvoiceDetails.Where(x => x.ID_InvoiceDetails == id).ToList();

        }





        public static void InsertInvoice(Invoice unit)
        {
            using (DrugSalesManagerEntities db = new DrugSalesManagerEntities())
            {
                Invoice checkID = db.Invoices.FirstOrDefault(u => u.Code_Invoice == unit.Code_Invoice);
                if (checkID == null)
                {
                    db.Invoices.Add(unit);
                    db.SaveChanges();
                    XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("Thêm không thành công! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        public static void UpdateInvoice(Invoice unit)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            Invoice checkId = db.Invoices.FirstOrDefault(s => s.Code_Invoice == unit.Code_Invoice);


            if (checkId != null)
            {
                checkId.Code_Invoice = unit.Code_Invoice;
                checkId.CreateDay = unit.CreateDay;
                checkId.ID_Account = unit.ID_Account;
                checkId.ID_Customer = unit.ID_Customer;


                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                XtraMessageBox.Show("Cập Nhật không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }


        }
        public static void DeleteInvoice(string id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            Invoice checkId = db.Invoices.FirstOrDefault(s => s.Code_Invoice == id);

            if (checkId != null)
            {
                db.Invoices.Remove(checkId);
                db.SaveChanges();
                XtraMessageBox.Show("Xóa Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            else
            {
                XtraMessageBox.Show("Xóa không Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
        }


        public static void SaveInvoiceDetails(InvoiceDetail unit)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();
            InvoiceDetail checkId = db.InvoiceDetails.FirstOrDefault(s => s.ID_Medicine == unit.ID_Medicine && s.ID_InvoiceDetails == unit.ID_InvoiceDetails);

            if (checkId != null)
            {
                checkId.Amount = unit.Amount;
                checkId.toTalPrice = unit.toTalPrice;
                db.SaveChanges();
                XtraMessageBox.Show("Cập Nhật Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

              
            }
            else
            {
                db.InvoiceDetails.Add(unit);
                db.SaveChanges();
                XtraMessageBox.Show("Thêm Thành Công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }



        }

       

        public static void DeleteInvoiceDetails(int id)
        {
            DrugSalesManagerEntities db = new DrugSalesManagerEntities();

            InvoiceDetail checkId = db.InvoiceDetails.FirstOrDefault(s => s.ID_InvoiceDetails == id);

            if (checkId != null)
            {
                db.InvoiceDetails.Remove(checkId);
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

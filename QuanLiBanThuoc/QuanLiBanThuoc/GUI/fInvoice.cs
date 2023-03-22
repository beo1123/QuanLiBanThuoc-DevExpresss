using DevExpress.XtraEditors;
using QuanLiBanThuoc.DAO;
using QuanLiBanThuoc.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanThuoc.GUI
{
    public partial class fInvoice : DevExpress.XtraEditors.XtraForm
    {
        private int Qty = 0;
        private double Price = 0;
        private double totalPrice = 0;

        public fInvoice()
        {
            InitializeComponent();
        }

        #region Chức Năng
        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Đóng")
            {
                this.Close();
            }
            else
            {
                if (e.Button.Properties.Caption == "Tạo Mới")
                {
                    InsertInvoice();

                }
                else
                {
                    if (e.Button.Properties.Caption == "Lưu")
                    {
                        UpdateInvoice();

                    }
                    else
                    {
                        if (e.Button.Properties.Caption == "Xóa")
                        {
                            DeleteInvoice();

                        }
                        else
                        {
                            if (e.Button.Properties.Caption == "Clear")
                            {
                                Clear();

                            }
                        }
                    }
                }
            }
        }
        private void LoadData()
        {
            invoiceBindingSource.DataSource = InvoiceDAO.GetData();
            customerBindingSource.DataSource = CustomerDAO.GetData();
            accountBindingSource.DataSource = StaffDAO.GetData();
            medicineBindingSource.DataSource = MedicineDAO.GetData();
            invoiceDetailBindingSource.DataSource = InvoiceDAO.GetDataDetails();
            unitBindingSource.DataSource = UnitDAO.GetData();

            


        }

        private void Clear()
        {
            tx_IdInvoice.Text = "";
            cmb_Cus.Text = "";
            cmbStaff.Text = "";
            dtpk_CreateDay.Text = "";
            txt_SumPrice.Text = "";
            


        }

        private void InsertInvoice()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (tx_IdInvoice.Text.Trim() == ""  )
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (tx_IdInvoice.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Invoice obj = new Invoice();
                obj.Code_Invoice = tx_IdInvoice.Text;
                obj.CreateDay = dtpk_CreateDay.Value;
                obj.ID_Account = int.Parse(cmbStaff.GetColumnValue("ID_Account").ToString());
                obj.ID_Customer = int.Parse(cmb_Cus.GetColumnValue("ID_Customer").ToString());
                

                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn thêm??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    InvoiceDAO.InsertInvoice(obj);
                    LoadData();
                    LoadInvoiceItem();
                    Clear();




                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void UpdateInvoice()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (tx_IdInvoice.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (tx_IdInvoice.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Invoice obj = new Invoice();
                obj.Code_Invoice = tx_IdInvoice.Text;
                obj.CreateDay = dtpk_CreateDay.Value;
                obj.ID_Account = int.Parse(cmbStaff.GetColumnValue("ID_Account").ToString());
                obj.ID_Customer = int.Parse(cmb_Cus.GetColumnValue("ID_Customer").ToString());


                #endregion




                if (XtraMessageBox.Show("Bạn có thật sự muốn Cập nhật??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    InvoiceDAO.UpdateInvoice(obj);
                    LoadData();

                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void DeleteInvoice()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (tx_IdInvoice.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (tx_IdInvoice.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }


                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Xóa??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    InvoiceDAO.DeleteInvoice(tx_IdInvoice.Text);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        
        private void LoadLookUpEditCustomer()
        {
            string queryStr = "select ID_Customer, Name_Customer  from Customer";
            DataTable ds = DataProvider.ExecuteQuery(queryStr);
            cmb_Cus.Properties.DataSource = ds;
            cmb_Cus.Properties.DisplayMember = "Name_Customer";
            cmb_Cus.Properties.ValueMember = "ID_Customer";



        }


        private void LoadLookUpEditStaff()
        {
            string queryStr = "select ID_Account , DisplayName_Account from Account";
            DataTable ds = DataProvider.ExecuteQuery(queryStr);
            cmbStaff.Properties.DataSource = ds;
            cmbStaff.Properties.DisplayMember = "DisplayName_Account";
            cmbStaff.Properties.ValueMember = "ID_Account";

        }

        
        #endregion

        private void fInvoice_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLookUpEditCustomer();
            LoadLookUpEditStaff();
            LoadMedItem();
            LoadInvoiceItem();




        }

       private void LoadMedItem()
       {
            string queryStr = "select ID_Medicine, Code_MEdicine, Name_Medicine  from Medicine";
            DataTable dt = DataProvider.ExecuteQuery(queryStr);
            repositoryItem_Medicine.DataSource = dt;
            repositoryItem_Medicine.DisplayMember = "Name_Medicine";
            repositoryItem_Medicine.ValueMember = "ID_Medicine";
            repositoryItem_Medicine.NullText = @"Chọn Thuốc";
            colID_Medicine.ColumnEdit = repositoryItem_Medicine;
           
            
       }

       private void LoadInvoiceItem()
       {
            string queryStr = "select ID_Invoice, Code_Invoice from Invoice";
            DataTable dt = DataProvider.ExecuteQuery(queryStr);
            repositoryItem_IdInvoice.DataSource = dt;
            repositoryItem_IdInvoice.DisplayMember = "Code_Invoice";
            repositoryItem_IdInvoice.ValueMember = "ID_Invoice";
            repositoryItem_IdInvoice.NullText = @"Chọn Hóa Đơn";
            colID_InvoiceDetails.ColumnEdit = repositoryItem_IdInvoice;


       }

        private void LoadDetails(int id)
       {
            for (int i = 0; i < gridView2.RowCount; i++)
            {
                
                invoiceDetailBindingSource.DataSource = InvoiceDAO.GetDataDetailsByID(id);
                
            }
            
       }

     

       private void ShowCalcMoney(string id_Invoice)
       {
            double sumMoney = 0;

            for (int i = 0; i <  gridView2.RowCount; i++)
            {
                if (gridView2.GetRowCellDisplayText(i, colID_InvoiceDetails).ToString() == id_Invoice) 
                {

                    sumMoney += Convert.ToDouble(gridView2.GetRowCellDisplayText(i, ColTotal)); 
                }
            }

            txt_SumPrice.Text = sumMoney.ToString();
       }

        private void gv_Invoice1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            tx_IdInvoice.Text = gv_Invoice1.GetFocusedRowCellValue(colCode_Invoice).ToString();
            dtpk_CreateDay.Text = gv_Invoice1.GetFocusedRowCellValue(colCreateDay).ToString();
            cmbStaff.Text = gv_Invoice1.GetFocusedRowCellDisplayText(colID_Account);
            cmb_Cus.Text = gv_Invoice1.GetFocusedRowCellDisplayText(colID_Customer);

            LoadDetails((int)gv_Invoice1.GetFocusedRowCellValue(Col_IdInvoice));

            ShowCalcMoney(tx_IdInvoice.Text);





        }

        private void gridView2_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            #region Lấy Thông tin Thuốc
            if (e.Column.FieldName == "ID_Medicine")
            {
                object value = gridView2.GetRowCellValue(e.RowHandle, e.Column);
                Medicine dt = MedicineDAO.GetMedByID((int)value);

                if (dt != null)
                {
                    gridView2.SetRowCellValue(e.RowHandle, "Id_Unit", dt.ID_Unit);
                    gridView2.SetRowCellValue(e.RowHandle, "Sale_Pirce", dt.Sale_Price);
                    //Reset TotolPrice neu thay doi ma thuoc
                    if (gridView2.GetFocusedRowCellValue(colAmount) == null)
                    {
                        Qty = 0;
                    }
                    else
                    {
                        Qty = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colAmount));
                        Price = Convert.ToDouble(gridView2.GetFocusedRowCellValue(colSale_Pirce));
                        totalPrice = Qty * Price;

                        gridView2.SetFocusedRowCellValue(ColTotal, totalPrice);
                    }

                    
                }
            }
            #endregion

            #region Tính Thành tiền
            if (e.Column == colAmount)
            {
                Qty = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colAmount));
                Price = Convert.ToDouble(gridView2.GetFocusedRowCellValue(colSale_Pirce));
                totalPrice = Qty * Price;

                gridView2.SetFocusedRowCellValue(ColTotal, totalPrice);


            }
            #endregion

            

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                InvoiceDetail obj = new InvoiceDetail();
                obj.ID_InvoiceDetails = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_InvoiceDetails));
                obj.ID_Medicine = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_Medicine));
                obj.Id_Unit = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colId_Unit));
                obj.Amount = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colAmount));
                obj.Sale_Pirce = Convert.ToDouble(gridView2.GetFocusedRowCellValue(colSale_Pirce));
                obj.toTalPrice = Convert.ToDouble(gridView2.GetFocusedRowCellValue(ColTotal));
                obj.Bill_Status = false;


                InvoiceDAO.SaveInvoiceDetails(obj);
                LoadDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_InvoiceDetails)));


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_InvoiceDetails));
                InvoiceDAO.DeleteInvoiceDetails(id);
                LoadDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_InvoiceDetails)));


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }

}

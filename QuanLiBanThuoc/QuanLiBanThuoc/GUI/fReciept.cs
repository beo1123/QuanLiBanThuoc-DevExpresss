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

  
    public partial class fReciept : DevExpress.XtraEditors.XtraForm
    {
        private int Qty = 0;
        private double Price = 0;
        private double totalPrice = 0;
        public fReciept()
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
                        if (e.Button.Properties.Caption == "Clear")
                        {
                            Clear();

                        }
                        else
                        {
                            if (e.Button.Properties.Caption == "Xóa")
                            {
                                DeleteInvoice();

                            }
                        }
                    }
                }
            }
        }

        private void Clear()
        {
            txt_IdReciept.Text = "";
            cmb_Sup.Text = "";
            cmb_Staff.Text = "";
            dtpk_CreateDay.Text = "";
            txt_SumPrice.Text = "";



        }

        private void InsertInvoice()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_IdReciept.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_IdReciept.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Receipt obj = new Receipt();
                obj.Code_Reciept = txt_IdReciept.Text;
                obj.CreateDay = dtpk_CreateDay.Value;
                obj.ID_Account = int.Parse(cmb_Staff.GetColumnValue("ID_Account").ToString());
                obj.ID_Supplier = int.Parse(cmb_Sup.GetColumnValue("ID_Supplier").ToString());


                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn thêm??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    ReceiptDAO.InsertReceipt(obj);
                    LoadData();
                    LoadReceiptItem();
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
                if (txt_IdReciept.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_IdReciept.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Receipt obj = new Receipt();
                obj.Code_Reciept = txt_IdReciept.Text;
                obj.CreateDay = dtpk_CreateDay.Value;
                obj.ID_Account = int.Parse(cmb_Staff.GetColumnValue("ID_Account").ToString());
                obj.ID_Supplier = int.Parse(cmb_Sup.GetColumnValue("ID_Supplier").ToString());


                #endregion




                if (XtraMessageBox.Show("Bạn có thật sự muốn Cập nhật??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    ReceiptDAO.UpdateReceipt(obj);
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
                if (txt_IdReciept.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_IdReciept.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }


                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Xóa??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    ReceiptDAO.DeleteReceipt(txt_IdReciept.Text);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void LoadData()
        {
            receiptBindingSource.DataSource = ReceiptDAO.GetData();
            receiptDetailBindingSource.DataSource = ReceiptDAO.GetDataDetails();
            accountBindingSource.DataSource = StaffDAO.GetData();
            supplierBindingSource.DataSource = SupplierDAO.GetData();
            medicineBindingSource.DataSource = MedicineDAO.GetData();
            unitBindingSource.DataSource = UnitDAO.GetData();
            
        }
        private void LoadLookUpEditSup()
        {
            string queryStr = "select ID_Supplier, Code_Supplier, Name_Supplier  from Supplier";
            DataTable ds = DataProvider.ExecuteQuery(queryStr);
            cmb_Sup.Properties.DataSource = ds;
            cmb_Sup.Properties.DisplayMember = "Name_Supplier";
            cmb_Sup.Properties.ValueMember = "ID_Supplier";



        }


        private void LoadLookUpEditStaff()
        {
            string queryStr = "select ID_Account , DisplayName_Account from Account";
            DataTable ds = DataProvider.ExecuteQuery(queryStr);
            cmb_Staff.Properties.DataSource = ds;
            cmb_Staff.Properties.DisplayMember = "DisplayName_Account";
            cmb_Staff.Properties.ValueMember = "ID_Account";

        }


        private void fReciept_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadLookUpEditSup();
            LoadLookUpEditStaff();
            LoadReceiptItem();
            LoadMedItem();
        }

        private void LoadDetails(int id)
        {
            for (int i = 0; i < gridView2.RowCount; i++)
            {

                receiptDetailBindingSource.DataSource = ReceiptDAO.GetDataDetailsByID(id);

            }

        }



        private void ShowCalcMoney(string id)
        {
            double sumMoney = 0;

            for (int i = 0; i < gridView2.RowCount; i++)
            {
                if (gridView2.GetRowCellDisplayText(i, colID_ReceiptDetails).ToString() == id)
                {

                    sumMoney += Convert.ToDouble(gridView2.GetRowCellDisplayText(i, coltoTalPrice));
                }
            }

            txt_SumPrice.Text = sumMoney.ToString();
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txt_IdReciept.Text = gridView1.GetFocusedRowCellValue(colCode_Reciept).ToString();
            dtpk_CreateDay.Text = gridView1.GetFocusedRowCellValue(colCreateDay).ToString();
            cmb_Staff.Text = gridView1.GetFocusedRowCellDisplayText(colID_Account);
            cmb_Sup.Text = gridView1.GetFocusedRowCellDisplayText(colID_Supplier);

            LoadDetails((int)gridView1.GetFocusedRowCellValue(colID_Receipt));

            ShowCalcMoney(txt_IdReciept.Text);
        }

        private void LoadMedItem()
        {
            string queryStr = "select ID_Medicine, Code_MEdicine, Name_Medicine  from Medicine";
            DataTable dt = DataProvider.ExecuteQuery(queryStr);
            repositoryItem_Med.DataSource = dt;
            repositoryItem_Med.DisplayMember = "Name_Medicine";
            repositoryItem_Med.ValueMember = "ID_Medicine";
            repositoryItem_Med.NullText = @"Chọn Thuốc";
            colID_Medicine.ColumnEdit = repositoryItem_Med;


        }

        private void LoadReceiptItem()
        {
            string queryStr = "select ID_Receipt, Code_Reciept from Receipt";
            DataTable dt = DataProvider.ExecuteQuery(queryStr);
            repositoryItem_Reciept.DataSource = dt;
            repositoryItem_Reciept.DisplayMember = "Code_Reciept";
            repositoryItem_Reciept.ValueMember = "ID_Receipt";
            repositoryItem_Reciept.NullText = @"Chọn Hóa Đơn";
            colID_ReceiptDetails.ColumnEdit = repositoryItem_Reciept;


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
                    gridView2.SetRowCellValue(e.RowHandle, "Import_Pirce", dt.Import_Price);
                    //Reset TotolPrice neu thay doi ma thuoc
                    if (gridView2.GetFocusedRowCellValue(colAmount) == null)
                    {
                        Qty = 0;
                    }
                    else
                    {
                        Qty = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colAmount));
                        Price = Convert.ToDouble(gridView2.GetFocusedRowCellValue(colImport_Pirce));
                        totalPrice = Qty * Price;

                        gridView2.SetFocusedRowCellValue(coltoTalPrice, totalPrice);
                    }


                }
            }
            #endregion

            #region Tính Thành tiền
            if (e.Column == colAmount)
            {
                Qty = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colAmount));
                Price = Convert.ToDouble(gridView2.GetFocusedRowCellValue(colImport_Pirce));
                totalPrice = Qty * Price;

                gridView2.SetFocusedRowCellValue(coltoTalPrice, totalPrice);


            }
            #endregion
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                ReceiptDetail obj = new ReceiptDetail();
                obj.ID_ReceiptDetails = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_ReceiptDetails));
                obj.ID_Medicine = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_Medicine));
                obj.Id_Unit = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colId_Unit));
                obj.Amount = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colAmount));
                obj.Import_Pirce = Convert.ToDouble(gridView2.GetFocusedRowCellValue(colImport_Pirce));
                obj.toTalPrice = Convert.ToDouble(gridView2.GetFocusedRowCellValue(coltoTalPrice));
                obj.Bill_Status = false;


                ReceiptDAO.SaveReceiptDetails(obj);
                LoadDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_ReceiptDetails)));


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
                int id = Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_ReceiptDetails));
                ReceiptDAO.DeleteReceiptDetails(id);
                LoadDetails(Convert.ToInt32(gridView2.GetFocusedRowCellValue(colID_ReceiptDetails)));


            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
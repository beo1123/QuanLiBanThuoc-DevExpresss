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
    public partial class fMedicine : DevExpress.XtraEditors.XtraForm
    {
        public fMedicine()
        {
            InitializeComponent();
        }

        #region Chức năng
        private void ToolBars_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Đóng")
            {
                this.Close();
            }
            else
            {
                if (e.Button.Properties.Caption == "Tạo Mới")
                {
                    InsertMed();

                }
                else
                {
                    if (e.Button.Properties.Caption == "Lưu")
                    {
                        UpdateMed();

                    }
                    else
                    {
                        if (e.Button.Properties.Caption == "Xóa")
                        {
                            DeleteMed();

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

        private void fMedicine_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                LoadLookUpEditUnit();
                LoadLookUpEditSuplier();
                
                
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        #endregion


        #region Xử lí chức năng

        
        private void LoadData()
        {
            medicineBindingSource.DataSource = MedicineDAO.GetData();
            unitBindingSource.DataSource = UnitDAO.GetData();
            supplierBindingSource.DataSource = SupplierDAO.GetData();
            
            
        }
        
        private void Clear()
        {
            txt_CodeMed.Text = "";
            txt_NameMed.Text = "";
            txt_ImportPrice.Text = "";
            txt_SalePrice.Text = "";
            rtxt_Note.Text = "";
            cmb_Supplier.Text = "";
            Cmb_Unit.Text = "";
            dtpk_ExpireDay.Text = "";
            txt_Amount.Text = "";

           
        }

        private void InsertMed()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeMed.Text.Trim() == "" || txt_NameMed.Text.Trim() == "" || txt_SalePrice.Text.Trim() == "" || txt_ImportPrice.Text.Trim() == "" || rtxt_Note.Text.Trim() == "" || txt_Amount.Text.Trim() == "" )
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeMed.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Medicine obj = new Medicine();
                obj.Code_MEdicine = txt_CodeMed.Text;
                obj.Name_Medicine = txt_NameMed.Text;
                obj.ID_Supplier = int.Parse(cmb_Supplier.GetColumnValue("ID_Supplier").ToString());
                obj.ID_Unit = int.Parse(Cmb_Unit.GetColumnValue("id_Unit").ToString());
                obj.Amount = int.Parse(txt_Amount.Text);
                obj.Import_Price = float.Parse(txt_ImportPrice.Text);
                obj.Sale_Price = float.Parse(txt_SalePrice.Text);
                obj.Exprired_Day = dtpk_ExpireDay.Value;
                obj.Note = rtxt_Note.Text;

                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn thêm??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    MedicineDAO.InsertMed(obj);
                    LoadData();
                    Clear();




                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void UpdateMed()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeMed.Text.Trim() == "" || txt_NameMed.Text.Trim() == "" || txt_SalePrice.Text.Trim() == "" || txt_ImportPrice.Text.Trim() == "" || rtxt_Note.Text.Trim() == "" || txt_Amount.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeMed.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                
                Medicine obj = new Medicine();
                obj.Code_MEdicine = txt_CodeMed.Text;
                obj.Name_Medicine = txt_NameMed.Text;
                obj.ID_Supplier = int.Parse(cmb_Supplier.GetColumnValue("ID_Supplier").ToString());
                obj.ID_Unit = int.Parse(Cmb_Unit.GetColumnValue("id_Unit").ToString());      
                obj.Amount = int.Parse(txt_Amount.Text);
                obj.Import_Price = float.Parse(txt_ImportPrice.Text);
                obj.Sale_Price = float.Parse(txt_SalePrice.Text);
                obj.Exprired_Day = dtpk_ExpireDay.Value;
                obj.Note = rtxt_Note.Text;


                #endregion




                if (XtraMessageBox.Show("Bạn có thật sự muốn Cập nhật??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    MedicineDAO.UpdateMed(obj);
                    LoadData();
                    
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void DeleteMed()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeMed.Text.Trim() == "" )
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeMed.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                
                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Xóa??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    MedicineDAO.DeleteMed(txt_CodeMed.Text);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


        private void LoadLookUpEditUnit()
        {
            string queryStr = "select id_Unit, Code_Unit  from Unit";
            DataTable ds = DataProvider.ExecuteQuery(queryStr);
            Cmb_Unit.Properties.DataSource = ds;
            Cmb_Unit.Properties.DisplayMember = "Code_Unit";
            Cmb_Unit.Properties.ValueMember = "id_Unit";
            
            

        }


        private void LoadLookUpEditSuplier()
        {
            string queryStr = "select ID_Supplier , Name_Supplier from Supplier";
            DataTable ds = DataProvider.ExecuteQuery(queryStr);
            cmb_Supplier.Properties.DataSource = ds;
            cmb_Supplier.Properties.DisplayMember = "Name_Supplier";
            cmb_Supplier.Properties.ValueMember = "ID_Supplier";

        }





        #endregion 









        //gọi form Unit
        private Form Checkform(Type ftype)
        {
            foreach (Form f in this.MdiChildren) { if (f.GetType() == ftype) { return f; } }
            return null;
        }

        private void btn_addUnit_Click(object sender, EventArgs e)
        {
            Form frm = Checkform(typeof(fUnit));
            if (frm == null)
            {
                fUnit forms = new fUnit();
                forms.Show();       
                

            }
            else
            {
                frm.Activate();
                
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {

            
            
            txt_CodeMed.Text = gridView1.GetFocusedRowCellValue(colCode_MEdicine).ToString();
            txt_NameMed.Text = gridView1.GetFocusedRowCellValue(colName_Medicine).ToString();
            txt_Amount.Text = gridView1.GetFocusedRowCellValue(colAmount).ToString();
            txt_ImportPrice.Text = gridView1.GetFocusedRowCellValue(colImport_Price).ToString();
            txt_SalePrice.Text = gridView1.GetFocusedRowCellValue(colSale_Price).ToString();
            rtxt_Note.Text = gridView1.GetFocusedRowCellValue(colNote).ToString();
            cmb_Supplier.Text = gridView1.GetFocusedRowCellDisplayText(colID_Supplier);
            Cmb_Unit.Text = gridView1.GetFocusedRowCellDisplayText(colID_Unit);
            dtpk_ExpireDay.Text = gridView1.GetFocusedRowCellValue(colExprired_Day).ToString();

            
        }

        
    }
}

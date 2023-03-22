using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiBanThuoc.DTO;
using QuanLiBanThuoc.DAO;

namespace QuanLiBanThuoc.GUI
{
    public partial class fSupplier : DevExpress.XtraEditors.XtraForm
    {
        public fSupplier()
        {
            InitializeComponent();
        }

        private void ToolBars_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Đóng")
            {
                this.Close();
            }
            else
            {
                if (e.Button.Properties.Caption == "Tạo Mới")
                {
                    InsertSup();

                }
                else
                {
                    if (e.Button.Properties.Caption == "Lưu")
                    {
                        UpdateSup();

                    }
                    else
                    {
                        if (e.Button.Properties.Caption == "Xóa")
                        {
                            DeleteSup();

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

        private void gv_Sup_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            
            supplierBindingSource.DataSource = SupplierDAO.GetData();
        }

        private void Clear()
        {
            txt_CodeSup.Text = "";
            txt_NameSup.Text = "";
            txt_AddressSup.Text = "";
            txt_PhoneSup.Text = "";


        }

        private void InsertSup()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_NameSup.Text.Trim() == "" || txt_NameSup.Text.Trim() == "" || txt_AddressSup.Text.Trim() == "" || txt_PhoneSup.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeSup.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Supplier obj = new Supplier();
                obj.Code_Supplier = txt_CodeSup.Text;
                obj.Name_Supplier = txt_NameSup.Text;
                obj.Address_Supplier = txt_AddressSup.Text;
                obj.PhoneNumber = txt_PhoneSup.Text;



                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn thêm??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    SupplierDAO.InsertUnit(obj);
                    LoadData();
                    Clear();





                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void UpdateSup()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_NameSup.Text.Trim() == "" || txt_NameSup.Text.Trim() == "" || txt_AddressSup.Text.Trim() == "" || txt_PhoneSup.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeSup.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Supplier obj = new Supplier();
                obj.Code_Supplier = txt_CodeSup.Text;
                obj.Name_Supplier = txt_NameSup.Text;
                obj.Address_Supplier = txt_AddressSup.Text;
                obj.PhoneNumber = txt_PhoneSup.Text;



                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Cập nhật??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    SupplierDAO.UpdateUnit(obj);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void DeleteSup()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeSup.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeSup.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }



                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Xóa??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    SupplierDAO.DeleteUnit(txt_CodeSup.Text);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txt_CodeSup.Text = gridView1.GetFocusedRowCellValue(colCode_Supplier).ToString();
            txt_NameSup.Text = gridView1.GetFocusedRowCellValue(colName_Supplier).ToString();
            txt_AddressSup.Text = gridView1.GetFocusedRowCellValue(colAddress_Supplier).ToString();
            txt_PhoneSup.Text = gridView1.GetFocusedRowCellValue(colPhoneNumber).ToString();
        }
    }
}
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
    public partial class fCustomer : DevExpress.XtraEditors.XtraForm
    {
        public fCustomer()
        {
            InitializeComponent();
        }
        #region Chức Năng
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
                    InsertCus();

                }
                else
                {
                    if (e.Button.Properties.Caption == "Lưu")
                    {
                        UpdateCus();

                    }
                    else
                    {
                        if (e.Button.Properties.Caption == "Xóa")
                        {
                            DeleteCus();

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
            customerBindingSource.DataSource = CustomerDAO.GetData();

        }

        private void Clear()
        {
            txt_CodeCus.Text = "";
            txt_NameCus.Text = "";
            txt_PhoneCus.Text = "";
            txt_AddressCus.Text = "";

        }

        private void InsertCus()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeCus.Text.Trim() == "" || txt_NameCus.Text.Trim() == "" || txt_AddressCus.Text.Trim() == "" || txt_PhoneCus.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeCus.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Customer obj = new Customer();
                obj.Code_Customer = txt_CodeCus.Text;
                obj.Name_Customer = txt_NameCus.Text;
                obj.PhoneNumber = txt_PhoneCus.Text;
                obj.Address_Customer = txt_AddressCus.Text;
                


                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn thêm??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    CustomerDAO.InsertCus(obj);
                    LoadData();
                    Clear();





                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void UpdateCus()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeCus.Text.Trim() == "" || txt_NameCus.Text.Trim() == "" || txt_AddressCus.Text.Trim() == "" || txt_PhoneCus.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeCus.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Customer obj = new Customer();
                obj.Code_Customer = txt_CodeCus.Text;
                obj.Name_Customer = txt_NameCus.Text;
                obj.PhoneNumber = txt_PhoneCus.Text;
                obj.Address_Customer = txt_AddressCus.Text;



                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Cập nhật??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    CustomerDAO.UpdateCus(obj);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void DeleteCus()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeCus.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeCus.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }



                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Xóa??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    CustomerDAO.DeleteCus(txt_CodeCus.Text);
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
        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txt_CodeCus.Text = gridView1.GetFocusedRowCellValue(colCode_Customer).ToString();
            txt_NameCus.Text = gridView1.GetFocusedRowCellValue(colName_Customer).ToString();
            txt_PhoneCus.Text = gridView1.GetFocusedRowCellValue(colPhoneNumber).ToString();
            txt_AddressCus.Text = gridView1.GetFocusedRowCellValue(colAddress_Customer).ToString();
        }

        private void fCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}
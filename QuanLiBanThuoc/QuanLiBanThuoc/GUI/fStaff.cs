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
    public partial class fStaff : DevExpress.XtraEditors.XtraForm
    {
        public fStaff()
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
                    InsertStaff();

                }
                else
                {
                    if (e.Button.Properties.Caption == "Lưu")
                    {
                        UpdateStaff();

                    }
                    else
                    {
                        if (e.Button.Properties.Caption == "Xóa")
                        {
                            DeleteStaff();

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
            accountBindingSource.DataSource = StaffDAO.GetData();

        }

        private void Clear()
        {
            txt_CodeStaff.Text = "";
            txt_NameStaff.Text = "";
            txt_PhoneStaff.Text = "";
            dtpk_DateOfBirth.Text = "";

        }

        private void InsertStaff()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeStaff.Text.Trim() == "" || txt_NameStaff.Text.Trim() == "" || txt_PhoneStaff.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeStaff.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Account obj = new Account();
                obj.Code_Account = txt_CodeStaff.Text;
                obj.DisplayName_Account = txt_NameStaff.Text;
                obj.PhoneNumber = txt_PhoneStaff.Text;
                obj.DateOfBirth = dtpk_DateOfBirth.Value;
                obj.PassWord_Account = "123";


                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn thêm??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    StaffDAO.InsertStaff(obj);
                    LoadData();
                    Clear();





                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void UpdateStaff()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeStaff.Text.Trim() == "" || txt_NameStaff.Text.Trim() == "" || txt_PhoneStaff.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeStaff.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Account obj = new Account();
                obj.Code_Account = txt_CodeStaff.Text;
                obj.DisplayName_Account = txt_NameStaff.Text;
                obj.PhoneNumber = txt_PhoneStaff.Text;
                obj.DateOfBirth = dtpk_DateOfBirth.Value;


                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Cập nhật??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    StaffDAO.UpdateStaff(obj);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void DeleteStaff()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (txt_CodeStaff.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (txt_CodeStaff.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }



                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Xóa??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    StaffDAO.DeleteStaff(txt_CodeStaff.Text);
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

        private void fStaff_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void gridView1_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            txt_CodeStaff.Text = gridView1.GetFocusedRowCellValue(colCode_Account).ToString();
            txt_NameStaff.Text = gridView1.GetFocusedRowCellValue(colDisplayName_Account).ToString();
            txt_PhoneStaff.Text = gridView1.GetFocusedRowCellValue(colPhoneNumber).ToString();
            dtpk_DateOfBirth.Text = gridView1.GetFocusedRowCellValue(colDateOfBirth).ToString();
        }
    }
}
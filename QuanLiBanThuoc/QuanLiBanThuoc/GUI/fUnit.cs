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
using QuanLiBanThuoc.DAO;
using QuanLiBanThuoc.DTO;
using DevExpress.XtraGrid.Views.Grid;

namespace QuanLiBanThuoc.GUI
{
    public partial class fUnit : DevExpress.XtraEditors.XtraForm
    {
        public fUnit()
        {
            InitializeComponent();
        }

        #region Chức năng

        //các chức năng CRUD
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
                    InsertUnit();

                }
                else
                {
                    if (e.Button.Properties.Caption == "Lưu")
                    {

                        UpdateUnit();

                    }
                    else
                    {
                        if (e.Button.Properties.Caption == "Xóa")
                        {
                            DeleteUnit();

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

        //Load Dữ liệu 
        private void fUnit_Load(object sender, EventArgs e)
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

        
       
        #endregion

        #region Xử lí chức năng

        private void LoadData()
        {
            unitBindingSource.DataSource = UnitDAO.GetData();
            
        }

        private void Clear()
        {
            Code_UnitTextEdit.Text = "";
            Name_UnitTextEdit.Text = "";
        }

        private void InsertUnit()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (Code_UnitTextEdit.Text.Trim() == "" || Name_UnitTextEdit.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (Code_UnitTextEdit.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Unit obj = new Unit();
                obj.Code_Unit = Code_UnitTextEdit.Text;
                obj.Name_Unit = Name_UnitTextEdit.Text;

                #endregion
               

                if (XtraMessageBox.Show("Bạn có thật sự muốn thêm??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    UnitDAO.InsertUnit(obj);
                    LoadData();
                    Clear();
                    




                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private void UpdateUnit()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (Code_UnitTextEdit.Text.Trim() == "" || Name_UnitTextEdit.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (Code_UnitTextEdit.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

                // tạo obj đơn vị
                Unit obj = new Unit();
                obj.Code_Unit = Code_UnitTextEdit.Text;
                obj.Name_Unit = Name_UnitTextEdit.Text;

                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Cập nhật??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    UnitDAO.UpdateUnit(obj);
                    LoadData();
                    Clear();
                }

            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
        private void DeleteUnit()
        {
            try
            {
                #region ràng buộc dữ liệu
                if (Code_UnitTextEdit.Text.Trim() == "")
                {
                    throw new Exception("Vui lòng nhập đày đủ thông tin");

                }
                else
                {
                    if (Code_UnitTextEdit.Text.Length > 10)
                    {
                        throw new Exception("Mã Đơn vị không được phép quá 10 kí tự!!!!");

                    }
                }

             

                #endregion


                if (XtraMessageBox.Show("Bạn có thật sự muốn Xóa??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
                {

                    UnitDAO.DeleteUnit(Code_UnitTextEdit.Text); 
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
            
            Code_UnitTextEdit.Text = gridView1.GetFocusedRowCellValue(colCode_Unit1).ToString();
            Name_UnitTextEdit.Text = gridView1.GetFocusedRowCellValue(colName_Unit1).ToString();

        }
    }
}
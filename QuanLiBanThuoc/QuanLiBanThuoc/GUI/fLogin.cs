using DevExpress.XtraEditors;
using QuanLiBanThuoc.DAO;
using QuanLiBanThuoc.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanThuoc
{
    public partial class fLogin : DevExpress.XtraEditors.XtraForm
    {
        public fLogin()
        {
            InitializeComponent();
        }
        #region Event

        //Chức năng hiện mật khẩu
        private void ck_ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ck_ShowPass.Checked == true)
            {
                txt_Password.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Password.UseSystemPasswordChar = true;

            }
        }
        
        //chức năng thoát 
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("Bạn có thật sự muốn thoát chương trình??", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {

                Application.Exit();
            }
        }
        
        //chức năng đăng nhập
        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_Username.Text.Trim() == "" && txt_Password.Text.Trim() == "")
                {
                    throw new Exception("Vui Lòng Nhập Tên Tài Khoản Và Mật Khẩu!!");
                }
                else
                {
                    if (txt_Username.Text.Trim() == "")
                    {
                        throw new Exception("Vui Lòng Nhập Tên Tài Khoản!");
                    }
                    else
                    {
                        if (txt_Password.Text.Trim() == "")
                        {
                            throw new Exception("Vui Lòng Nhập Mật Khẩu!");
                        }
                        else
                        {
                            if (Login(txt_Username.Text, txt_Password.Text))
                            {
                                fManager fManager = new fManager();
                                this.Hide();
                                fManager.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                XtraMessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

            
            

        }

        bool Login(String userName, String passWord )
        {
            return StaffDAO.Login(userName, passWord);
        }
        #endregion


    }
}
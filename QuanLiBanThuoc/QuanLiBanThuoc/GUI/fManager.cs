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

namespace QuanLiBanThuoc.GUI
{
    public partial class fManager : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public fManager()
        {
            InitializeComponent();
            LoadSkin();
            LoadMainFormInMDI();
        }

        public void LoadSkin()
        {

            DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            themes.LookAndFeel.SkinName = "Visual Studio 2013 Blue";

        }

        private void LoadMainFormInMDI()
        {
            Form frm = Checkform(typeof(fInvoice));
            if (frm == null || frm.IsDisposed)
            {
                fInvoice forms = new fInvoice();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        //Chức Năng
       

        #region Gọi các form con
        //kiểm tra form
        private Form Checkform(Type ftype)
        {
            foreach (Form f in this.MdiChildren) { if (f.GetType() == ftype) { return f; } }
            return null;
        }

        //gọi from hóa đơn
        private void btn_Invoice_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fInvoice)); 
            if (frm == null || frm.IsDisposed) 
            {
                fInvoice forms = new fInvoice(); 
                forms.MdiParent = this; 
                forms.Show(); 
            } 
            else 
            { 
                frm.Activate();
            }
        }
        //gọi form danh sách thuốc

        private void btn_Medicine_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fMedicine));
            if (frm == null || frm.IsDisposed)
            {
                fMedicine forms = new fMedicine();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        //gọi form khách hàng
        private void btn_Customer_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fCustomer));
            if (frm == null || frm.IsDisposed)
            {
                fCustomer forms = new fCustomer();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        //gọi form nhân viên
        private void btn_Staff_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fStaff));
            if (frm == null || frm.IsDisposed)
            {
                fStaff forms = new fStaff();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        //gọi form nhà cung cấp

        private void btn_Suppiler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fSupplier));
            if (frm == null || frm.IsDisposed)
            {
                fSupplier forms = new fSupplier();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }
        //gọi form phiếu nhập thuốc
        private void btn_ImportVoucher_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fReciept));
            if (frm == null || frm.IsDisposed)
            {
                fReciept forms = new fReciept();
                forms.MdiParent = this;
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }


        #endregion

        private void btn_Exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btn_AccountInfo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fSatfDetails));
            if (frm == null || frm.IsDisposed)
            {
                fSatfDetails forms = new fSatfDetails();
                
                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void fManager_Load(object sender, EventArgs e)
        {
            
        }
        #region Báo Cáo
        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fRPTInvoice));
            if (frm == null || frm.IsDisposed)
            {
                fRPTInvoice forms = new fRPTInvoice();
                forms.MdiParent = this;

                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(fRPTReciept));
            if (frm == null || frm.IsDisposed)
            {
                fRPTReciept forms = new fRPTReciept();
                forms.MdiParent = this;

                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(frptStaff));
            if (frm == null || frm.IsDisposed)
            {
                frptStaff forms = new frptStaff();
                forms.MdiParent = this;

                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(frptCustomer));
            if (frm == null || frm.IsDisposed)
            {
                frptCustomer forms = new frptCustomer();
                forms.MdiParent = this;

                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(frptMedicine));
            if (frm == null || frm.IsDisposed)
            {
                frptMedicine forms = new frptMedicine();
                forms.MdiParent = this;

                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = Checkform(typeof(frptSuplier));
            if (frm == null || frm.IsDisposed)
            {
                frptSuplier forms = new frptSuplier();
                forms.MdiParent = this;

                forms.Show();
            }
            else
            {
                frm.Activate();
            }
        }

        #endregion
    }

}
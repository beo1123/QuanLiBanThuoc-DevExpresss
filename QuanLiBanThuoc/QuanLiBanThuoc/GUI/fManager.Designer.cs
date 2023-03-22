
namespace QuanLiBanThuoc.GUI
{
    partial class fManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fManager));
            this.tabbedView = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.Mn_Account = new DevExpress.XtraBars.BarSubItem();
            this.btn_AccountInfo = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Exit = new DevExpress.XtraBars.BarButtonItem();
            this.btn_PassChangge = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Staff = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Customer = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Medicine = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Suppiler = new DevExpress.XtraBars.BarButtonItem();
            this.btn_ImportVoucher = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Invoice = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.Staff = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Customer = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.Medicine = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.CaptionBarItemLinks.Add(this.Mn_Account);
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.Mn_Account,
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.btn_AccountInfo,
            this.btn_PassChangge,
            this.btn_Exit,
            this.btn_Staff,
            this.btn_Customer,
            this.btn_Medicine,
            this.barButtonItem4,
            this.btn_Suppiler,
            this.btn_ImportVoucher,
            this.btn_Invoice,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem5,
            this.barButtonItem6,
            this.barButtonItem7});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonControl1.MaxItemId = 21;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage2,
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(1248, 158);
            // 
            // Mn_Account
            // 
            this.Mn_Account.Caption = "Tài Khoản";
            this.Mn_Account.Id = 3;
            this.Mn_Account.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Mn_Account.ImageOptions.Image")));
            this.Mn_Account.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Mn_Account.ImageOptions.LargeImage")));
            this.Mn_Account.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btn_Exit)});
            this.Mn_Account.Name = "Mn_Account";
            this.Mn_Account.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // btn_AccountInfo
            // 
            this.btn_AccountInfo.Caption = "Thông tin tài khoản";
            this.btn_AccountInfo.Id = 4;
            this.btn_AccountInfo.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_AccountInfo.ImageOptions.SvgImage")));
            this.btn_AccountInfo.Name = "btn_AccountInfo";
            this.btn_AccountInfo.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_AccountInfo_ItemClick);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Caption = "Thoát";
            this.btn_Exit.Id = 6;
            this.btn_Exit.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_Exit.ImageOptions.SvgImage")));
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Exit_ItemClick);
            // 
            // btn_PassChangge
            // 
            this.btn_PassChangge.Caption = "Đổi Mật Khẩu";
            this.btn_PassChangge.Id = 5;
            this.btn_PassChangge.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btn_PassChangge.ImageOptions.SvgImage")));
            this.btn_PassChangge.Name = "btn_PassChangge";
            // 
            // btn_Staff
            // 
            this.btn_Staff.Caption = " Nhân Viên";
            this.btn_Staff.Id = 7;
            this.btn_Staff.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Staff.ImageOptions.Image")));
            this.btn_Staff.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Staff.ImageOptions.LargeImage")));
            this.btn_Staff.LargeWidth = 100;
            this.btn_Staff.Name = "btn_Staff";
            this.btn_Staff.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Staff_ItemClick);
            // 
            // btn_Customer
            // 
            this.btn_Customer.Caption = "Khách Hàng";
            this.btn_Customer.Id = 8;
            this.btn_Customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Customer.ImageOptions.Image")));
            this.btn_Customer.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Customer.ImageOptions.LargeImage")));
            this.btn_Customer.LargeWidth = 100;
            this.btn_Customer.Name = "btn_Customer";
            this.btn_Customer.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Customer_ItemClick);
            // 
            // btn_Medicine
            // 
            this.btn_Medicine.Caption = "Thuốc";
            this.btn_Medicine.Id = 9;
            this.btn_Medicine.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Medicine.ImageOptions.Image")));
            this.btn_Medicine.LargeWidth = 100;
            this.btn_Medicine.Name = "btn_Medicine";
            this.btn_Medicine.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btn_Medicine.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Medicine_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Danh Sách Nhóm Thuốc";
            this.barButtonItem4.Id = 10;
            this.barButtonItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem4.ImageOptions.Image")));
            this.barButtonItem4.LargeWidth = 100;
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btn_Suppiler
            // 
            this.btn_Suppiler.Caption = "Nhà Cung Cấp";
            this.btn_Suppiler.Id = 12;
            this.btn_Suppiler.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Suppiler.ImageOptions.Image")));
            this.btn_Suppiler.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Suppiler.ImageOptions.LargeImage")));
            this.btn_Suppiler.Name = "btn_Suppiler";
            this.btn_Suppiler.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Suppiler_ItemClick);
            // 
            // btn_ImportVoucher
            // 
            this.btn_ImportVoucher.Caption = "Nhập Thuốc";
            this.btn_ImportVoucher.Id = 13;
            this.btn_ImportVoucher.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_ImportVoucher.ImageOptions.Image")));
            this.btn_ImportVoucher.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_ImportVoucher.ImageOptions.LargeImage")));
            this.btn_ImportVoucher.Name = "btn_ImportVoucher";
            this.btn_ImportVoucher.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_ImportVoucher_ItemClick);
            // 
            // btn_Invoice
            // 
            this.btn_Invoice.Caption = "Bán Thuốc";
            this.btn_Invoice.Id = 14;
            this.btn_Invoice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Invoice.ImageOptions.Image")));
            this.btn_Invoice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Invoice.ImageOptions.LargeImage")));
            this.btn_Invoice.Name = "btn_Invoice";
            this.btn_Invoice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Invoice_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Danh Sách Hóa Đơn Bán";
            this.barButtonItem1.Id = 15;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.LargeWidth = 100;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Danh Hóa Đơn Nhập";
            this.barButtonItem2.Id = 16;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.LargeWidth = 100;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Danh Sách Nhân Viên";
            this.barButtonItem3.Id = 17;
            this.barButtonItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem3.ImageOptions.SvgImage")));
            this.barButtonItem3.LargeWidth = 100;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Danh Sách Khách Hàng";
            this.barButtonItem5.Id = 18;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.LargeWidth = 100;
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // barButtonItem6
            // 
            this.barButtonItem6.Caption = "Danh Sách Thuốc";
            this.barButtonItem6.Id = 19;
            this.barButtonItem6.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem6.ImageOptions.SvgImage")));
            this.barButtonItem6.LargeWidth = 100;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem6_ItemClick);
            // 
            // barButtonItem7
            // 
            this.barButtonItem7.Caption = "Danh Sách Nhà Cung Cấp";
            this.barButtonItem7.Id = 20;
            this.barButtonItem7.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem7.ImageOptions.SvgImage")));
            this.barButtonItem7.LargeWidth = 100;
            this.barButtonItem7.Name = "barButtonItem7";
            this.barButtonItem7.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem7_ItemClick);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Chức Năng";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_ImportVoucher);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Invoice);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Bán Thuốc - Nhập Thuốc";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem3);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem7);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Báo Cáo";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.Staff,
            this.Customer,
            this.Medicine,
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Danh Mục";
            // 
            // Staff
            // 
            this.Staff.ItemLinks.Add(this.btn_Staff);
            this.Staff.Name = "Staff";
            this.Staff.Text = "Nhân Viên";
            // 
            // Customer
            // 
            this.Customer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Customer.ImageOptions.Image")));
            this.Customer.ItemLinks.Add(this.btn_Customer);
            this.Customer.Name = "Customer";
            this.Customer.Text = "Khách Hàng";
            // 
            // Medicine
            // 
            this.Medicine.ItemLinks.Add(this.btn_Medicine);
            this.Medicine.Name = "Medicine";
            this.Medicine.Text = "Thuốc";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Suppiler);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Nhà Cung Cấp";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // fManager
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.BackColor2 = System.Drawing.Color.White;
            this.Appearance.BorderColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseBorderColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 799);
            this.Controls.Add(this.ribbonControl1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.InactiveGlowColor = System.Drawing.Color.White;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fManager";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lí Bán Thuốc";
            this.Load += new System.EventHandler(this.fManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Staff;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.BarSubItem Mn_Account;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Customer;
        private DevExpress.XtraBars.BarButtonItem btn_AccountInfo;
        private DevExpress.XtraBars.BarButtonItem btn_PassChangge;
        private DevExpress.XtraBars.BarButtonItem btn_Exit;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Medicine;
        private DevExpress.XtraBars.BarButtonItem btn_Staff;
        private DevExpress.XtraBars.BarButtonItem btn_Customer;
        private DevExpress.XtraBars.BarButtonItem btn_Medicine;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem btn_Suppiler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btn_ImportVoucher;
        private DevExpress.XtraBars.BarButtonItem btn_Invoice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.BarButtonItem barButtonItem7;
    }
}

namespace QuanLiBanThuoc.GUI
{
    partial class fCustomer
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fCustomer));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ToolBars = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gv_Cus = new DevExpress.XtraGrid.GridControl();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_Customer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_Customer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress_Customer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txt_NameCus = new DevExpress.XtraEditors.TextEdit();
            this.txt_CodeCus = new DevExpress.XtraEditors.TextEdit();
            this.txt_AddressCus = new DevExpress.XtraEditors.TextEdit();
            this.txt_PhoneCus = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBars)).BeginInit();
            this.ToolBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Cus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodeCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AddressCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneCus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ToolBars);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(798, 768);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Khách Hàng";
            // 
            // ToolBars
            // 
            this.ToolBars.Controls.Add(this.layoutControl1);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions2.Image")));
            buttonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions3.Image")));
            buttonImageOptions4.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions4.Image")));
            buttonImageOptions5.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions5.Image")));
            this.ToolBars.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Tạo Mới", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Lưu", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Clear", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xóa", true, buttonImageOptions4, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Đóng", true, buttonImageOptions5, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.ToolBars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ToolBars.Location = new System.Drawing.Point(2, 23);
            this.ToolBars.Name = "ToolBars";
            this.ToolBars.Size = new System.Drawing.Size(794, 743);
            this.ToolBars.TabIndex = 0;
            this.ToolBars.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.ToolBars_CustomButtonClick);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.gv_Cus);
            this.layoutControl1.Controls.Add(this.splitContainerControl1);
            this.layoutControl1.Controls.Add(this.txt_NameCus);
            this.layoutControl1.Controls.Add(this.txt_CodeCus);
            this.layoutControl1.Controls.Add(this.txt_AddressCus);
            this.layoutControl1.Controls.Add(this.txt_PhoneCus);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 37);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1146, 503, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(790, 704);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gv_Cus
            // 
            this.gv_Cus.DataSource = this.customerBindingSource;
            this.gv_Cus.Location = new System.Drawing.Point(12, 74);
            this.gv_Cus.MainView = this.gridView1;
            this.gv_Cus.Name = "gv_Cus";
            this.gv_Cus.Size = new System.Drawing.Size(766, 608);
            this.gv_Cus.TabIndex = 15;
            this.gv_Cus.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(QuanLiBanThuoc.DTO.Customer);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_Customer,
            this.colName_Customer,
            this.colPhoneNumber,
            this.colAddress_Customer});
            this.gridView1.GridControl = this.gv_Cus;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colCode_Customer
            // 
            this.colCode_Customer.Caption = "Mã Khách Hàng";
            this.colCode_Customer.FieldName = "Code_Customer";
            this.colCode_Customer.Name = "colCode_Customer";
            this.colCode_Customer.Visible = true;
            this.colCode_Customer.VisibleIndex = 0;
            // 
            // colName_Customer
            // 
            this.colName_Customer.Caption = "Tên Khách Hàng";
            this.colName_Customer.FieldName = "Name_Customer";
            this.colName_Customer.Name = "colName_Customer";
            this.colName_Customer.Visible = true;
            this.colName_Customer.VisibleIndex = 1;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Số Điện Thoại";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 2;
            // 
            // colAddress_Customer
            // 
            this.colAddress_Customer.Caption = "Địa Chỉ Khách Hàng";
            this.colAddress_Customer.FieldName = "Address_Customer";
            this.colAddress_Customer.Name = "colAddress_Customer";
            this.colAddress_Customer.Visible = true;
            this.colAddress_Customer.VisibleIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 60);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(766, 10);
            this.splitContainerControl1.TabIndex = 14;
            // 
            // txt_NameCus
            // 
            this.txt_NameCus.Location = new System.Drawing.Point(383, 12);
            this.txt_NameCus.Name = "txt_NameCus";
            this.txt_NameCus.Size = new System.Drawing.Size(395, 20);
            this.txt_NameCus.StyleController = this.layoutControl1;
            this.txt_NameCus.TabIndex = 5;
            // 
            // txt_CodeCus
            // 
            this.txt_CodeCus.Location = new System.Drawing.Point(93, 12);
            this.txt_CodeCus.Name = "txt_CodeCus";
            this.txt_CodeCus.Size = new System.Drawing.Size(205, 20);
            this.txt_CodeCus.StyleController = this.layoutControl1;
            this.txt_CodeCus.TabIndex = 4;
            // 
            // txt_AddressCus
            // 
            this.txt_AddressCus.Location = new System.Drawing.Point(383, 36);
            this.txt_AddressCus.Name = "txt_AddressCus";
            this.txt_AddressCus.Size = new System.Drawing.Size(395, 20);
            this.txt_AddressCus.StyleController = this.layoutControl1;
            this.txt_AddressCus.TabIndex = 6;
            // 
            // txt_PhoneCus
            // 
            this.txt_PhoneCus.Location = new System.Drawing.Point(93, 36);
            this.txt_PhoneCus.Name = "txt_PhoneCus";
            this.txt_PhoneCus.Properties.Mask.EditMask = "0000-000-000";
            this.txt_PhoneCus.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txt_PhoneCus.Size = new System.Drawing.Size(205, 20);
            this.txt_PhoneCus.StyleController = this.layoutControl1;
            this.txt_PhoneCus.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem10,
            this.layoutControlItem11});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(790, 704);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_CodeCus;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(290, 24);
            this.layoutControlItem1.Text = "Mã Khách Hàng:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(78, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 674);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(770, 10);
            this.emptySpaceItem1.Text = "Mã Thuốc";
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txt_NameCus;
            this.layoutControlItem2.Location = new System.Drawing.Point(290, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(480, 24);
            this.layoutControlItem2.Text = "Tên Khách Hàng";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_AddressCus;
            this.layoutControlItem3.Location = new System.Drawing.Point(290, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(480, 24);
            this.layoutControlItem3.Text = "Địa Chỉ:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_PhoneCus;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(290, 24);
            this.layoutControlItem5.Text = "Số Điện Thoại:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(78, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.splitContainerControl1;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(770, 14);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.gv_Cus;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 62);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(770, 612);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // fCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 768);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("fCustomer.IconOptions.LargeImage")));
            this.Name = "fCustomer";
            this.Text = "Danh Sách Khách Hàng";
            this.Load += new System.EventHandler(this.fCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBars)).EndInit();
            this.ToolBars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Cus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodeCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AddressCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneCus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl ToolBars;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gv_Cus;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit txt_NameCus;
        private DevExpress.XtraEditors.TextEdit txt_CodeCus;
        private DevExpress.XtraEditors.TextEdit txt_AddressCus;
        private DevExpress.XtraEditors.TextEdit txt_PhoneCus;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Customer;
        private DevExpress.XtraGrid.Columns.GridColumn colName_Customer;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress_Customer;
        private System.Windows.Forms.BindingSource customerBindingSource;
    }
}
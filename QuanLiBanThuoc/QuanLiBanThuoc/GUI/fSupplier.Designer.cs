
namespace QuanLiBanThuoc.GUI
{
    partial class fSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fSupplier));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ToolBars = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.gv_Sup = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_Supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_Supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress_Supplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txt_NameSup = new DevExpress.XtraEditors.TextEdit();
            this.txt_CodeSup = new DevExpress.XtraEditors.TextEdit();
            this.txt_AddressSup = new DevExpress.XtraEditors.TextEdit();
            this.txt_PhoneSup = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBars)).BeginInit();
            this.ToolBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameSup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodeSup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AddressSup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneSup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ToolBars);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(798, 768);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Nhà Cung Cấp";
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
            this.layoutControl1.Controls.Add(this.gv_Sup);
            this.layoutControl1.Controls.Add(this.splitContainerControl1);
            this.layoutControl1.Controls.Add(this.txt_NameSup);
            this.layoutControl1.Controls.Add(this.txt_CodeSup);
            this.layoutControl1.Controls.Add(this.txt_AddressSup);
            this.layoutControl1.Controls.Add(this.txt_PhoneSup);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 37);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1146, 503, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(790, 704);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // gv_Sup
            // 
            this.gv_Sup.DataSource = this.supplierBindingSource;
            this.gv_Sup.Location = new System.Drawing.Point(12, 66);
            this.gv_Sup.MainView = this.gridView1;
            this.gv_Sup.Name = "gv_Sup";
            this.gv_Sup.Size = new System.Drawing.Size(766, 616);
            this.gv_Sup.TabIndex = 15;
            this.gv_Sup.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gv_Sup.Load += new System.EventHandler(this.gv_Sup_Load);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_Supplier,
            this.colName_Supplier,
            this.colPhoneNumber,
            this.colAddress_Supplier});
            this.gridView1.GridControl = this.gv_Sup;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colCode_Supplier
            // 
            this.colCode_Supplier.Caption = "Mã Nhà Cung Cấp";
            this.colCode_Supplier.FieldName = "Code_Supplier";
            this.colCode_Supplier.Name = "colCode_Supplier";
            this.colCode_Supplier.Visible = true;
            this.colCode_Supplier.VisibleIndex = 0;
            // 
            // colName_Supplier
            // 
            this.colName_Supplier.Caption = "Tên Nhà Cung Cấp";
            this.colName_Supplier.FieldName = "Name_Supplier";
            this.colName_Supplier.Name = "colName_Supplier";
            this.colName_Supplier.Visible = true;
            this.colName_Supplier.VisibleIndex = 1;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Số Điện Thoại";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 2;
            // 
            // colAddress_Supplier
            // 
            this.colAddress_Supplier.Caption = "Địa Chỉ";
            this.colAddress_Supplier.FieldName = "Address_Supplier";
            this.colAddress_Supplier.Name = "colAddress_Supplier";
            this.colAddress_Supplier.Visible = true;
            this.colAddress_Supplier.VisibleIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 60);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(766, 2);
            this.splitContainerControl1.TabIndex = 14;
            // 
            // txt_NameSup
            // 
            this.txt_NameSup.Location = new System.Drawing.Point(346, 12);
            this.txt_NameSup.Name = "txt_NameSup";
            this.txt_NameSup.Size = new System.Drawing.Size(432, 20);
            this.txt_NameSup.StyleController = this.layoutControl1;
            this.txt_NameSup.TabIndex = 5;
            // 
            // txt_CodeSup
            // 
            this.txt_CodeSup.Location = new System.Drawing.Point(109, 12);
            this.txt_CodeSup.Name = "txt_CodeSup";
            this.txt_CodeSup.Size = new System.Drawing.Size(136, 20);
            this.txt_CodeSup.StyleController = this.layoutControl1;
            this.txt_CodeSup.TabIndex = 4;
            // 
            // txt_AddressSup
            // 
            this.txt_AddressSup.Location = new System.Drawing.Point(346, 36);
            this.txt_AddressSup.Name = "txt_AddressSup";
            this.txt_AddressSup.Size = new System.Drawing.Size(432, 20);
            this.txt_AddressSup.StyleController = this.layoutControl1;
            this.txt_AddressSup.TabIndex = 6;
            // 
            // txt_PhoneSup
            // 
            this.txt_PhoneSup.Location = new System.Drawing.Point(109, 36);
            this.txt_PhoneSup.Name = "txt_PhoneSup";
            this.txt_PhoneSup.Properties.Mask.EditMask = "0000-000-000";
            this.txt_PhoneSup.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txt_PhoneSup.Size = new System.Drawing.Size(136, 20);
            this.txt_PhoneSup.StyleController = this.layoutControl1;
            this.txt_PhoneSup.TabIndex = 8;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem5,
            this.layoutControlItem10,
            this.layoutControlItem11,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(790, 704);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_CodeSup;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(237, 24);
            this.layoutControlItem1.Text = "Mã Nhà Cung Cấp:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(94, 13);
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
            this.layoutControlItem2.Control = this.txt_NameSup;
            this.layoutControlItem2.Location = new System.Drawing.Point(237, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(533, 24);
            this.layoutControlItem2.Text = "Tên Nhà Cung Cấp:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_PhoneSup;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(237, 24);
            this.layoutControlItem5.Text = "Số Điện Thoại:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(94, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.splitContainerControl1;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(770, 6);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.gv_Sup;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 54);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(770, 620);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.txt_AddressSup;
            this.layoutControlItem3.Location = new System.Drawing.Point(237, 24);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(533, 24);
            this.layoutControlItem3.Text = "Địa Chỉ:";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(94, 13);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(QuanLiBanThuoc.DTO.Supplier);
            // 
            // fSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 768);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("fSupplier.IconOptions.LargeImage")));
            this.Name = "fSupplier";
            this.Text = "Danh Sách Nhà Cung Cấp";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBars)).EndInit();
            this.ToolBars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameSup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodeSup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_AddressSup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneSup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl ToolBars;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gv_Sup;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit txt_NameSup;
        private DevExpress.XtraEditors.TextEdit txt_CodeSup;
        private DevExpress.XtraEditors.TextEdit txt_AddressSup;
        private DevExpress.XtraEditors.TextEdit txt_PhoneSup;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraGrid.Columns.GridColumn colName_Supplier;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Supplier;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress_Supplier;
        private System.Windows.Forms.BindingSource supplierBindingSource;
    }
}
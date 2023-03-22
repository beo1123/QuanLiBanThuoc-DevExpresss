
namespace QuanLiBanThuoc.GUI
{
    partial class fStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStaff));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ToolBars = new DevExpress.XtraEditors.GroupControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.dtpk_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.gv_Staff = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_Account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDisplayName_Account = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.txt_NameStaff = new DevExpress.XtraEditors.TextEdit();
            this.txt_CodeStaff = new DevExpress.XtraEditors.TextEdit();
            this.txt_PhoneStaff = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.accountBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBars)).BeginInit();
            this.ToolBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Staff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameStaff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodeStaff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneStaff.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ToolBars);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(798, 768);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Nhân Viên";
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
            this.layoutControl1.Controls.Add(this.dtpk_DateOfBirth);
            this.layoutControl1.Controls.Add(this.gv_Staff);
            this.layoutControl1.Controls.Add(this.splitContainerControl1);
            this.layoutControl1.Controls.Add(this.txt_NameStaff);
            this.layoutControl1.Controls.Add(this.txt_CodeStaff);
            this.layoutControl1.Controls.Add(this.txt_PhoneStaff);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(2, 37);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1146, 503, 650, 400);
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(790, 704);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // dtpk_DateOfBirth
            // 
            this.dtpk_DateOfBirth.Location = new System.Drawing.Point(321, 36);
            this.dtpk_DateOfBirth.Name = "dtpk_DateOfBirth";
            this.dtpk_DateOfBirth.Size = new System.Drawing.Size(457, 21);
            this.dtpk_DateOfBirth.TabIndex = 16;
            // 
            // gv_Staff
            // 
            this.gv_Staff.DataSource = this.accountBindingSource;
            this.gv_Staff.Location = new System.Drawing.Point(12, 65);
            this.gv_Staff.MainView = this.gridView1;
            this.gv_Staff.Name = "gv_Staff";
            this.gv_Staff.Size = new System.Drawing.Size(766, 617);
            this.gv_Staff.TabIndex = 15;
            this.gv_Staff.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_Account,
            this.colDisplayName_Account,
            this.colDateOfBirth,
            this.colPhoneNumber});
            this.gridView1.GridControl = this.gv_Staff;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colCode_Account
            // 
            this.colCode_Account.Caption = "Mã Nhân Viên";
            this.colCode_Account.FieldName = "Code_Account";
            this.colCode_Account.Name = "colCode_Account";
            this.colCode_Account.Visible = true;
            this.colCode_Account.VisibleIndex = 0;
            // 
            // colDisplayName_Account
            // 
            this.colDisplayName_Account.Caption = "Tên Nhân Viên";
            this.colDisplayName_Account.FieldName = "DisplayName_Account";
            this.colDisplayName_Account.Name = "colDisplayName_Account";
            this.colDisplayName_Account.Visible = true;
            this.colDisplayName_Account.VisibleIndex = 1;
            // 
            // colDateOfBirth
            // 
            this.colDateOfBirth.Caption = "Ngày Tháng Nắm Sinh";
            this.colDateOfBirth.FieldName = "DateOfBirth";
            this.colDateOfBirth.Name = "colDateOfBirth";
            this.colDateOfBirth.Visible = true;
            this.colDateOfBirth.VisibleIndex = 2;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Số Điện Thoại";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 3;
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Location = new System.Drawing.Point(12, 60);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(766, 1);
            this.splitContainerControl1.TabIndex = 14;
            // 
            // txt_NameStaff
            // 
            this.txt_NameStaff.Location = new System.Drawing.Point(321, 12);
            this.txt_NameStaff.Name = "txt_NameStaff";
            this.txt_NameStaff.Size = new System.Drawing.Size(457, 20);
            this.txt_NameStaff.StyleController = this.layoutControl1;
            this.txt_NameStaff.TabIndex = 5;
            // 
            // txt_CodeStaff
            // 
            this.txt_CodeStaff.Location = new System.Drawing.Point(88, 12);
            this.txt_CodeStaff.Name = "txt_CodeStaff";
            this.txt_CodeStaff.Size = new System.Drawing.Size(153, 20);
            this.txt_CodeStaff.StyleController = this.layoutControl1;
            this.txt_CodeStaff.TabIndex = 4;
            // 
            // txt_PhoneStaff
            // 
            this.txt_PhoneStaff.Location = new System.Drawing.Point(88, 36);
            this.txt_PhoneStaff.Name = "txt_PhoneStaff";
            this.txt_PhoneStaff.Properties.Mask.EditMask = "0000-000-000";
            this.txt_PhoneStaff.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.txt_PhoneStaff.Size = new System.Drawing.Size(153, 20);
            this.txt_PhoneStaff.StyleController = this.layoutControl1;
            this.txt_PhoneStaff.TabIndex = 8;
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
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(790, 704);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txt_CodeStaff;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(233, 24);
            this.layoutControlItem1.Text = "Mã Nhân Viên:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(73, 13);
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
            this.layoutControlItem2.Control = this.txt_NameStaff;
            this.layoutControlItem2.Location = new System.Drawing.Point(233, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(537, 24);
            this.layoutControlItem2.Text = "Tên Nhân Viên:";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.txt_PhoneStaff;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(233, 24);
            this.layoutControlItem5.Text = "Số Điện Thoại:";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(73, 13);
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.splitContainerControl1;
            this.layoutControlItem10.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(770, 5);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.gv_Staff;
            this.layoutControlItem11.Location = new System.Drawing.Point(0, 53);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(770, 621);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.dtpk_DateOfBirth;
            this.layoutControlItem4.Location = new System.Drawing.Point(233, 24);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(537, 24);
            this.layoutControlItem4.Text = "Ngày Sinh";
            this.layoutControlItem4.TextSize = new System.Drawing.Size(73, 13);
            // 
            // accountBindingSource
            // 
            this.accountBindingSource.DataSource = typeof(QuanLiBanThuoc.DTO.Account);
            // 
            // fStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 768);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("fStaff.IconOptions.LargeImage")));
            this.Name = "fStaff";
            this.Text = "Danh Sách Nhân Viên";
            this.Load += new System.EventHandler(this.fStaff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBars)).EndInit();
            this.ToolBars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Staff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_NameStaff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CodeStaff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_PhoneStaff.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl ToolBars;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gv_Staff;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit txt_NameStaff;
        private DevExpress.XtraEditors.TextEdit txt_CodeStaff;
        private DevExpress.XtraEditors.TextEdit txt_PhoneStaff;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private System.Windows.Forms.DateTimePicker dtpk_DateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Account;
        private DevExpress.XtraGrid.Columns.GridColumn colDisplayName_Account;
        private DevExpress.XtraGrid.Columns.GridColumn colDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.BindingSource accountBindingSource;
    }
}
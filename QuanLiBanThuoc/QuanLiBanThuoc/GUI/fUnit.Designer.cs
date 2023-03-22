
namespace QuanLiBanThuoc.GUI
{
    partial class fUnit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUnit));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions4 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions5 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ToolBars = new DevExpress.XtraEditors.GroupControl();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode_Unit1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_Unit1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Code_UnitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Name_UnitTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForName_Unit = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCode_Unit = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.colCode_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName_Unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ToolBars)).BeginInit();
            this.ToolBars.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Code_UnitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_UnitTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode_Unit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.ToolBars);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(522, 499);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Đơn Vị";
            // 
            // ToolBars
            // 
            this.ToolBars.Controls.Add(this.dataLayoutControl1);
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
            this.ToolBars.Size = new System.Drawing.Size(518, 474);
            this.ToolBars.TabIndex = 0;
            this.ToolBars.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.ToolBars_CustomButtonClick);
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.Code_UnitTextEdit);
            this.dataLayoutControl1.Controls.Add(this.Name_UnitTextEdit);
            this.dataLayoutControl1.Controls.Add(this.gridControl1);
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(2, 37);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(514, 435);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.unitBindingSource;
            this.gridControl1.Location = new System.Drawing.Point(12, 36);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(490, 387);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode_Unit1,
            this.colName_Unit1});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.RowCellClick += new DevExpress.XtraGrid.Views.Grid.RowCellClickEventHandler(this.gridView1_RowCellClick);
            // 
            // colCode_Unit1
            // 
            this.colCode_Unit1.Caption = "Mã Đơn Vị";
            this.colCode_Unit1.FieldName = "Code_Unit";
            this.colCode_Unit1.Name = "colCode_Unit1";
            this.colCode_Unit1.Visible = true;
            this.colCode_Unit1.VisibleIndex = 0;
            // 
            // colName_Unit1
            // 
            this.colName_Unit1.Caption = "Tên Đơn Vị";
            this.colName_Unit1.FieldName = "Name_Unit";
            this.colName_Unit1.Name = "colName_Unit1";
            this.colName_Unit1.Visible = true;
            this.colName_Unit1.VisibleIndex = 1;
            // 
            // Code_UnitTextEdit
            // 
            this.Code_UnitTextEdit.Location = new System.Drawing.Point(67, 12);
            this.Code_UnitTextEdit.Name = "Code_UnitTextEdit";
            this.Code_UnitTextEdit.Size = new System.Drawing.Size(121, 20);
            this.Code_UnitTextEdit.StyleController = this.dataLayoutControl1;
            this.Code_UnitTextEdit.TabIndex = 4;
            // 
            // Name_UnitTextEdit
            // 
            this.Name_UnitTextEdit.Location = new System.Drawing.Point(247, 12);
            this.Name_UnitTextEdit.Name = "Name_UnitTextEdit";
            this.Name_UnitTextEdit.Size = new System.Drawing.Size(255, 20);
            this.Name_UnitTextEdit.StyleController = this.dataLayoutControl1;
            this.Name_UnitTextEdit.TabIndex = 5;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(514, 435);
            this.Root.TextVisible = false;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForName_Unit,
            this.ItemForCode_Unit,
            this.layoutControlItem1});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(494, 415);
            // 
            // ItemForName_Unit
            // 
            this.ItemForName_Unit.Control = this.Name_UnitTextEdit;
            this.ItemForName_Unit.Location = new System.Drawing.Point(180, 0);
            this.ItemForName_Unit.Name = "ItemForName_Unit";
            this.ItemForName_Unit.Size = new System.Drawing.Size(314, 24);
            this.ItemForName_Unit.Text = "Tên Đơn Vị";
            this.ItemForName_Unit.TextSize = new System.Drawing.Size(52, 13);
            // 
            // ItemForCode_Unit
            // 
            this.ItemForCode_Unit.Control = this.Code_UnitTextEdit;
            this.ItemForCode_Unit.Location = new System.Drawing.Point(0, 0);
            this.ItemForCode_Unit.Name = "ItemForCode_Unit";
            this.ItemForCode_Unit.Size = new System.Drawing.Size(180, 24);
            this.ItemForCode_Unit.Text = "Mã Đơn Vị";
            this.ItemForCode_Unit.TextSize = new System.Drawing.Size(52, 13);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(494, 391);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // colCode_Unit
            // 
            this.colCode_Unit.Caption = "Mã Đơn Vị";
            this.colCode_Unit.FieldName = "Code_Unit";
            this.colCode_Unit.Name = "colCode_Unit";
            this.colCode_Unit.Visible = true;
            this.colCode_Unit.VisibleIndex = 0;
            // 
            // colName_Unit
            // 
            this.colName_Unit.Caption = "Tên Đơn Vị";
            this.colName_Unit.FieldName = "Name_Unit";
            this.colName_Unit.Name = "colName_Unit";
            this.colName_Unit.Visible = true;
            this.colName_Unit.VisibleIndex = 1;
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataSource = typeof(QuanLiBanThuoc.DTO.Unit);
            // 
            // fUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 499);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("fUnit.IconOptions.Image")));
            this.Name = "fUnit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Đơn Vị";
            this.Load += new System.EventHandler(this.fUnit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ToolBars)).EndInit();
            this.ToolBars.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Code_UnitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name_UnitTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCode_Unit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl ToolBars;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Unit;
        private DevExpress.XtraGrid.Columns.GridColumn colName_Unit;
        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraEditors.TextEdit Code_UnitTextEdit;
        private DevExpress.XtraEditors.TextEdit Name_UnitTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCode_Unit;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName_Unit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colCode_Unit1;
        private DevExpress.XtraGrid.Columns.GridColumn colName_Unit1;
        private System.Windows.Forms.BindingSource unitBindingSource;
    }
}
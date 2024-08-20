
namespace NGANHANG
{
    partial class Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.Windows.Forms.Label sOTKLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.dSTK = new NGANHANG.DSTK();
            this.tAIKHOANTableAdapter = new NGANHANG.DSTKTableAdapters.TAIKHOANTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTKTableAdapters.TableAdapterManager();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barHeaderItem2 = new DevExpress.XtraBars.BarHeaderItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.maNV_login = new DevExpress.XtraBars.BarButtonItem();
            this.hoTen_login = new DevExpress.XtraBars.BarButtonItem();
            this.nhom_login = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barManager2 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXemDuLieu = new System.Windows.Forms.Button();
            this.btnxem = new System.Windows.Forms.Button();
            this.btnXembaocao = new System.Windows.Forms.Button();
            this.DEdenngay = new DevExpress.XtraEditors.DateEdit();
            this.DEtungay = new DevExpress.XtraEditors.DateEdit();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tAIKHOANGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSODUDAU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYGIAODICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOAIGIAODICH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODUSAU = new DevExpress.XtraGrid.Columns.GridColumn();
            label3 = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEdenngay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEdenngay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEtungay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEtungay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = System.Windows.Forms.Cursors.No;
            label3.Location = new System.Drawing.Point(738, 192);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 17);
            label3.TabIndex = 20;
            label3.Text = "Đến ngày";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Cursor = System.Windows.Forms.Cursors.No;
            nGAYMOTKLabel.Location = new System.Drawing.Point(738, 112);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(60, 17);
            nGAYMOTKLabel.TabIndex = 18;
            nGAYMOTKLabel.Text = "Từ ngày";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(738, 37);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(87, 17);
            sOTKLabel.TabIndex = 16;
            sOTKLabel.Text = "Số tài khoản";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1385, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(565, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(766, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "SAO KÊ GIAO DỊCH CỦA MỘT TÀI KHOẢN TRONG MỘT KHOẢNG THỜI GIAN";
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "TAIKHOAN";
            this.bdsTK.DataSource = this.dSTK;
            // 
            // dSTK
            // 
            this.dSTK.DataSetName = "DSTK";
            this.dSTK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = this.tAIKHOANTableAdapter;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barHeaderItem1,
            this.maNV_login,
            this.hoTen_login,
            this.nhom_login,
            this.barButtonItem1,
            this.barHeaderItem2});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 6;
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 1;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHeaderItem2)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barHeaderItem2
            // 
            this.barHeaderItem2.Appearance.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barHeaderItem2.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.barHeaderItem2.Appearance.Options.UseFont = true;
            this.barHeaderItem2.Appearance.Options.UseForeColor = true;
            this.barHeaderItem2.Caption = "BÁO CÁO";
            this.barHeaderItem2.Id = 5;
            this.barHeaderItem2.Name = "barHeaderItem2";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.maNV_login),
            new DevExpress.XtraBars.LinkPersistInfo(this.hoTen_login),
            new DevExpress.XtraBars.LinkPersistInfo(this.nhom_login)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // maNV_login
            // 
            this.maNV_login.Caption = "barButtonItem1";
            this.maNV_login.Id = 1;
            this.maNV_login.Name = "maNV_login";
            // 
            // hoTen_login
            // 
            this.hoTen_login.Caption = "barButtonItem2";
            this.hoTen_login.Id = 2;
            this.hoTen_login.Name = "hoTen_login";
            // 
            // nhom_login
            // 
            this.nhom_login.Caption = "barButtonItem3";
            this.nhom_login.Id = 3;
            this.nhom_login.Name = "nhom_login";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1385, 47);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 793);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1385, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 47);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 746);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1385, 47);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 746);
            // 
            // barHeaderItem1
            // 
            this.barHeaderItem1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barHeaderItem1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.barHeaderItem1.Appearance.Options.UseFont = true;
            this.barHeaderItem1.Appearance.Options.UseForeColor = true;
            this.barHeaderItem1.Caption = "SAO KÊ GIAO DỊCH CỦA MỘT TÀI KHOẢN TRONG MỘT KHOẢNG THỜI GIAN";
            this.barHeaderItem1.Id = 0;
            this.barHeaderItem1.Name = "barHeaderItem1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Id = 4;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barManager2
            // 
            this.barManager2.DockControls.Add(this.barDockControl1);
            this.barManager2.DockControls.Add(this.barDockControl2);
            this.barManager2.DockControls.Add(this.barDockControl3);
            this.barManager2.DockControls.Add(this.barDockControl4);
            this.barManager2.Form = this;
            // 
            // barDockControl1
            // 
            this.barDockControl1.CausesValidation = false;
            this.barDockControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControl1.Location = new System.Drawing.Point(0, 0);
            this.barDockControl1.Manager = this.barManager2;
            this.barDockControl1.Size = new System.Drawing.Size(1385, 0);
            // 
            // barDockControl2
            // 
            this.barDockControl2.CausesValidation = false;
            this.barDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControl2.Location = new System.Drawing.Point(0, 820);
            this.barDockControl2.Manager = this.barManager2;
            this.barDockControl2.Size = new System.Drawing.Size(1385, 0);
            // 
            // barDockControl3
            // 
            this.barDockControl3.CausesValidation = false;
            this.barDockControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControl3.Location = new System.Drawing.Point(0, 0);
            this.barDockControl3.Manager = this.barManager2;
            this.barDockControl3.Size = new System.Drawing.Size(0, 820);
            // 
            // barDockControl4
            // 
            this.barDockControl4.CausesValidation = false;
            this.barDockControl4.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControl4.Location = new System.Drawing.Point(1385, 0);
            this.barDockControl4.Manager = this.barManager2;
            this.barDockControl4.Size = new System.Drawing.Size(0, 820);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnXemDuLieu);
            this.panel2.Controls.Add(this.btnxem);
            this.panel2.Controls.Add(this.btnXembaocao);
            this.panel2.Controls.Add(label3);
            this.panel2.Controls.Add(this.DEdenngay);
            this.panel2.Controls.Add(nGAYMOTKLabel);
            this.panel2.Controls.Add(this.DEtungay);
            this.panel2.Controls.Add(sOTKLabel);
            this.panel2.Controls.Add(this.txtSTK);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 106);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1385, 360);
            this.panel2.TabIndex = 9;
            // 
            // btnXemDuLieu
            // 
            this.btnXemDuLieu.Location = new System.Drawing.Point(720, 271);
            this.btnXemDuLieu.Name = "btnXemDuLieu";
            this.btnXemDuLieu.Size = new System.Drawing.Size(152, 38);
            this.btnXemDuLieu.TabIndex = 23;
            this.btnXemDuLieu.Text = "Xem dữ liệu";
            this.btnXemDuLieu.UseVisualStyleBackColor = true;
            this.btnXemDuLieu.Click += new System.EventHandler(this.btnXemDuLieu_Click);
            // 
            // btnxem
            // 
            this.btnxem.Location = new System.Drawing.Point(1076, 39);
            this.btnxem.Name = "btnxem";
            this.btnxem.Size = new System.Drawing.Size(92, 30);
            this.btnxem.TabIndex = 15;
            this.btnxem.Text = "Tra cứu";
            this.btnxem.UseVisualStyleBackColor = true;
            this.btnxem.Click += new System.EventHandler(this.btnxem_Click);
            // 
            // btnXembaocao
            // 
            this.btnXembaocao.Location = new System.Drawing.Point(996, 271);
            this.btnXembaocao.Name = "btnXembaocao";
            this.btnXembaocao.Size = new System.Drawing.Size(152, 38);
            this.btnXembaocao.TabIndex = 22;
            this.btnXembaocao.Text = "Xuất báo cáo";
            this.btnXembaocao.UseVisualStyleBackColor = true;
            this.btnXembaocao.Click += new System.EventHandler(this.btnXembaocao_Click);
            // 
            // DEdenngay
            // 
            this.DEdenngay.EditValue = null;
            this.DEdenngay.Location = new System.Drawing.Point(859, 187);
            this.DEdenngay.Name = "DEdenngay";
            this.DEdenngay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEdenngay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEdenngay.Size = new System.Drawing.Size(128, 22);
            this.DEdenngay.TabIndex = 21;
            this.DEdenngay.EditValueChanged += new System.EventHandler(this.DEdenngay_EditValueChanged);
            this.DEdenngay.Click += new System.EventHandler(this.DENgayKetThuc_MouseClick);
            // 
            // DEtungay
            // 
            this.DEtungay.EditValue = null;
            this.DEtungay.Location = new System.Drawing.Point(859, 107);
            this.DEtungay.Name = "DEtungay";
            this.DEtungay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEtungay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DEtungay.Size = new System.Drawing.Size(128, 22);
            this.DEtungay.TabIndex = 19;
            this.DEtungay.EditValueChanged += new System.EventHandler(this.DEtungay_EditValueChanged);
            this.DEtungay.Click += new System.EventHandler(this.DENgayBatDau_MouseClick);
            // 
            // txtSTK
            // 
            this.txtSTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SOTK", true));
            this.txtSTK.Location = new System.Drawing.Point(862, 43);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(125, 22);
            this.txtSTK.TabIndex = 17;
            this.txtSTK.EditValueChanged += new System.EventHandler(this.txtSTK_EditValueChanged_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tAIKHOANGridControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 466);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1385, 327);
            this.panel3.TabIndex = 23;
            // 
            // tAIKHOANGridControl
            // 
            this.tAIKHOANGridControl.DataSource = this.bdsTK;
            this.tAIKHOANGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tAIKHOANGridControl.Location = new System.Drawing.Point(0, 0);
            this.tAIKHOANGridControl.MainView = this.gridView1;
            this.tAIKHOANGridControl.MenuManager = this.barManager1;
            this.tAIKHOANGridControl.Name = "tAIKHOANGridControl";
            this.tAIKHOANGridControl.Size = new System.Drawing.Size(1385, 327);
            this.tAIKHOANGridControl.TabIndex = 0;
            this.tAIKHOANGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.tAIKHOANGridControl.Visible = false;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSODUDAU,
            this.colNGAYGIAODICH,
            this.colLOAIGIAODICH,
            this.colSOTIEN,
            this.colSODUSAU});
            this.gridView1.GridControl = this.tAIKHOANGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSODUDAU
            // 
            this.colSODUDAU.Caption = "SODUDAU";
            this.colSODUDAU.FieldName = "SODUDAU";
            this.colSODUDAU.MinWidth = 25;
            this.colSODUDAU.Name = "colSODUDAU";
            this.colSODUDAU.Visible = true;
            this.colSODUDAU.VisibleIndex = 0;
            this.colSODUDAU.Width = 94;
            // 
            // colNGAYGIAODICH
            // 
            this.colNGAYGIAODICH.Caption = "NGAYGIAODICH";
            this.colNGAYGIAODICH.FieldName = "NGAYGD";
            this.colNGAYGIAODICH.MinWidth = 25;
            this.colNGAYGIAODICH.Name = "colNGAYGIAODICH";
            this.colNGAYGIAODICH.Visible = true;
            this.colNGAYGIAODICH.VisibleIndex = 1;
            this.colNGAYGIAODICH.Width = 94;
            // 
            // colLOAIGIAODICH
            // 
            this.colLOAIGIAODICH.Caption = "LOAIGIAODICH";
            this.colLOAIGIAODICH.FieldName = "LOAIGD";
            this.colLOAIGIAODICH.MinWidth = 25;
            this.colLOAIGIAODICH.Name = "colLOAIGIAODICH";
            this.colLOAIGIAODICH.Visible = true;
            this.colLOAIGIAODICH.VisibleIndex = 2;
            this.colLOAIGIAODICH.Width = 94;
            // 
            // colSOTIEN
            // 
            this.colSOTIEN.Caption = "SOTIEN";
            this.colSOTIEN.FieldName = "SOTIEN";
            this.colSOTIEN.MinWidth = 25;
            this.colSOTIEN.Name = "colSOTIEN";
            this.colSOTIEN.Visible = true;
            this.colSOTIEN.VisibleIndex = 3;
            this.colSOTIEN.Width = 94;
            // 
            // colSODUSAU
            // 
            this.colSODUSAU.Caption = "SODUSAU";
            this.colSODUSAU.FieldName = "SODUSAU";
            this.colSODUSAU.MinWidth = 25;
            this.colSODUSAU.Name = "colSODUSAU";
            this.colSODUSAU.Visible = true;
            this.colSODUSAU.VisibleIndex = 4;
            this.colSODUSAU.Width = 94;
            // 
            // Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 820);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Name = "Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian";
            this.Text = "Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian";
            this.Load += new System.EventHandler(this.Frpt_SaoKeGiaoDichCuaMotTaiKhoanTrongMotKhoanThoiGian_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DEdenngay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEdenngay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEtungay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEtungay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tAIKHOANGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSTK dSTK;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTKTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private DSTKTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem maNV_login;
        private DevExpress.XtraBars.BarButtonItem hoTen_login;
        private DevExpress.XtraBars.BarButtonItem nhom_login;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarManager barManager2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button btnxem;
        public System.Windows.Forms.Button btnXembaocao;
        public DevExpress.XtraEditors.DateEdit DEdenngay;
        public DevExpress.XtraEditors.DateEdit DEtungay;
        public DevExpress.XtraEditors.TextEdit txtSTK;
        public DevExpress.XtraGrid.GridControl tAIKHOANGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSODUDAU;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYGIAODICH;
        private DevExpress.XtraGrid.Columns.GridColumn colLOAIGIAODICH;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn colSODUSAU;
        private System.Windows.Forms.Button btnXemDuLieu;
    }
}

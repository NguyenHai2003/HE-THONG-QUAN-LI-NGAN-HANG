
namespace NGANHANG.View
{
    partial class frmTraCuuKhachHang
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
            System.Windows.Forms.Label cMNDLabel;
            System.Windows.Forms.Label mACNLabel1;
            System.Windows.Forms.Label mACNLabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label pHAILabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label sOTKLabel;
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbChiNhanh = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.dSTK = new NGANHANG.DSTK();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.pnTTKH = new System.Windows.Forms.Panel();
            this.btnXacNhan3 = new System.Windows.Forms.Button();
            this.btnXacNhan2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.txtMACN_TK = new DevExpress.XtraEditors.TextEdit();
            this.txtMACN_KH = new DevExpress.XtraEditors.TextEdit();
            this.DENgaymotk = new DevExpress.XtraEditors.DateEdit();
            this.txtSoDu = new DevExpress.XtraEditors.TextEdit();
            this.txtPhai = new DevExpress.XtraEditors.TextEdit();
            this.txtDiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txtHo = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtSTK = new DevExpress.XtraEditors.TextEdit();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.kHACHHANGTableAdapter = new NGANHANG.DSTKTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTKTableAdapters.TableAdapterManager();
            this.tAIKHOANTableAdapter = new NGANHANG.DSTKTableAdapters.TAIKHOANTableAdapter();
            this.kHACHHANGGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colSOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPHAI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSODT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAYMOTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMACNTK = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            cMNDLabel = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            mACNLabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            sODULabel = new System.Windows.Forms.Label();
            pHAILabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            tENLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            this.pnTTKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN_TK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN_KH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DENgaymotk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DENgaymotk.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cMNDLabel
            // 
            cMNDLabel.AutoSize = true;
            cMNDLabel.Location = new System.Drawing.Point(198, 363);
            cMNDLabel.Name = "cMNDLabel";
            cMNDLabel.Size = new System.Drawing.Size(51, 17);
            cMNDLabel.TabIndex = 77;
            cMNDLabel.Text = "CMND:";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Location = new System.Drawing.Point(1034, 569);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(159, 17);
            mACNLabel1.TabIndex = 75;
            mACNLabel1.Text = "Chi nhánh tạo tài khoản:";
            // 
            // mACNLabel
            // 
            mACNLabel.AutoSize = true;
            mACNLabel.Location = new System.Drawing.Point(98, 634);
            mACNLabel.Name = "mACNLabel";
            mACNLabel.Size = new System.Drawing.Size(151, 17);
            mACNLabel.TabIndex = 73;
            mACNLabel.Text = "Chi nhánh khách hàng:";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Location = new System.Drawing.Point(1071, 496);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(129, 17);
            nGAYMOTKLabel.TabIndex = 70;
            nGAYMOTKLabel.Text = "Ngày mở tài khoản:";
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(1138, 433);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(50, 17);
            sODULabel.TabIndex = 69;
            sODULabel.Text = "Số dư:";
            // 
            // pHAILabel
            // 
            pHAILabel.AutoSize = true;
            pHAILabel.Location = new System.Drawing.Point(211, 494);
            pHAILabel.Name = "pHAILabel";
            pHAILabel.Size = new System.Drawing.Size(38, 17);
            pHAILabel.TabIndex = 67;
            pHAILabel.Text = "Phái:";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(196, 558);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(53, 17);
            dIACHILabel.TabIndex = 65;
            dIACHILabel.Text = "Địa chỉ:";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.Location = new System.Drawing.Point(219, 429);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(30, 17);
            hOLabel.TabIndex = 63;
            hOLabel.Text = "Họ:";
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.Location = new System.Drawing.Point(528, 429);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(36, 17);
            tENLabel.TabIndex = 61;
            tENLabel.Text = "Tên:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(1111, 367);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(89, 17);
            sOTKLabel.TabIndex = 59;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbChiNhanh);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1415, 100);
            this.panel1.TabIndex = 0;
            // 
            // cbChiNhanh
            // 
            this.cbChiNhanh.Enabled = false;
            this.cbChiNhanh.FormattingEnabled = true;
            this.cbChiNhanh.Location = new System.Drawing.Point(733, 59);
            this.cbChiNhanh.Name = "cbChiNhanh";
            this.cbChiNhanh.Size = new System.Drawing.Size(290, 24);
            this.cbChiNhanh.TabIndex = 7;
            this.cbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cbChiNhanh_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(618, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(730, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(293, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "TRA CỨU KHÁCH HÀNG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bdsKH
            // 
            this.bdsKH.DataMember = "KHACHHANG";
            this.bdsKH.DataSource = this.dSTK;
            // 
            // dSTK
            // 
            this.dSTK.DataSetName = "DSTK";
            this.dSTK.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // pnTTKH
            // 
            this.pnTTKH.BackColor = System.Drawing.Color.Transparent;
            this.pnTTKH.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnTTKH.Controls.Add(this.btnXacNhan3);
            this.pnTTKH.Controls.Add(this.btnXacNhan2);
            this.pnTTKH.Controls.Add(this.label4);
            this.pnTTKH.Controls.Add(this.label3);
            this.pnTTKH.Controls.Add(cMNDLabel);
            this.pnTTKH.Controls.Add(this.txtCMND);
            this.pnTTKH.Controls.Add(mACNLabel1);
            this.pnTTKH.Controls.Add(this.txtMACN_TK);
            this.pnTTKH.Controls.Add(mACNLabel);
            this.pnTTKH.Controls.Add(this.txtMACN_KH);
            this.pnTTKH.Controls.Add(nGAYMOTKLabel);
            this.pnTTKH.Controls.Add(this.DENgaymotk);
            this.pnTTKH.Controls.Add(sODULabel);
            this.pnTTKH.Controls.Add(this.txtSoDu);
            this.pnTTKH.Controls.Add(pHAILabel);
            this.pnTTKH.Controls.Add(this.txtPhai);
            this.pnTTKH.Controls.Add(dIACHILabel);
            this.pnTTKH.Controls.Add(this.txtDiaChi);
            this.pnTTKH.Controls.Add(hOLabel);
            this.pnTTKH.Controls.Add(this.txtHo);
            this.pnTTKH.Controls.Add(tENLabel);
            this.pnTTKH.Controls.Add(this.txtTen);
            this.pnTTKH.Controls.Add(sOTKLabel);
            this.pnTTKH.Controls.Add(this.txtSTK);
            this.pnTTKH.Controls.Add(this.btnHuy);
            this.pnTTKH.Controls.Add(this.btnXacNhan);
            this.pnTTKH.Controls.Add(this.label1);
            this.pnTTKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTTKH.Location = new System.Drawing.Point(0, 100);
            this.pnTTKH.Name = "pnTTKH";
            this.pnTTKH.Size = new System.Drawing.Size(1415, 703);
            // 
            // btnXacNhan3
            // 
            this.btnXacNhan3.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan3.Location = new System.Drawing.Point(687, 651);
            this.btnXacNhan3.Name = "btnXacNhan3";
            this.btnXacNhan3.Size = new System.Drawing.Size(131, 38);
            this.btnXacNhan3.TabIndex = 81;
            this.btnXacNhan3.Text = "Xác nhận";
            this.btnXacNhan3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXacNhan3.UseVisualStyleBackColor = false;
            this.btnXacNhan3.Click += new System.EventHandler(this.btnXacNhan3_Click);
            // 
            // btnXacNhan2
            // 
            this.btnXacNhan2.BackColor = System.Drawing.Color.Transparent;
            this.btnXacNhan2.Location = new System.Drawing.Point(687, 651);
            this.btnXacNhan2.Name = "btnXacNhan2";
            this.btnXacNhan2.Size = new System.Drawing.Size(131, 38);
            this.btnXacNhan2.TabIndex = 80;
            this.btnXacNhan2.Text = "Xác nhận";
            this.btnXacNhan2.UseVisualStyleBackColor = false;
            this.btnXacNhan2.Click += new System.EventHandler(this.btnXacNhan2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1181, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(240, 23);
            this.label4.TabIndex = 79;
            this.label4.Text = "THÔNG TIN TÀI KHOẢN";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(264, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "THÔNG TIN KHÁCH HÀNG";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "CMND", true));
            this.txtCMND.Enabled = false;
            this.txtCMND.Location = new System.Drawing.Point(312, 360);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(125, 22);
            this.txtCMND.TabIndex = 78;
            // 
            // txtMACN_TK
            // 
            this.txtMACN_TK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "MACN", true));
            this.txtMACN_TK.Enabled = false;
            this.txtMACN_TK.Location = new System.Drawing.Point(1251, 566);
            this.txtMACN_TK.Name = "txtMACN_TK";
            this.txtMACN_TK.Size = new System.Drawing.Size(125, 22);
            this.txtMACN_TK.TabIndex = 76;
            // 
            // txtMACN_KH
            // 
            this.txtMACN_KH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "MACN", true));
            this.txtMACN_KH.Enabled = false;
            this.txtMACN_KH.Location = new System.Drawing.Point(312, 631);
            this.txtMACN_KH.Name = "txtMACN_KH";
            this.txtMACN_KH.Size = new System.Drawing.Size(125, 22);
            this.txtMACN_KH.TabIndex = 74;
            // 
            // DENgaymotk
            // 
            this.DENgaymotk.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.DENgaymotk.EditValue = null;
            this.DENgaymotk.Enabled = false;
            this.DENgaymotk.Location = new System.Drawing.Point(1251, 493);
            this.DENgaymotk.Name = "DENgaymotk";
            this.DENgaymotk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DENgaymotk.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DENgaymotk.Size = new System.Drawing.Size(191, 22);
            this.DENgaymotk.TabIndex = 72;
            // 
            // txtSoDu
            // 
            this.txtSoDu.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SODU", true));
            this.txtSoDu.Enabled = false;
            this.txtSoDu.Location = new System.Drawing.Point(1251, 428);
            this.txtSoDu.Name = "txtSoDu";
            this.txtSoDu.Size = new System.Drawing.Size(191, 22);
            this.txtSoDu.TabIndex = 71;
            // 
            // txtPhai
            // 
            this.txtPhai.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "PHAI", true));
            this.txtPhai.Enabled = false;
            this.txtPhai.Location = new System.Drawing.Point(312, 491);
            this.txtPhai.Name = "txtPhai";
            this.txtPhai.Size = new System.Drawing.Size(72, 22);
            this.txtPhai.TabIndex = 68;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "DIACHI", true));
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Location = new System.Drawing.Point(312, 555);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(414, 22);
            this.txtDiaChi.TabIndex = 66;
            // 
            // txtHo
            // 
            this.txtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "HO", true));
            this.txtHo.Enabled = false;
            this.txtHo.Location = new System.Drawing.Point(312, 426);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(168, 22);
            this.txtHo.TabIndex = 64;
            // 
            // txtTen
            // 
            this.txtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "TEN", true));
            this.txtTen.Enabled = false;
            this.txtTen.Location = new System.Drawing.Point(601, 426);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(125, 22);
            this.txtTen.TabIndex = 62;
            // 
            // txtSTK
            // 
            this.txtSTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SOTK", true));
            this.txtSTK.Enabled = false;
            this.txtSTK.Location = new System.Drawing.Point(1251, 362);
            this.txtSTK.Name = "txtSTK";
            this.txtSTK.Size = new System.Drawing.Size(191, 22);
            this.txtSTK.TabIndex = 60;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.Location = new System.Drawing.Point(924, 651);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(131, 38);
            this.btnHuy.TabIndex = 58;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.Location = new System.Drawing.Point(687, 651);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(131, 38);
            this.btnXacNhan.TabIndex = 57;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, -23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "TRA CỨU KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // kHACHHANGTableAdapter
            // 
            this.kHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tAIKHOANTableAdapter
            // 
            this.tAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // kHACHHANGGridControl
            // 
            this.kHACHHANGGridControl.DataSource = this.bdsKH;
            this.kHACHHANGGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.kHACHHANGGridControl.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.kHACHHANGGridControl.Location = new System.Drawing.Point(0, 0);
            this.kHACHHANGGridControl.MainView = this.gridView1;
            this.kHACHHANGGridControl.Name = "kHACHHANGGridControl";
            this.kHACHHANGGridControl.Size = new System.Drawing.Size(1411, 283);
            this.kHACHHANGGridControl.TabIndex = 1;
            this.kHACHHANGGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSOTK,
            this.colSODU,
            this.colCMND,
            this.colHO,
            this.colTEN,
            this.colDIACHI,
            this.colPHAI,
            this.colSODT,
            this.colNGAYMOTK,
            this.colMACN,
            this.colMACNTK});
            this.gridView1.GridControl = this.kHACHHANGGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // colSOTK
            // 
            this.colSOTK.Caption = "SOTK";
            this.colSOTK.FieldName = "SOTK";
            this.colSOTK.MinWidth = 25;
            this.colSOTK.Name = "colSOTK";
            this.colSOTK.Visible = true;
            this.colSOTK.VisibleIndex = 0;
            this.colSOTK.Width = 94;
            // 
            // colSODU
            // 
            this.colSODU.Caption = "SODU";
            this.colSODU.FieldName = "SODU";
            this.colSODU.MinWidth = 25;
            this.colSODU.Name = "colSODU";
            this.colSODU.Visible = true;
            this.colSODU.VisibleIndex = 1;
            this.colSODU.Width = 94;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.MinWidth = 25;
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 2;
            this.colCMND.Width = 94;
            // 
            // colHO
            // 
            this.colHO.Caption = "HO";
            this.colHO.FieldName = "HO";
            this.colHO.MinWidth = 25;
            this.colHO.Name = "colHO";
            this.colHO.Visible = true;
            this.colHO.VisibleIndex = 3;
            this.colHO.Width = 94;
            // 
            // colTEN
            // 
            this.colTEN.Caption = "TEN";
            this.colTEN.FieldName = "TEN";
            this.colTEN.MinWidth = 25;
            this.colTEN.Name = "colTEN";
            this.colTEN.Visible = true;
            this.colTEN.VisibleIndex = 4;
            this.colTEN.Width = 94;
            // 
            // colDIACHI
            // 
            this.colDIACHI.Caption = "DIACHI";
            this.colDIACHI.FieldName = "DIACHI";
            this.colDIACHI.MinWidth = 25;
            this.colDIACHI.Name = "colDIACHI";
            this.colDIACHI.Visible = true;
            this.colDIACHI.VisibleIndex = 5;
            this.colDIACHI.Width = 94;
            // 
            // colPHAI
            // 
            this.colPHAI.Caption = "PHAI";
            this.colPHAI.FieldName = "PHAI";
            this.colPHAI.MinWidth = 25;
            this.colPHAI.Name = "colPHAI";
            this.colPHAI.Visible = true;
            this.colPHAI.VisibleIndex = 6;
            this.colPHAI.Width = 94;
            // 
            // colSODT
            // 
            this.colSODT.Caption = "SĐT";
            this.colSODT.FieldName = "SODT";
            this.colSODT.MinWidth = 25;
            this.colSODT.Name = "colSODT";
            this.colSODT.Visible = true;
            this.colSODT.VisibleIndex = 7;
            this.colSODT.Width = 94;
            // 
            // colNGAYMOTK
            // 
            this.colNGAYMOTK.Caption = "NGAYMOTK";
            this.colNGAYMOTK.FieldName = "NGAYMOTK";
            this.colNGAYMOTK.MinWidth = 25;
            this.colNGAYMOTK.Name = "colNGAYMOTK";
            this.colNGAYMOTK.Visible = true;
            this.colNGAYMOTK.VisibleIndex = 8;
            this.colNGAYMOTK.Width = 94;
            // 
            // colMACN
            // 
            this.colMACN.Caption = "CN TAO KHACH HANG";
            this.colMACN.FieldName = "MACN_KH";
            this.colMACN.MinWidth = 25;
            this.colMACN.Name = "colMACN";
            this.colMACN.Visible = true;
            this.colMACN.VisibleIndex = 9;
            this.colMACN.Width = 94;
            // 
            // colMACNTK
            // 
            this.colMACNTK.Caption = "CN TAO TAI KHOAN";
            this.colMACNTK.FieldName = "MACN_TK";
            this.colMACNTK.MinWidth = 25;
            this.colMACNTK.Name = "colMACNTK";
            this.colMACNTK.Visible = true;
            this.colMACNTK.VisibleIndex = 10;
            this.colMACNTK.Width = 94;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.kHACHHANGGridControl);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1415, 287);
            this.panel2.TabIndex = 1;
            // 
            // frmTraCuuKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1415, 803);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnTTKH);
            this.Controls.Add(this.panel1);
            this.Name = "frmTraCuuKhachHang";
            this.Text = "frmTraCuuKhachHang";
            this.Load += new System.EventHandler(this.frmTraCuuKhachHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            this.pnTTKH.ResumeLayout(false);
            this.pnTTKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN_TK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN_KH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DENgaymotk.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DENgaymotk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoDu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPhai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHHANGGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DSTK dSTK;
        public System.Windows.Forms.Panel pnTTKH;
        private DSTKTableAdapters.KHACHHANGTableAdapter kHACHHANGTableAdapter;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTKTableAdapters.TableAdapterManager tableAdapterManager;
        private DSTKTableAdapters.TAIKHOANTableAdapter tAIKHOANTableAdapter;
        private System.Windows.Forms.BindingSource bdsTK;
        private DevExpress.XtraGrid.GridControl kHACHHANGGridControl;
        public DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colSODU;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colHO;
        private DevExpress.XtraGrid.Columns.GridColumn colTEN;
        private DevExpress.XtraGrid.Columns.GridColumn colDIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn colPHAI;
        private DevExpress.XtraGrid.Columns.GridColumn colSODT;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAYMOTK;
        private DevExpress.XtraGrid.Columns.GridColumn colMACN;
        private DevExpress.XtraGrid.Columns.GridColumn colMACNTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit txtCMND;
        private DevExpress.XtraEditors.TextEdit txtMACN_TK;
        private DevExpress.XtraEditors.TextEdit txtMACN_KH;
        private DevExpress.XtraEditors.DateEdit DENgaymotk;
        private DevExpress.XtraEditors.TextEdit txtSoDu;
        private DevExpress.XtraEditors.TextEdit txtPhai;
        private DevExpress.XtraEditors.TextEdit txtDiaChi;
        private DevExpress.XtraEditors.TextEdit txtHo;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtSTK;
        public System.Windows.Forms.Button btnHuy;
        public System.Windows.Forms.Button btnXacNhan;
        public System.Windows.Forms.ComboBox cbChiNhanh;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnXacNhan2;
        public System.Windows.Forms.Button btnXacNhan3;
    }
}
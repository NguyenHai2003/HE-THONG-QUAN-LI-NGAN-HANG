
namespace NGANHANG.View
{
    partial class frmMoTK
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
            System.Windows.Forms.Label sODULabel;
            System.Windows.Forms.Label nGAYMOTKLabel;
            System.Windows.Forms.Label sOTKLabel;
            System.Windows.Forms.Label lbSODT;
            System.Windows.Forms.Label lbNGAYCAP;
            System.Windows.Forms.Label lbPHAI;
            System.Windows.Forms.Label lbDIACHI;
            System.Windows.Forms.Label lbTEN;
            System.Windows.Forms.Label lbHO;
            System.Windows.Forms.Label lbCMND;
            System.Windows.Forms.Label lbMACN;
            System.Windows.Forms.Label cMNDLabel1;
            System.Windows.Forms.Label mACNLabel1;
            this.bdsKH = new System.Windows.Forms.BindingSource(this.components);
            this.dSTK = new NGANHANG.DSTK();
            this.KHACHHANGTableAdapter = new NGANHANG.DSTKTableAdapters.KHACHHANGTableAdapter();
            this.tableAdapterManager = new NGANHANG.DSTKTableAdapters.TableAdapterManager();
            this.bdsTK = new System.Windows.Forms.BindingSource(this.components);
            this.TAIKHOANTableAdapter = new NGANHANG.DSTKTableAdapters.TAIKHOANTableAdapter();
            this.grcKH = new DevExpress.XtraEditors.GroupControl();
            this.txtMACN = new DevExpress.XtraEditors.TextEdit();
            this.txtPHAI = new DevExpress.XtraEditors.TextEdit();
            this.txtSODT = new DevExpress.XtraEditors.TextEdit();
            this.deNGAYCAP = new DevExpress.XtraEditors.DateEdit();
            this.txtDIACHI = new DevExpress.XtraEditors.TextEdit();
            this.txtTEN = new DevExpress.XtraEditors.TextEdit();
            this.txtHO = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND = new DevExpress.XtraEditors.TextEdit();
            this.grcTK = new DevExpress.XtraEditors.GroupControl();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnHUY = new System.Windows.Forms.Button();
            this.btnXN = new System.Windows.Forms.Button();
            this.txtMACN1 = new DevExpress.XtraEditors.TextEdit();
            this.txtCMND1 = new DevExpress.XtraEditors.TextEdit();
            this.txtSODU = new DevExpress.XtraEditors.TextEdit();
            this.deNGAYMOTK = new DevExpress.XtraEditors.DateEdit();
            this.txtSOTK = new DevExpress.XtraEditors.TextEdit();
            sODULabel = new System.Windows.Forms.Label();
            nGAYMOTKLabel = new System.Windows.Forms.Label();
            sOTKLabel = new System.Windows.Forms.Label();
            lbSODT = new System.Windows.Forms.Label();
            lbNGAYCAP = new System.Windows.Forms.Label();
            lbPHAI = new System.Windows.Forms.Label();
            lbDIACHI = new System.Windows.Forms.Label();
            lbTEN = new System.Windows.Forms.Label();
            lbHO = new System.Windows.Forms.Label();
            lbCMND = new System.Windows.Forms.Label();
            lbMACN = new System.Windows.Forms.Label();
            cMNDLabel1 = new System.Windows.Forms.Label();
            mACNLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcKH)).BeginInit();
            this.grcKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHAI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSODT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYCAP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYCAP.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTK)).BeginInit();
            this.grcTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSODU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYMOTK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYMOTK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTK.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sODULabel
            // 
            sODULabel.AutoSize = true;
            sODULabel.Location = new System.Drawing.Point(73, 198);
            sODULabel.Name = "sODULabel";
            sODULabel.Size = new System.Drawing.Size(50, 17);
            sODULabel.TabIndex = 16;
            sODULabel.Text = "Số dư:";
            // 
            // nGAYMOTKLabel
            // 
            nGAYMOTKLabel.AutoSize = true;
            nGAYMOTKLabel.Location = new System.Drawing.Point(73, 253);
            nGAYMOTKLabel.Name = "nGAYMOTKLabel";
            nGAYMOTKLabel.Size = new System.Drawing.Size(69, 17);
            nGAYMOTKLabel.TabIndex = 12;
            nGAYMOTKLabel.Text = "Ngày mở:";
            // 
            // sOTKLabel
            // 
            sOTKLabel.AutoSize = true;
            sOTKLabel.Location = new System.Drawing.Point(73, 144);
            sOTKLabel.Name = "sOTKLabel";
            sOTKLabel.Size = new System.Drawing.Size(89, 17);
            sOTKLabel.TabIndex = 10;
            sOTKLabel.Text = "Số tài khoản:";
            // 
            // lbSODT
            // 
            lbSODT.AutoSize = true;
            lbSODT.Location = new System.Drawing.Point(451, 198);
            lbSODT.Name = "lbSODT";
            lbSODT.Size = new System.Drawing.Size(39, 17);
            lbSODT.TabIndex = 28;
            lbSODT.Text = "SĐT:";
            // 
            // lbNGAYCAP
            // 
            lbNGAYCAP.AutoSize = true;
            lbNGAYCAP.Location = new System.Drawing.Point(451, 88);
            lbNGAYCAP.Name = "lbNGAYCAP";
            lbNGAYCAP.Size = new System.Drawing.Size(71, 17);
            lbNGAYCAP.TabIndex = 26;
            lbNGAYCAP.Text = "Ngày cấp:";
            // 
            // lbPHAI
            // 
            lbPHAI.AutoSize = true;
            lbPHAI.Location = new System.Drawing.Point(66, 198);
            lbPHAI.Name = "lbPHAI";
            lbPHAI.Size = new System.Drawing.Size(61, 17);
            lbPHAI.TabIndex = 24;
            lbPHAI.Text = "Giới tính:";
            // 
            // lbDIACHI
            // 
            lbDIACHI.AutoSize = true;
            lbDIACHI.Location = new System.Drawing.Point(66, 309);
            lbDIACHI.Name = "lbDIACHI";
            lbDIACHI.Size = new System.Drawing.Size(53, 17);
            lbDIACHI.TabIndex = 22;
            lbDIACHI.Text = "Địa chỉ:";
            // 
            // lbTEN
            // 
            lbTEN.AutoSize = true;
            lbTEN.Location = new System.Drawing.Point(451, 144);
            lbTEN.Name = "lbTEN";
            lbTEN.Size = new System.Drawing.Size(36, 17);
            lbTEN.TabIndex = 20;
            lbTEN.Text = "Tên:";
            // 
            // lbHO
            // 
            lbHO.AutoSize = true;
            lbHO.Location = new System.Drawing.Point(66, 144);
            lbHO.Name = "lbHO";
            lbHO.Size = new System.Drawing.Size(30, 17);
            lbHO.TabIndex = 18;
            lbHO.Text = "Họ:";
            // 
            // lbCMND
            // 
            lbCMND.AutoSize = true;
            lbCMND.Location = new System.Drawing.Point(66, 88);
            lbCMND.Name = "lbCMND";
            lbCMND.Size = new System.Drawing.Size(51, 17);
            lbCMND.TabIndex = 16;
            lbCMND.Text = "CMND:";
            // 
            // lbMACN
            // 
            lbMACN.AutoSize = true;
            lbMACN.Location = new System.Drawing.Point(66, 253);
            lbMACN.Name = "lbMACN";
            lbMACN.Size = new System.Drawing.Size(75, 17);
            lbMACN.TabIndex = 30;
            lbMACN.Text = "Chi nhánh:";
            // 
            // cMNDLabel1
            // 
            cMNDLabel1.AutoSize = true;
            cMNDLabel1.Location = new System.Drawing.Point(73, 88);
            cMNDLabel1.Name = "cMNDLabel1";
            cMNDLabel1.Size = new System.Drawing.Size(51, 17);
            cMNDLabel1.TabIndex = 18;
            cMNDLabel1.Text = "CMND:";
            // 
            // mACNLabel1
            // 
            mACNLabel1.AutoSize = true;
            mACNLabel1.Location = new System.Drawing.Point(73, 309);
            mACNLabel1.Name = "mACNLabel1";
            mACNLabel1.Size = new System.Drawing.Size(75, 17);
            mACNLabel1.TabIndex = 19;
            mACNLabel1.Text = "Chi nhánh:";
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
            // KHACHHANGTableAdapter
            // 
            this.KHACHHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHINHANHTableAdapter = null;
            this.tableAdapterManager.GD_CHUYENTIENTableAdapter = null;
            this.tableAdapterManager.GD_GOIRUTTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = this.KHACHHANGTableAdapter;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.TAIKHOANTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = NGANHANG.DSTKTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bdsTK
            // 
            this.bdsTK.DataMember = "FK_TaiKhoan_KhachHang";
            this.bdsTK.DataSource = this.bdsKH;
            // 
            // TAIKHOANTableAdapter
            // 
            this.TAIKHOANTableAdapter.ClearBeforeFill = true;
            // 
            // grcKH
            // 
            this.grcKH.Controls.Add(lbMACN);
            this.grcKH.Controls.Add(this.txtMACN);
            this.grcKH.Controls.Add(this.txtPHAI);
            this.grcKH.Controls.Add(lbSODT);
            this.grcKH.Controls.Add(this.txtSODT);
            this.grcKH.Controls.Add(lbNGAYCAP);
            this.grcKH.Controls.Add(this.deNGAYCAP);
            this.grcKH.Controls.Add(lbPHAI);
            this.grcKH.Controls.Add(lbDIACHI);
            this.grcKH.Controls.Add(this.txtDIACHI);
            this.grcKH.Controls.Add(lbTEN);
            this.grcKH.Controls.Add(this.txtTEN);
            this.grcKH.Controls.Add(lbHO);
            this.grcKH.Controls.Add(this.txtHO);
            this.grcKH.Controls.Add(lbCMND);
            this.grcKH.Controls.Add(this.txtCMND);
            this.grcKH.Dock = System.Windows.Forms.DockStyle.Left;
            this.grcKH.Location = new System.Drawing.Point(0, 0);
            this.grcKH.Name = "grcKH";
            this.grcKH.Size = new System.Drawing.Size(749, 587);
            this.grcKH.TabIndex = 8;
            this.grcKH.Text = "THÔNG TIN KHÁCH HÀNG";
            // 
            // txtMACN
            // 
            this.txtMACN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "MACN", true));
            this.txtMACN.Location = new System.Drawing.Point(202, 250);
            this.txtMACN.Name = "txtMACN";
            this.txtMACN.Size = new System.Drawing.Size(125, 22);
            this.txtMACN.TabIndex = 31;
            // 
            // txtPHAI
            // 
            this.txtPHAI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "PHAI", true));
            this.txtPHAI.Location = new System.Drawing.Point(202, 195);
            this.txtPHAI.Name = "txtPHAI";
            this.txtPHAI.Size = new System.Drawing.Size(125, 22);
            this.txtPHAI.TabIndex = 25;
            // 
            // txtSODT
            // 
            this.txtSODT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "SODT", true));
            this.txtSODT.Location = new System.Drawing.Point(580, 195);
            this.txtSODT.Name = "txtSODT";
            this.txtSODT.Size = new System.Drawing.Size(125, 22);
            this.txtSODT.TabIndex = 29;
            // 
            // deNGAYCAP
            // 
            this.deNGAYCAP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "NGAYCAP", true));
            this.deNGAYCAP.EditValue = null;
            this.deNGAYCAP.Location = new System.Drawing.Point(580, 85);
            this.deNGAYCAP.Name = "deNGAYCAP";
            this.deNGAYCAP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYCAP.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYCAP.Size = new System.Drawing.Size(125, 22);
            this.deNGAYCAP.TabIndex = 27;
            // 
            // txtDIACHI
            // 
            this.txtDIACHI.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "DIACHI", true));
            this.txtDIACHI.Location = new System.Drawing.Point(202, 306);
            this.txtDIACHI.Name = "txtDIACHI";
            this.txtDIACHI.Size = new System.Drawing.Size(503, 22);
            this.txtDIACHI.TabIndex = 23;
            // 
            // txtTEN
            // 
            this.txtTEN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "TEN", true));
            this.txtTEN.Location = new System.Drawing.Point(580, 141);
            this.txtTEN.Name = "txtTEN";
            this.txtTEN.Size = new System.Drawing.Size(125, 22);
            this.txtTEN.TabIndex = 21;
            // 
            // txtHO
            // 
            this.txtHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "HO", true));
            this.txtHO.Location = new System.Drawing.Point(202, 141);
            this.txtHO.Name = "txtHO";
            this.txtHO.Size = new System.Drawing.Size(125, 22);
            this.txtHO.TabIndex = 19;
            // 
            // txtCMND
            // 
            this.txtCMND.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsKH, "CMND", true));
            this.txtCMND.Location = new System.Drawing.Point(202, 85);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(125, 22);
            this.txtCMND.TabIndex = 17;
            // 
            // grcTK
            // 
            this.grcTK.Controls.Add(this.btnCheck);
            this.grcTK.Controls.Add(this.btnHUY);
            this.grcTK.Controls.Add(this.btnXN);
            this.grcTK.Controls.Add(mACNLabel1);
            this.grcTK.Controls.Add(this.txtMACN1);
            this.grcTK.Controls.Add(cMNDLabel1);
            this.grcTK.Controls.Add(this.txtCMND1);
            this.grcTK.Controls.Add(sODULabel);
            this.grcTK.Controls.Add(this.txtSODU);
            this.grcTK.Controls.Add(nGAYMOTKLabel);
            this.grcTK.Controls.Add(this.deNGAYMOTK);
            this.grcTK.Controls.Add(sOTKLabel);
            this.grcTK.Controls.Add(this.txtSOTK);
            this.grcTK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grcTK.Location = new System.Drawing.Point(749, 0);
            this.grcTK.Name = "grcTK";
            this.grcTK.Size = new System.Drawing.Size(550, 587);
            this.grcTK.TabIndex = 0;
            this.grcTK.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(405, 76);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(121, 40);
            this.btnCheck.TabIndex = 23;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnHUY
            // 
            this.btnHUY.Location = new System.Drawing.Point(289, 366);
            this.btnHUY.Name = "btnHUY";
            this.btnHUY.Size = new System.Drawing.Size(109, 42);
            this.btnHUY.TabIndex = 22;
            this.btnHUY.Text = "Hủy";
            this.btnHUY.UseVisualStyleBackColor = true;
            this.btnHUY.Click += new System.EventHandler(this.btnHUY_Click);
            // 
            // btnXN
            // 
            this.btnXN.Location = new System.Drawing.Point(76, 366);
            this.btnXN.Name = "btnXN";
            this.btnXN.Size = new System.Drawing.Size(126, 42);
            this.btnXN.TabIndex = 21;
            this.btnXN.Text = "Xác nhận";
            this.btnXN.UseVisualStyleBackColor = true;
            this.btnXN.Click += new System.EventHandler(this.btnXN_Click);
            // 
            // txtMACN1
            // 
            this.txtMACN1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "MACN", true));
            this.txtMACN1.Location = new System.Drawing.Point(235, 306);
            this.txtMACN1.Name = "txtMACN1";
            this.txtMACN1.Size = new System.Drawing.Size(140, 22);
            this.txtMACN1.TabIndex = 20;
            // 
            // txtCMND1
            // 
            this.txtCMND1.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "CMND", true));
            this.txtCMND1.Location = new System.Drawing.Point(235, 85);
            this.txtCMND1.Name = "txtCMND1";
            this.txtCMND1.Size = new System.Drawing.Size(140, 22);
            this.txtCMND1.TabIndex = 19;
            this.txtCMND1.EditValueChanged += new System.EventHandler(this.txtCMND1_EditValueChanged);
            // 
            // txtSODU
            // 
            this.txtSODU.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SODU", true));
            this.txtSODU.Location = new System.Drawing.Point(235, 195);
            this.txtSODU.Name = "txtSODU";
            this.txtSODU.Size = new System.Drawing.Size(140, 22);
            this.txtSODU.TabIndex = 17;
            // 
            // deNGAYMOTK
            // 
            this.deNGAYMOTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "NGAYMOTK", true));
            this.deNGAYMOTK.EditValue = null;
            this.deNGAYMOTK.Location = new System.Drawing.Point(235, 250);
            this.deNGAYMOTK.Name = "deNGAYMOTK";
            this.deNGAYMOTK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYMOTK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deNGAYMOTK.Size = new System.Drawing.Size(140, 22);
            this.deNGAYMOTK.TabIndex = 13;
            // 
            // txtSOTK
            // 
            this.txtSOTK.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bdsTK, "SOTK", true));
            this.txtSOTK.Location = new System.Drawing.Point(235, 141);
            this.txtSOTK.Name = "txtSOTK";
            this.txtSOTK.Size = new System.Drawing.Size(140, 22);
            this.txtSOTK.TabIndex = 11;
            this.txtSOTK.EditValueChanged += new System.EventHandler(this.txtSOTK_EditValueChanged);
            // 
            // frmMoTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 587);
            this.Controls.Add(this.grcTK);
            this.Controls.Add(this.grcKH);
            this.Name = "frmMoTK";
            this.Text = "frmMoTK";
            this.Load += new System.EventHandler(this.frmMoTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bdsKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsTK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcKH)).EndInit();
            this.grcKH.ResumeLayout(false);
            this.grcKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPHAI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSODT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYCAP.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYCAP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDIACHI.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTEN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grcTK)).EndInit();
            this.grcTK.ResumeLayout(false);
            this.grcTK.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMACN1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCMND1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSODU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYMOTK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deNGAYMOTK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOTK.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DSTK dSTK;
        private System.Windows.Forms.BindingSource bdsKH;
        private DSTKTableAdapters.KHACHHANGTableAdapter KHACHHANGTableAdapter;
        private DSTKTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource bdsTK;
        private DSTKTableAdapters.TAIKHOANTableAdapter TAIKHOANTableAdapter;
        private DevExpress.XtraEditors.GroupControl grcKH;
        public DevExpress.XtraEditors.TextEdit txtPHAI;
        public DevExpress.XtraEditors.TextEdit txtSODT;
        public DevExpress.XtraEditors.DateEdit deNGAYCAP;
        public DevExpress.XtraEditors.TextEdit txtDIACHI;
        public DevExpress.XtraEditors.TextEdit txtTEN;
        public DevExpress.XtraEditors.TextEdit txtHO;
        public DevExpress.XtraEditors.TextEdit txtCMND;
        public DevExpress.XtraEditors.GroupControl grcTK;
        public DevExpress.XtraEditors.TextEdit txtSODU;
        public DevExpress.XtraEditors.DateEdit deNGAYMOTK;
        public DevExpress.XtraEditors.TextEdit txtSOTK;
        public DevExpress.XtraEditors.TextEdit txtMACN;
        public DevExpress.XtraEditors.TextEdit txtMACN1;
        public DevExpress.XtraEditors.TextEdit txtCMND1;
        public System.Windows.Forms.Button btnHUY;
        public System.Windows.Forms.Button btnXN;
        public System.Windows.Forms.Button btnCheck;
    }
}
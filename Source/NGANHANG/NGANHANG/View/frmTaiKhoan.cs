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
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Text.RegularExpressions;
using DevExpress.XtraGrid;
using System.Data.SqlClient;

namespace NGANHANG.View
{
    public partial class frmTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        private SqlDataAdapter adapter;
        SqlDataReader reader = null;
        public static String stk, f_stk;
        String stknhan, sotien;
        private frmMain mainForm;
        public static int redoTimesTK = 0;
        private string undoDelete;
        public static Stack<String> f_undoTK = new Stack<String>();
        public static Stack<String> f_redoTK = new Stack<String>();
        public frmTaiKhoan(frmMain mainForm)
        {
            InitializeComponent();
            ComboBoxHelper.ImportDataDic(cbChiNhanh);
            this.WindowState = FormWindowState.Maximized;
            this.mainForm = mainForm;
        }
        public void ReloadData()
        {
            string query = "SELECT * FROM LINK0.NGANHANG.DBO.TAIKHOAN ORDER BY MACN";
            adapter = new SqlDataAdapter(query, Program.conn);
            this.dSTK.TAIKHOAN.Clear();
            adapter.Fill(this.dSTK.TAIKHOAN);
            authoButtons();
        }
        public void ChangeClick_TaiKhoan()
        {
            gridView1.OptionsBehavior.ReadOnly = true;
            lbTTTK.Enabled = true;
            gcTK.Enabled = true;
        }
        public void ChangeVisible()
        {
            lbRutTien.Visible = lbSoTienRut.Visible = txtSoTienRut.Visible = btnXacNhanRut.Visible = false;
            lbChuyenTien.Visible = lbSTKNhan.Visible = lbSoTienChuyen.Visible = txtSoTienChuyen.Visible = txtSTKNhan.Visible = btnXacNhanChuyen.Visible = false;
            lbGuiTien.Visible = lbSoTienGui.Visible = txtSoTienGui.Visible = btnXacNhanGui.Visible = btnHuy.Visible = false;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            ComboBoxHelper.ImportDataDic(cbChiNhanh);
            cbChiNhanh.SelectedItem = ComboBoxHelper.tenCN_Help;
            maNV_login.Caption = Program.maNV;
            hoTen_login.Caption = Program.mHoten;
            if (Program.mGroup == "NGANHANG")
            {
                nhom_login.Caption = "Ngân hàng";
            }
            else if (Program.mGroup == "CHINHANH")
            {
                nhom_login.Caption = "Chi nhánh";
            }
            else if (Program.mGroup == "KHACHHANG")
            {
                nhom_login.Caption = "Khách hàng";
            }
            checkExist.checkFormTaiKhoan = true;
            dSTK.EnforceConstraints = false;
            authoButtons();
            ReloadData();
        }

        private void btnUndo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                redoTimesTK += 1;
                string cmd = frmMain.undoTK.Pop();
                frmMain.temp_undoTK.Push(cmd);
                frmMain.temp_redoTK.Push(frmMain.redoTK.Pop());

                SqlCommand command = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                command.ExecuteNonQuery();
                ReloadData();
                authoButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi phục hồi tài khoản: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.conn.Close();
            }
            string temp = f_undoTK.Pop();
            int rowHandle = GetRowHandleBySTK(gridView1, temp);
            f_redoTK.Push(temp);
            if (rowHandle != GridControl.InvalidRowHandle)
            {
                gridView1.FocusedRowHandle = rowHandle;
            }
        }

        private void btnRedo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                redoTimesTK -= 1;
                string cmd = frmMain.temp_redoTK.Pop();
                frmMain.redoTK.Push(cmd);
                frmMain.undoTK.Push(frmMain.temp_undoTK.Pop());
                SqlCommand command = new SqlCommand(cmd, Program.conn);
                if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
                command.ExecuteNonQuery();
                this.dSTK.TAIKHOAN.Clear();
                adapter.Fill(this.dSTK.TAIKHOAN);

                authoButtons();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi thực hiện lại thao tác: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Program.conn.Close();
            }
            string temp = f_redoTK.Pop();
            int rowHandle = GetRowHandleBySTK(gridView1, temp);
            f_undoTK.Push(temp);
            if (rowHandle != GridControl.InvalidRowHandle)
            {
                gridView1.FocusedRowHandle = rowHandle;
            }
        }

        private void authoButtons()
        {
            btnUndo.Enabled = (frmMain.undoTK.Count != 0);
            btnRedo.Enabled = (redoTimesTK != 0);
        }

        public int GetRowHandleBySTK(GridView gridView, string stk)
        {
            for (int i = 0; i < gridView.RowCount; i++)
            {
                var cellValue = gridView.GetRowCellValue(i, "SOTK")?.ToString().Trim();

                if (cellValue != null && cellValue.Equals(stk.Trim(), StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }
            return GridControl.InvalidRowHandle;
        }
        private void btnXacNhanGui_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtSoTienGui.Text, out long soTienGui))
            {
                MessageBox.Show("Nhập sai định dạng, số tiền gửi phải là số lớn hơn 100000!");
                txtSoTienGui.Text = "";
                txtSoTienGui.Focus();
                return;
            }
            else if (Int64.Parse(txtSoTienGui.Text) < 100000)
            {
                MessageBox.Show("Số tiền gửi phải lớn hơn 100000");
                txtSoTienGui.Text = "";
                txtSoTienGui.Focus();
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận thực hiện giao dịch gửi tiền?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string query = "LINK0.NGANHANG.DBO.SP_GIAODICHGUIRUT 'GT', '" + soTienGui + "', '" + stk + "', '" + Program.maNV + "'";
                    reader = Program.ExecSqlDataReader(query);

                    if (reader != null && !reader.IsClosed)
                    {
                        reader.Close();
                    }

                    MessageBox.Show("Giao dịch gửi tiền thành công!");
                    txtSoTienGui.Text = "";
                    f_stk = stk;
                }
                else return;
                frmTaiKhoan f = Application.OpenForms.OfType<frmTaiKhoan>().FirstOrDefault();
                if (f != null)
                {
                    f.ReloadData();
                    int rowHandle = GetRowHandleBySTK(f.gridView1, f_stk);
                    if (rowHandle != GridControl.InvalidRowHandle)
                    {
                        f.gridView1.FocusedRowHandle = rowHandle;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Program.conn.State == ConnectionState.Open)
                {
                    Program.conn.Close();
                }
            }
        }

        private void btnXacNhanRut_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtSoDu.Text);
            if (!long.TryParse(txtSoTienRut.Text, out long soTienRut))
            {
                MessageBox.Show("Nhập sai định dạng, số tiền rút phải là số lớn hơn 100000!");
                txtSoTienRut.Text = "";
                txtSoTienRut.Focus();
                return;
            }
            if (Int64.Parse(txtSoTienRut.Text) < 100000)
            {
                MessageBox.Show("Số tiền gửi phải lớn hơn 100000");
                txtSoTienRut.Text = "";
                txtSoTienRut.Focus();
                return;
            }
            if (!decimal.TryParse(txtSoDu.Text, out decimal soDu))
            {
                MessageBox.Show("Số dư không hợp lệ!");
                return;
            }

            if (soTienRut > soDu)
            {
                MessageBox.Show("Tài khoản không đủ để thực hiện giao dịch!");
                return;
            }
            try
            {
                DialogResult result = MessageBox.Show("Xác nhận thực hiện giao dịch rút tiền?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = "LINK0.NGANHANG.DBO.SP_GIAODICHGUIRUT" + "'RT', '" + sotien + "', '" + stk + "', '" + Program.maNV + "'";
                    reader = Program.ExecSqlDataReader(query);

                    if (reader != null && !reader.IsClosed)
                    {
                        reader.Close();
                    }
                    MessageBox.Show("Giao dịch rút tiền thành công!");
                    txtSoTienRut.Text = "";
                    f_stk = stk;
                }
                else return;
                frmTaiKhoan f = Application.OpenForms.OfType<frmTaiKhoan>().FirstOrDefault();
                if (f != null)
                {
                    f.ReloadData();
                    int rowHandle = GetRowHandleBySTK(f.gridView1, f_stk);
                    if (rowHandle != GridControl.InvalidRowHandle)
                    {
                        f.gridView1.FocusedRowHandle = rowHandle;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Program.conn.State == ConnectionState.Open)
                {
                    Program.conn.Close();
                }
            }
        }
        private void btnXacNhanChuyen_Click(object sender, EventArgs e)
        {
            if (!long.TryParse(txtSoTienChuyen.Text, out long soTienChuyen))
            {
                MessageBox.Show("Nhập sai định dạng, số tiền chuyển phải là số!");
                txtSoTienRut.Text = "";
                txtSoTienRut.Focus();
                return;
            }
            if (!decimal.TryParse(txtSoDu.Text, out decimal soDu))
            {
                MessageBox.Show("Số dư không hợp lệ!");
                return;
            }

            if (soTienChuyen > soDu)
            {
                MessageBox.Show("Tài khoản không đủ để thực hiện giao dịch!");
                return;
            }
            try
            {
                f_stk = stknhan;
                DialogResult result = MessageBox.Show("Xác nhận thực hiện giao dịch chuyển tiền?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    string query = "LINK0.NGANHANG.DBO.SP_GIAODICHCHUYENTIEN" + "'" + stknhan + "', " + "'" + stk + "', " + "'" + sotien + "', '" + Program.maNV + "'";
                    reader = Program.ExecSqlDataReader(query);

                    if (reader != null && !reader.IsClosed)
                    {
                        reader.Close();
                    }
                    MessageBox.Show("Giao dịch chuyển tiền thành công!");
                    txtSTKNhan.Text = "";
                    txtSoTienChuyen.Text = "";
                }
                else return;

                // Sau khi giao dịch thành công, reload dữ liệu trên frmTaiKhoan
                frmTaiKhoan f = Application.OpenForms.OfType<frmTaiKhoan>().FirstOrDefault();
                if (f != null)
                {
                    f.ReloadData();
                    int rowHandle = GetRowHandleBySTK(f.gridView1, f_stk);
                    if (rowHandle != GridControl.InvalidRowHandle)
                    {
                        f.gridView1.FocusedRowHandle = rowHandle;
                        f.gridView1.SelectRow(rowHandle);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Program.conn.State == ConnectionState.Open)
                {
                    Program.conn.Close();
                }
            }
        }

        private void txtSoTienChuyen_EditValueChanged(object sender, EventArgs e)
        {
            sotien = txtSoTienChuyen.Text;
        }
        private void txtSoTienChuyen_MouseClick(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtSTKNhan.Text.Trim(), @"^[0-9]+$") == false)
            {
                MessageBox.Show("Số tài khoản chỉ nhận số");
                txtSTKNhan.Text = "";
                txtSTKNhan.Focus();
                return;
            }
            else if (txtSTK.Text.Trim() == txtSTKNhan.Text.Trim())
            {
                MessageBox.Show("Đây là số tài khoản đang thực hiện giao dịch chuyển tiền, vui lòng chọn số tài khoản khác!");
                txtSTKNhan.Text = "";
                txtSTKNhan.Focus();
                return;
            }
            else
            {
                if (Program.ExecSqlKiemTra1("SP_KIEMTRASTK", txtSTKNhan.Text) == 0)
                {
                    MessageBox.Show("Số tài khoản không tồn tại");
                    txtSTKNhan.Text = "";
                    txtSTKNhan.Focus();
                    return;
                }
                else txtSoTienChuyen.Focus();
            }
        }
        private void sOTKTextEdit_EditValueChanged(object sender, EventArgs e)
        {
            stk = txtSTK.Text;
        }
        private void txtSoTienGui_EditValueChanged(object sender, EventArgs e)
        {
            sotien = txtSoTienGui.Text;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ReloadData();
            ChangeClick_TaiKhoan();
            ChangeVisible();
            authoButtons();
            btnXoa.Enabled = btnReload.Enabled = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmMain f = new frmMain();
            f.Show();
        }

        private void btnXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            stk = txtSTK.Text;

            if (Program.ExecSqlKiemTra1("SP_KIEMTRATAIKHOAN", stk) == 1)
            {
                MessageBox.Show("Tài khoản này đã có thực hiện giao dịch hoặc còn số dư trong tài khoản, không thể xóa!");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show("Xác nhận xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    Program.KetNoi();
                    undoDelete = "INSERT INTO LINK0.NGANHANG.DBO.TAIKHOAN (SOTK, CMND, SODU, MACN, NGAYMOTK) VALUES ('" + txtSTK.Text + "', '" + txtCMND.Text + "', '" + txtSoDu.Text + "', '" + txtCN.Text + "', '" + DENgayMTK.Text + "')";
                    f_stk = txtSTK.Text;
                    f_undoTK.Push(txtSTK.Text);
                    string cmd = "DELETE FROM LINK0.NGANHANG.DBO.TAIKHOAN WHERE SOTK = '" + stk + "'";
                    cancelTempStack();
                    frmMain.undoTK.Push(undoDelete);
                    frmMain.redoTK.Push(cmd);
                    Program.ExecSqlNonQuery(cmd);
                    MessageBox.Show("Tài khoản đã được xóa thành công!");
                    authoButtons();
                    ReloadData();
                }
                else return;
            }
        }

        public static void cancelTempStack()
        {
            if (redoTimesTK != 0)
            {
                frmMain.temp_undoTK.Clear();
                frmMain.temp_redoTK.Clear();
                f_redoTK.Clear();
                redoTimesTK = 0;
            }
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ReloadData();
        }

        private void txtSoTienRut_EditValueChanged(object sender, EventArgs e)
        {
            sotien = txtSoTienRut.Text;
        }
        private void txtSTKNhan_EditValueChanged(object sender, EventArgs e)
        {
            stknhan = txtSTKNhan.Text;
        }

    }
}
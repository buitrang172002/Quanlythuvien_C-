using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_BTHuyenTrang_VTAnhTrinh_NVThanh_LDThanh_LTNET
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        // kiem tra dang ky tai khoan
        private int kq = 0;
        private void ktraDK()
        {
            if (txtUser.Text.Length > 0 && txtPass.Text.Length > 0)
            {
                kq = 1;
            }
        }
        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btnDNhap_Click(object sender, EventArgs e)
        {
            ktraDK();
            if (kq == 1)
            {
                string user = txtUser.Text.Trim();
                string pass = txtPass.Text.Trim();

                string sql = "select * from NGUOIDUNG where TenDangNhap = N'" +
                    user + "' and MatKhau = N'" + pass + "'";      
                string sql_loainguoidung = "select LoaiNguoiDung from NGUOIDUNG where TenDangNhap = N'" +
                    user + "' and MatKhau = N'" + pass + "'";

                string type = TruyXuatCSDL.LayMotGiaTri(sql);
                string Type = TruyXuatCSDL.LayMotGiaTri(sql_loainguoidung);
                if (type==" ")
                {
                    MessageBox.Show(
                        "Sai tên đăng nhập hoặc mật khẩu!\nVui lòng nhập lại.",
                        "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPass.Clear();
                    txtUser.Clear();
                    txtUser.Focus();
                }
                if (Type == "Docgia" || Type == "DocGia")
                {
                    this.Hide();
                    frmDGMuon frm = new frmDGMuon();
                    frm.ShowDialog();
                    this.Show();
                }else if (Type == "Nhanvien" || Type == "Admin")
                {
                    this.Hide();
                    frm_Menu_LThanh frm = new frm_Menu_LThanh();
                    frm.ShowDialog();
                    this.Show();
                }
                         
            } 
            else 
            {
                MessageBox.Show("Vui lòng nhập Tài Khoản và Mật Khẩu.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                if (txtUser.Text.Trim() == "")
                {
                    MessageBox.Show("Không được để trống thông tin tài khoản!",
                        "Thông báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                else
                {
                    txtUser.Focus();
                }
            }
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (txtPass.Text.Trim() == "")
                    MessageBox.Show("Không được để trống thông tin tài khoản!",
                        "Thống báo", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                else
                    btnDNhap.Focus();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDangKy frm = new frmDangKy();
            frm.ShowDialog();
            this.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.Hide();
            frmQuenMK frm = new frmQuenMK();
            frm.ShowDialog();
            this.Show();
        }
    }
}

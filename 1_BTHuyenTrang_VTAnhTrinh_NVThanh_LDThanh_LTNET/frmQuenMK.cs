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
    public partial class frmQuenMK : Form
    {
        public frmQuenMK()
        {
            InitializeComponent();
        }

        private void frmQuenMK_Load(object sender, EventArgs e)
        {




        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string TenTaiKhoan = txtUser.Text.Trim();
                string MatKhauMoi = txtConfPass.Text.Trim();
                string MatKhauCu = txtPass.Text.Trim();

                string sqlCheckUser = "SELECT COUNT(*) FROM NGUOIDUNG WHERE TenDangNhap = N'" + TenTaiKhoan + "'";
                int countUser = TruyXuatCSDL.LayMotGiaTriDem(sqlCheckUser);

                if (countUser > 0)
                {
                    int kq = MatKhauMoi.CompareTo(MatKhauCu);
                    if (kq == 0)
                    {
                        string luumk = "UPDATE NGUOIDUNG SET MatKhau = '" + MatKhauMoi + "' WHERE TenDangNhap = N'" + TenTaiKhoan + "'";
                        TruyXuatCSDL.ThemSuaXoa(luumk);

                        MessageBox.Show("Đổi mật khẩu thành công.", "Thông Báo");
                        txtUser.Clear();
                        txtPass.Clear();
                        txtConfPass.Clear();

                        txtUser.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu mới không khớp với mật khẩu cũ.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUser.Clear();
                        txtPass.Clear();
                        txtConfPass.Clear();
                        txtUser.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không tồn tại. Vui lòng nhập lại.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUser.Clear();
                    txtPass.Clear();
                    txtConfPass.Clear();
                    txtUser.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close()
;        }
    }
    
}

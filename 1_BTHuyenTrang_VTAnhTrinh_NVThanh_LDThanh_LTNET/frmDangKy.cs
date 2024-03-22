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
    public partial class frmDangKy : Form
    {
        public frmDangKy()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Phương thức kiểm tra đăng ký
        private int kq;
        private void ktraMK()
        {
            string mk1, mk2;
            mk1 = txtMK.Text;
            mk2 = txtConfPass.Text;
            kq = mk1.CompareTo(mk2);
        }
        private void btnDky_Click(object sender, EventArgs e)
        {
            ktraMK();
            if (kq == 0)
            {
                try
                {
                    // Kiểm tra xem tên đăng nhập đã tồn tại hay chưa
                    string usernameToCheck = txtTenDn.Text; // Tên đăng nhập cần kiểm tra
                    string checkUsernameQuery = "SELECT COUNT(*) FROM NGUOIDUNG WHERE TenDangNhap = N'" + usernameToCheck + "'";
                    int existingUserCount = TruyXuatCSDL.LayMotGiaTriDem(checkUsernameQuery);

                    // Kiểm tra nếu tên đăng nhập đã tồn tại
                    if (existingUserCount > 0)
                    {
                        MessageBox.Show("Tên đăng ký đã tồn tại.\nVui lòng chọn tên đăng nhập khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        // Đặt focus vào ô nhập tên đăng nhập để người dùng có thể nhập tên mới
                        txtTenDn.Focus();
                    }
                    else
                    {
                        // Inserting into NGUOIDUNG table with username and user type
                        string sqldocgia = "INSERT INTO NGUOIDUNG (TenDangNhap, MatKhau, LoaiNguoiDung) VALUES (N'" +
                                            txtTenDn.Text + "', N'" +
                                            txtConfPass.Text + "', N'Docgia')";
                        TruyXuatCSDL.ThemSuaXoa(sqldocgia);

                        // Inserting into DOCGIA table with user details
                        string sql = "INSERT INTO DOCGIA (MaDocGia, TenDocGia, NgaySinh, GioiTinh, DiaChi, LopHoc, NgayTaoThe, MaNhanVienTaoThe, TenDangNhap) VALUES (N'" +
                                            "NULL', N'" + txtHoTen.Text + "', N'" +
                                            dtNgaySinh.Value.ToString("yyyy-MM-dd") + "', N'" +
                                            cbGioiTinh.SelectedItem.ToString() + "', N'" +
                                            txtDiaChi.Text + "', N'" +
                                            txtLopHoc.Text + "', N'" +
                                            dtNgayTaoThe.Value.ToString("yyyy-MM-dd") + "', N'" +
                                            "NULL', N'" +
                                            txtTenDn.Text + "')";
                        TruyXuatCSDL.ThemSuaXoa(sql);
                        MessageBox.Show("Gửi đăng ký thành công!\nVui lòng chờ xét duyệt.");
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("Đăng ký thất bại!\nVui lòng điền đầy đủ thông tin. ", "Thông báo");
                }
                txtHoTen.Text = "";
                dtNgaySinh.Text = "";
                cbGioiTinh.SelectedIndex = -1;
                txtDiaChi.Text = "";
                txtLopHoc.Text = "";
                dtNgayTaoThe.Text = "";
                txtTenDn.Text = "";
                txtMK.Text = "";
                txtConfPass.Text = "";
            }
            else
            {
                MessageBox.Show("Mật khẩu nhập lại không trùng nhau!\nVui lòng nhập lại.", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

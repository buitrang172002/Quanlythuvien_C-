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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            txtmk.Visible = false;
            label6.Visible = false;
            dgvNV.DataSource = TruyXuatCSDL.GetTable("select * from NHANVIEN");
            
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = TruyXuatCSDL.GetTable("select * from NHANVIEN");
            dgvNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvNV.Columns[1].HeaderText = "Tên nhân viên";
            dgvNV.Columns[2].HeaderText = "Ngày sinh";
            dgvNV.Columns[3].HeaderText = "Giới tính";
            dgvNV.Columns[4].HeaderText = "Số điện thoại";
            dgvNV.Columns[5].HeaderText = "Tên đăng nhập";
           

            dgvNV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNV.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNV.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvNV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNV.CurrentRow != null)
            {
                txtMaNV.Text = dgvNV.CurrentRow.Cells[0].Value.ToString();
                txtTenNV.Text =dgvNV.CurrentRow.Cells[1].Value.ToString();
                dtNgaySinh.Text = dgvNV.CurrentRow.Cells[2].Value.ToString();
                cbGioiTinh.Text = dgvNV.CurrentRow.Cells[3].Value.ToString();
                txtsdt.Text = dgvNV.CurrentRow.Cells[4].Value.ToString();
                txtTenDN.Text = dgvNV.CurrentRow.Cells[5].Value.ToString();
               
            }
        }
        public int xuly;
        public void ThemNhanVien()
        {
            try
            {
                string sql_nv = "INSERT INTO NHANVIEN VALUES (N'" + txtMaNV.Text +
                                "', N'" + txtTenNV.Text + "', '" + dtNgaySinh.Value.ToString("yyyy-MM-dd") +
                                "', N'" + cbGioiTinh.Text + "', N'" + txtsdt.Text +
                                "', N'" + txtTenDN.Text + "')";

                string sql_nd = "INSERT INTO NGUOIDUNG VALUES (N'" + txtTenDN.Text + "', N'" + txtmk.Text + "', N'" + "Nhanvien" + "')";

                TruyXuatCSDL.ThemSuaXoa(sql_nd);
                TruyXuatCSDL.ThemSuaXoa(sql_nv);

                dgvNV.DataSource = TruyXuatCSDL.GetTable("SELECT * FROM NhanVien");

                MessageBox.Show("Thêm thông tin nhân viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại! " , "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void SuaNV()
        {
            try
            {
                string sql_nv = "UPDATE NHANVIEN SET TenNhanVien = N'" + txtTenNV.Text +
                    "', NgaySinh = '" + dtNgaySinh.Value.ToString("yyyy-MM-dd") +
                    "', GioiTinh = N'" + cbGioiTinh.Text +
                    "', SoDienThoai = N'" + txtsdt.Text + "'" +
                    " WHERE MaNhanVien = N'" + txtMaNV.Text + "'";


                TruyXuatCSDL.ThemSuaXoa(sql_nv);       
                MessageBox.Show("Cập nhật thông tin nhân viên và người dùng thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật thất bại! " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = true;
            txtmk.Visible = true;
            label6.Visible = true;
            xuly = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnThem.Enabled = true;
            string maNV = txtMaNV.Text;
            int ktsdt;
            bool isNumberSDT = int.TryParse(txtsdt.Text, out ktsdt);
            if (isNumberSDT == false || txtsdt.Text.Length > 12)
            {
                MessageBox.Show("Nhập SDT không đúng.\nVui lòng nhập lại.");
            }

            if (TruyXuatCSDL.KiemTraMaNVTonTai(maNV))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại.\nVui lòng chọn mã nhân viên khác.");
                return; // Dừng việc thêm hoặc cập nhật khi mã nhân viên bị trùng
            }

            // Kiểm tra trùng tên đăng nhập
            
            if (txtMaNV.Text.Length > 0 && txtTenNV.Text.Length> 0 && txtTenDN.Text.Length>0 && txtsdt.Text.Length> 0 && dtNgaySinh.Text.Length>0 && cbGioiTinh.Text.Length > 0)
            {
                if (xuly == 0)
                {
                    ThemNhanVien();
                }
                else if (xuly == 1)
                {
                    SuaNV();
                }
                dgvNV.DataSource = TruyXuatCSDL.GetTable("select * from NhanVien");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            xuly = 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtMaNV.Text; // Mã nhân viên cần xóa

                string sql_nd = "DELETE FROM NGUOIDUNG WHERE TenDangNhap = N'" + txtTenDN.Text + "'";
                string sql_nv = "DELETE FROM NHANVIEN WHERE MaNhanVien = N'" + maNV + "'";
                TruyXuatCSDL.ThemSuaXoa(sql_nv);
                TruyXuatCSDL.ThemSuaXoa(sql_nd);
                

                dgvNV.DataSource = TruyXuatCSDL.GetTable("SELECT * FROM NhanVien");

                MessageBox.Show("Xóa thông tin nhân viên thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Xóa thất bại! " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // tìm kiếm thông tin độc giả
        private void NhapTTTim()
        {
            if (rdMaNV.Checked)
            {
                dgvNV.DataSource = TruyXuatCSDL.GetTable("select * from NhanVien where MaNhanVien like '%" + txtTKNV.Text + "%'");
            }
            else if (rdTenNV.Checked)
            {
                dgvNV.DataSource = TruyXuatCSDL.GetTable("select * from NhanVien where TenDangNhap like '%" + txtTKNV.Text + "%'");
            }
        }
        private void btnTKNV_Click(object sender, EventArgs e)
        {
            NhapTTTim();
        }

        private void txtTKNV_TextChanged(object sender, EventArgs e)
        {
            NhapTTTim();
        }
    }
}

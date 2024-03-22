using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _1_BTHuyenTrang_VTAnhTrinh_NVThanh_LDThanh_LTNET
{
    public partial class frmQlyDocGia : Form
    {
        public frmQlyDocGia()
        {
            InitializeComponent();
        }


        // Sử dụng hàm này để gán danh sách MaNhanVien vào ComboBox
        public void NapDuLieuVaoComboBox()
        {
            List<string> danhSachMaNhanVien = TruyXuatCSDL.LayDanhSachMaNhanVien();

            // Gán danh sách MaNhanVien vào ComboBox
            cbmanvtaothe.DataSource = danhSachMaNhanVien;
        }
        private void frmQlyDocGia_Load(object sender, EventArgs e)
        {
            dgvDG.DataSource = TruyXuatCSDL.GetTable("select * from DocGia");
            dgvDG.Columns[0].HeaderText = "Mã độc giả";
            dgvDG.Columns[1].HeaderText = "Tên độc giả";
            dgvDG.Columns[2].HeaderText = "Ngày sinh";
            dgvDG.Columns[3].HeaderText = "Giới tính";
            dgvDG.Columns[4].HeaderText = "Địa chỉ";
            dgvDG.Columns[5].HeaderText = "Lớp học";
            dgvDG.Columns[6].HeaderText = "Ngày tạo thẻ";
            dgvDG.Columns[7].HeaderText = "Mã nhân viên tạo thẻ";
            dgvDG.Columns[8].HeaderText = "Tên đăng nhập";

            dgvDG.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDG.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDG.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDG.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDG.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDG.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDG.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDG.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDG.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NapDuLieuVaoComboBox();


        }
        // Thiết lập Controls
        private void setControls(bool edit)
        {
            txtMaDG.Enabled = edit;
            txtTenDG.Enabled = edit;
            dtNgaySinh.Enabled = edit;
            cbGioiTinh.Enabled = edit;
            txtDiaChi.Enabled = edit;
            txtLopHoc.Enabled = edit;
            dtNgayTao.Enabled = edit;
            txtTenDN.Enabled = edit;
            cbmanvtaothe.Enabled = edit;
        }

        //Phương thức thêm độc giả
        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;

        }

        public void themDG()
        {
            try
            {
                string sql = "update DOCGIA set MaDocGia = N'" +
                txtMaDG.Text + "', TenDocGia=N'" +
                txtTenDG.Text + "', NgaySinh = '" +
                dtNgaySinh.Value.ToString("yyyy-MM-dd") + "', GioiTinh=N'" +
                cbGioiTinh.Text + "', DiaChi = N'" +
                txtDiaChi.Text + "', LopHoc = N'" +
                txtLopHoc.Text + "', NgayTaoThe='" +
                dtNgayTao.Value.ToString("yyyy-MM-dd") + "', MaNhanVienTaoThe=N'" +
                cbmanvtaothe.Text + "' where TenDangNhap = N'" + txtTenDN.Text + "'";
                TruyXuatCSDL.ThemSuaXoa(sql);
                MessageBox.Show("Kích hoạt thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            if (txtMaDG.Text.Length > 0 && txtTenDG.Text.Length > 0 && dtNgaySinh.Text.Length > 0 && cbGioiTinh.Text.Length > 0 &&
                txtDiaChi.Text.Length > 0 && txtLopHoc.Text.Length > 0 && dtNgayTao.Text.Length > 0 && cbmanvtaothe.Text.Length > 0
                && txtMaDG.Text.Length > 0)
            {
                themDG();
                dgvDG.DataSource = TruyXuatCSDL.GetTable("select * from DOCGIA");

                btnLuu.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                setControls(false);

            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo");
            }



        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM DOCGIA WHERE MaDocGia = N'" + txtMaDG.Text + "'";                  
                    string sql_nd = "DELETE FROM NGUOIDUNG WHERE TenDangNhap =N'" + txtTenDN.Text + "'";
                    TruyXuatCSDL.ThemSuaXoa(sql);
                    TruyXuatCSDL.ThemSuaXoa(sql_nd);                 
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại.\nĐộc Giả này đang mượn sách.", "Thông Báo");
                }
                dgvDG.DataSource = TruyXuatCSDL.GetTable("select * from DOCGIA");
            }
        }



        private void dgvDG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDG.CurrentRow != null)
            {
                txtMaDG.Text = dgvDG.CurrentRow.Cells[0].Value.ToString();
                txtTenDG.Text = dgvDG.CurrentRow.Cells[1].Value.ToString();
                dtNgaySinh.Text = dgvDG.CurrentRow.Cells[2].Value.ToString();
                cbGioiTinh.Text = dgvDG.CurrentRow.Cells[3].Value.ToString();
                txtDiaChi.Text = dgvDG.CurrentRow.Cells[4].Value.ToString();
                txtLopHoc.Text = dgvDG.CurrentRow.Cells[5].Value.ToString();
                dtNgayTao.Text = dgvDG.CurrentRow.Cells[6].Value.ToString();
                cbmanvtaothe.Text = dgvDG.CurrentRow.Cells[7].Value.ToString();
                txtTenDN.Text = dgvDG.CurrentRow.Cells[8].Value.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // tìm kiếm thông tin độc giả
        private void NhapTTTim()
        {
            if (rdMaDG.Checked)
            {
                dgvDG.DataSource = TruyXuatCSDL.GetTable("select * from DOCGIA where MaDocGia like '%" + txtTKDG.Text + "%'");
            }
            else if (rdTenDG.Checked)
            {
                dgvDG.DataSource = TruyXuatCSDL.GetTable("select * from DOCGIA where TenDangNhap like '%" + txtTKDG.Text + "%'");
            }
        }

        private void btnTKDG_Click(object sender, EventArgs e)
        {
            NhapTTTim();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dgvDG.DataSource = TruyXuatCSDL.GetTable("select * from DOCGIA");
        }
    }
}

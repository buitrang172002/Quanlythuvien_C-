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
    public partial class frmQlySach : Form
    {
        public frmQlySach()
        {
            InitializeComponent();
        }

        private void frmQlySach_Load(object sender, EventArgs e)
        {
            dgvSach.DataSource = TruyXuatCSDL.GetTable("select * from SACH");
            dgvSach.Columns[0].HeaderText = "Mã sách";
            dgvSach.Columns[1].HeaderText = "Tên sách";
            dgvSach.Columns[2].HeaderText = "Loại sách";
            dgvSach.Columns[3].HeaderText = "Mã tác giả";
            dgvSach.Columns[4].HeaderText = "Mã nhà xuất bản";
            dgvSach.Columns[5].HeaderText = "Ngày xuất bản";
            dgvSach.Columns[6].HeaderText = "Số lượng";

            dgvSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSach.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSach.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSach.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvSach.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void setControls(bool edit)
        {
            txtMaSach.Enabled = edit;
            txtTenSach.Enabled = edit;
            txtLoaiSach.Enabled = edit;
            txtMaTG.Enabled = edit;
            txtMaNXB.Enabled = edit;
            dtNgayXB.Enabled = edit;
            txtSlg.Enabled = edit;
        }
         private void Nhapthongtin() 
        {
            if (rdMaSach.Checked)
            {
                dgvSach.DataSource = TruyXuatCSDL.GetTable("select * from sach where MaSach like '%" + txtTKSach.Text + "%'");
            }
            else if (rdTenSach.Checked)
            {
                dgvSach.DataSource = TruyXuatCSDL.GetTable("select * from sach where TenSach like '%" + txtTKSach.Text + "%'");
            }
            else if (rdLoaiSach.Checked)
            {
               dgvSach.DataSource = TruyXuatCSDL.GetTable("select * from sach where LoaiSach like '%" + txtTKSach.Text + "%'");
            }
           
        }
        public void Xoasach()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM sach WHERE MaSach = N'" + txtMaSach.Text + "'";
                    TruyXuatCSDL.ThemSuaXoa(sql);
                    dgvSach.DataSource = TruyXuatCSDL.GetTable("select * from sach");
                    MessageBox.Show("Xóa thành công.", "Thông Báo");
                }
                catch
                {
                    MessageBox.Show("Xóa thất bại", "Thông Báo");
                }
            }

        }
        public void Them()
        {
            if (TruyXuatCSDL.KiemTraSach(txtMaSach.Text))
            {
                MessageBox.Show("Mã sách đã tồn tại.\nVui lòng chọn mã sách khác.");
                return; // Dừng việc thêm hoặc cập nhật khi mã nhân viên bị trùng
            }
            try
            {
                string sql = "insert into sach values(N'" + txtMaSach.Text + "', N'"
                      + txtTenSach.Text + "', N'" + txtLoaiSach.Text + "', N'"
                      + txtMaTG.Text + "', N'" + txtMaNXB.Text + "', N'"
                      + dtNgayXB.Value.ToString("yyyy-MM-dd") + "', '" + txtSlg.Text + "')";

                TruyXuatCSDL.ThemSuaXoa(sql);
                dgvSach.DataSource = TruyXuatCSDL.GetTable("select * from sach");
                MessageBox.Show("Thêm thành công.", "Thông Báo");

            }
            catch (Exception)
            {
                MessageBox.Show("Thêm thất bại!.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Sua()
        {
            try
            {
                string sql = "update sach set TenSach=N'" + txtTenSach.Text + "',LoaiSach=N'" + txtLoaiSach.Text + "',MaTacGia=N'" + txtMaTG.Text + "',MaNhaXuatBan=N'" + txtMaNXB.Text + "',NgayXuatBan=N'" + dtNgayXB.Value.ToString("yyyy-MM-dd") + "',SoLuong='" + txtSlg.Text + "' where MaSach='" + txtMaSach.Text + "'";
                TruyXuatCSDL.ThemSuaXoa(sql);
                MessageBox.Show("Sửa thành công.", "Thông Báo");
            }
            catch
            {
                MessageBox.Show("Sửa thất bại.\nVui lòng kiểm tra lại dữ liệu.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int xuly;
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            
            btnLuu.Enabled = true;
           
            xuly = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            int ktsoluong;
            bool isNumberSLNhap = int.TryParse(txtSlg.Text, out ktsoluong);
            if (isNumberSLNhap == false)
            {
                MessageBox.Show("Vui lòng nhập số trong ô số lượng.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtMaSach.Text.Length>0 && txtTenSach.Text.Length>0 && txtLoaiSach.Text.Length>0&& txtMaTG.Text.Length>0 && txtMaNXB.Text.Length>0 && dtNgayXB.Text.Length>0 && isNumberSLNhap == true)
            {
                if (xuly == 0)
                {
                    Them();
                }
                else if (xuly == 1)
                {
                    Sua();

                }
                dgvSach.DataSource = TruyXuatCSDL.GetTable("select * from sach");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;

            xuly = 1;
        }

        private void txtTKSach_TextChanged(object sender, EventArgs e)
        {
            Nhapthongtin();
        }

        private void btnTKSach_Click(object sender, EventArgs e)
        {
            Nhapthongtin();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoasach();
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dgvSach.DataSource = TruyXuatCSDL.GetTable("select * from SACH");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvSach.CurrentRow != null)
            {
                txtMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
                txtTenSach.Text =dgvSach.CurrentRow.Cells[1].Value.ToString();
                txtLoaiSach.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
                txtMaTG.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
                txtMaNXB.Text = dgvSach.CurrentRow.Cells[4].Value.ToString();
                dtNgayXB.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
                txtSlg.Text = dgvSach.CurrentRow.Cells[6].Value.ToString();
            }
        }
    }
}

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
    public partial class frmPhieuMuon : Form
    {
        public frmPhieuMuon()
        {
            InitializeComponent();
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            dgvPM.DataSource = TruyXuatCSDL.GetTable("select * from PHIEUMUON");
            dgvPM.Columns[0].HeaderText = "Mã phiếu mượn";
            dgvPM.Columns[1].HeaderText = "Mã nhân viên lập phiếu";
            dgvPM.Columns[2].HeaderText = "Ngày lập";
            dgvPM.Columns[3].HeaderText = "Mã độc giả";
            

            dgvPM.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPM.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvPM.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;          
            dgvPM.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Nhapthongtin()
        {
            if (rdMaPhieuMuon.Checked)
            {
                dgvPM.DataSource = TruyXuatCSDL.GetTable("select * from phieumuon where MaPhieuMuon like '%" + txtTKPM.Text + "%'");
            }
            else if (rdMaDG.Checked)
            {
                dgvPM.DataSource = TruyXuatCSDL.GetTable("select * from phieumuon where MaDocGia like '%" + txtTKPM.Text + "%'");
            }
        
        }

        private void txtTKPM_TextChanged(object sender, EventArgs e)
        {
            Nhapthongtin();
        }

        private void btnTKPM_Click(object sender, EventArgs e)
        {
            Nhapthongtin();
        }
        public void XoaPM()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM phieumuon WHERE MaPhieuMuon = N'" + txtMaPM.Text + "'";
                    TruyXuatCSDL.ThemSuaXoa(sql);
                    dgvPM.DataSource = TruyXuatCSDL.GetTable("select * from PhieuMuon");
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
            if (TruyXuatCSDL.KiemTraPM(txtMaPM.Text))
            {
                MessageBox.Show("Mã phiếu mượn đã tồn tại.\nVui lòng chọn mã phiếu mượn khác.");
                return; // Dừng việc thêm hoặc cập nhật khi mã nhân viên bị trùng
            }
            try
            {
                string sql = "insert into phieumuon values(N'" + txtMaPM.Text + "', N'"
                      + txtMaNV.Text + "', N'" 
                      + dtNgayLapPhieu.Value.ToString("yyyy-MM-dd") + "',N'" + txtMaDG.Text + "')";

                TruyXuatCSDL.ThemSuaXoa(sql);
                dgvPM.DataSource = TruyXuatCSDL.GetTable("select * from phieumuon");
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
                string sql = "update phieumuon set MaNhanVienLapPhieu=N'" + txtMaNV.Text +"',NgayLap=N'" + dtNgayLapPhieu.Value.ToString("yyyy-MM-dd") + "',MaDocGia=N'" + txtMaDG.Text + "' where MaPhieuMuon='" + txtMaPM.Text + "'";
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
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;

            xuly = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
           
            if (txtMaPM.Text.Length >0 && txtMaNV.Text.Length>0 && dtNgayLapPhieu.Text.Length>0 && txtMaDG.Text.Length>0)
            {
                if (xuly == 0)
                {
                    Them();
                }
                else if (xuly == 1)
                {
                    Sua();

                }
                dgvPM.DataSource = TruyXuatCSDL.GetTable("select * from phieumuon");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Thông Báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;

            btnLuu.Enabled = true;

            xuly = 1;
        }

        private void dgvPM_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPM.CurrentRow != null)
            {
                txtMaPM.Text = dgvPM.CurrentRow.Cells[0].Value.ToString();
                txtMaNV.Text = dgvPM.CurrentRow.Cells[1].Value.ToString();
                dtNgayLapPhieu.Text = dgvPM.CurrentRow.Cells[2].Value.ToString();                          
                txtMaDG.Text = dgvPM.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            XoaPM();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

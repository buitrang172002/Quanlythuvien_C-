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
    public partial class frmChiTietPM : Form
    {
        public frmChiTietPM()
        {
            InitializeComponent();
        }

        private void frmChiTietPM_Load(object sender, EventArgs e)
        {
           dgvChiTietPM.DataSource = TruyXuatCSDL.GetTable("select * from chitietphieumuon");
           dgvChiTietPM.Columns[0].HeaderText = "Mã phiếu mượn";
           dgvChiTietPM.Columns[1].HeaderText = "Mã sách";
           dgvChiTietPM.Columns[2].HeaderText = "Tình trạng";
           dgvChiTietPM.Columns[3].HeaderText = "Ngày trả sách";
           dgvChiTietPM.Columns[4].HeaderText = "Tiền phạt";
           dgvChiTietPM.Columns[5].HeaderText = "Mã nhân viên nhận sách trả";
          

            dgvChiTietPM.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvChiTietPM.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvChiTietPM.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvChiTietPM.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvChiTietPM.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;         
            dgvChiTietPM.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Nhapthongtin()
        {
            if (rdMaPhieuMuon.Checked)
            {
                dgvChiTietPM.DataSource = TruyXuatCSDL.GetTable("select * from chitietphieumuon where MaPhieuMuon like '%" + txtTKPM.Text + "%'");
            }
            else if (rdMaSach.Checked)
            {
                dgvChiTietPM.DataSource = TruyXuatCSDL.GetTable("select * from chitietphieumuon where MaSach like '%" + txtTKPM.Text + "%'");
            }
            else if (rdMaNV.Checked)
            {
                dgvChiTietPM.DataSource = TruyXuatCSDL.GetTable("select * from chitietphieumuon where MaNhanVienNhanSachTra like '%" + txtTKPM.Text + "%'");
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
        public void Xoa()
        {
            DialogResult dlr;
            dlr = MessageBox.Show("Bạn chắc chắn muốn xóa.", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM chitietphieumuon WHERE MaPhieuMuon = N'" + txtMaPM.Text + "'";
                    TruyXuatCSDL.ThemSuaXoa(sql);
                    dgvChiTietPM.DataSource = TruyXuatCSDL.GetTable("select * from chitietphieumuon");
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
            try
            {
                string sqlGetMaDocGia = "SELECT COUNT(*) MaDocGia FROM PhieuMuon WHERE MaPhieuMuon = '" + txtMaPM.Text + "'";
                int count = TruyXuatCSDL.LayMotGiaTriDem(sqlGetMaDocGia);


                //string sqlCount = "SELECT COUNT(*) FROM chitietphieumuon WHERE MaDocGia = '" + maDocGia + "'";
                //int count = TruyXuatCSDL.LayMotGiaTriDem(sqlCount);

                if (count > 5)
                {
                    MessageBox.Show("Bạn đã mượn quá số sách cho phép.");
                    return;
                }

                if (!TruyXuatCSDL.KiemTraSach(txtMaSach.Text))
                {
                    MessageBox.Show("Mã sách không tồn tại.\nVui lòng kiểm tra lại.");
                    return;
                }

                string sqlInsert = "INSERT INTO chitietphieumuon VALUES(N'" + txtMaPM.Text + "', N'"
                                    + txtMaSach.Text + "', N'" + txtTinhTrang.Text + "', N'"
                                    + " " + "', '" + txtTienPhat.Text
                                    + "',N'" + txtMaNV.Text + "')";

                TruyXuatCSDL.ThemSuaXoa(sqlInsert);

                string sqlUpdateSoLuong = "UPDATE Sach SET SoLuong = SoLuong - 1 WHERE MaSach = '" + txtMaSach.Text + "'";
                TruyXuatCSDL.ThemSuaXoa(sqlUpdateSoLuong);

                dgvChiTietPM.DataSource = TruyXuatCSDL.GetTable("SELECT * FROM chitietphieumuon");
                MessageBox.Show("Thêm thành công.", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Thêm thất bại! " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Sua()
        {
            try
            {
                string sqlUpdate = "UPDATE chitietphieumuon SET MaSach = N'" + txtMaSach.Text +
                                    "', TinhTrang = '" + txtTinhTrang.Text +
                                    "', NgayTraSach = N'" + dtNgayLapPhieu.Value.ToString("yyyy-MM-dd") +
                                    "', MaNhanVienNhanSachTra = N'" + txtMaNV.Text +
                                    "' WHERE MaPhieuMuon = N'" + txtMaPM.Text + "'";

                if (txtTinhTrang.Text == "True")
                {
                    string sqlPhieuMuon = "SELECT NgayLap FROM PHIEUMUON WHERE MaPhieuMuon = '" + txtMaPM.Text + "'";
                    DataTable tableNgayLap = TruyXuatCSDL.GetTable(sqlPhieuMuon);

                    DateTime ngayLap = DateTime.MinValue; // Giá trị mặc định

                    if (tableNgayLap != null && tableNgayLap.Rows.Count > 0)
                    {
                        // Giả sử cột NgayLap có chỉ một giá trị trong kết quả trả về
                        ngayLap = Convert.ToDateTime(tableNgayLap.Rows[0]["NgayLap"]);
                    }


                    DateTime ngayTraSach = dtNgayLapPhieu.Value;

                    TimeSpan timeSpan =  ngayTraSach - ngayLap;
                    int soNgayTre = timeSpan.Days;

                    double tienPhat = (soNgayTre > 30) ? soNgayTre * 2000 : 0;

                    string sqlUpdateTienPhat = "UPDATE chitietphieumuon SET TienPhat = '" + tienPhat.ToString() +
                                                "' WHERE MaPhieuMuon = N'" + txtMaPM.Text + "'";
                    TruyXuatCSDL.ThemSuaXoa(sqlUpdateTienPhat);

                    string sqlUpdateSoLuong = "UPDATE Sach SET SoLuong = SoLuong + 1 WHERE MaSach = '" + txtMaSach.Text + "'";
                    TruyXuatCSDL.ThemSuaXoa(sqlUpdateSoLuong);
                }

                TruyXuatCSDL.ThemSuaXoa(sqlUpdate);
                MessageBox.Show("Sửa thành công.", "Thông Báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sửa thất bại. " + ex.Message, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }






        public int xuly;

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuly = 0;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuly = 1;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            
                if (xuly == 0)
                {
                    Them();
                }
                else if (xuly == 1)
                {
                    Sua();

                }
                dgvChiTietPM.DataSource = TruyXuatCSDL.GetTable("select * from chitietphieumuon");
            
           
        }

        private void dgvChiTietPM_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvChiTietPM.CurrentRow != null)
            {
                txtMaPM.Text = dgvChiTietPM.CurrentRow.Cells[0].Value.ToString();
                txtMaSach.Text = dgvChiTietPM.CurrentRow.Cells[1].Value.ToString();
                txtTinhTrang.Text =dgvChiTietPM.CurrentRow.Cells[2].Value.ToString();
                dtNgayLapPhieu.Text = dgvChiTietPM.CurrentRow.Cells[3].Value.ToString();
                txtTienPhat.Text = dgvChiTietPM.CurrentRow.Cells[4].Value.ToString();
                txtMaNV.Text = dgvChiTietPM.CurrentRow.Cells[5].Value.ToString();
                
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Xoa();
        }
    }
}

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
    public partial class frmTacGia : Form
    {
        public frmTacGia()
        {
            InitializeComponent();
        }

        private void frmTacGia_Load(object sender, EventArgs e)
        {
            dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select* from TACGIA");
            dgvTacGia.Columns[0].HeaderText = "Mã tác giả";
            dgvTacGia.Columns[1].HeaderText = "Tên tác giả";

            dgvTacGia.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvTacGia.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setControls(bool edit)
        {
            txtMaTG.Enabled = edit;
            txtTenTG.Enabled = edit;
        }
            private void btnThem_Click(object sender, EventArgs e)
        {
            if (TruyXuatCSDL.KiemTraTacGia(txtMaTG.Text))
            {
                MessageBox.Show("Mã tác giả đã tồn tại.\nVui lòng chọn mã tác giả khác.");
                return; // Dừng việc thêm hoặc cập nhật khi mã nhân viên bị trùng
            }
            try
            {
                string sql = "insert into TACGIA values (N'" +
                    txtMaTG.Text + "', N'" +
                    txtTenTG.Text + "')";
                TruyXuatCSDL.ThemSuaXoa(sql);
                dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select* from TACGIA");
                MessageBox.Show("Thêm tác giả thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvTacGia_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvTacGia.CurrentRow != null)
            {
                txtMaTG.Text = dgvTacGia.CurrentRow.Cells[0].Value.ToString();
                txtTenTG.Text = dgvTacGia.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update TACGIA set TenTacGia=N'" +
                    txtTenTG.Text + "' where MaTacGia=N'" +
                    txtMaTG.Text + "'";
                TruyXuatCSDL.ThemSuaXoa(sql);
                dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA");
                MessageBox.Show("Sửa tác giả thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa tác giả thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from TACGIA where MaTacGia=N'" +
                    txtMaTG.Text + "'";
                TruyXuatCSDL.ThemSuaXoa(sql);
                dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA");
                MessageBox.Show("Đã xóa tác giả!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
           
        }

        private void btnTKTG_Click(object sender, EventArgs e)
        {
            if (rdMaTG.Checked)
            {
                dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA where MaTacGia like'%" + txtTKTG.Text + "%'");
            }else if (rdTenTG.Checked)
            {
                dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA where TenTacGia like'%" + txtTKTG.Text + "%'");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lưu thông tin thanh công!", "Thông báo");

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA");
        }

        private void txtTKTG_TextChanged(object sender, EventArgs e)
        {
            if (rdMaTG.Checked)
            {
                dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA where MaTacGia like'%" + txtTKTG.Text + "%'");
            }
            else if (rdTenTG.Checked)
            {
                dgvTacGia.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA where TenTacGia like'%" + txtTKTG.Text + "%'");
            }
        }
    }
}

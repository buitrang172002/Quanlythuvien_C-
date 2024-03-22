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
    public partial class frmNXB : Form
    {
        public frmNXB()
        {
            InitializeComponent();
        }

        private void frmNXB_Load(object sender, EventArgs e)
        {
            dgvNXB.DataSource = TruyXuatCSDL.GetTable("select* from NHAXUATBAN");
            dgvNXB.Columns[0].HeaderText = "Nhà xuất bản";
            dgvNXB.Columns[1].HeaderText = "Nhà xuất bản";

            dgvNXB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvNXB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void setControls(bool edit)
        {
            txtMaNXB.Enabled = edit;
            txtTenNXB.Enabled = edit;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            setControls(true);
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnXoa.Enabled = true;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into NHAXUATBAN values (N'" +
                    txtMaNXB.Text + "', N'" +
                    txtTenNXB.Text + "')";
                TruyXuatCSDL.ThemSuaXoa(sql);
                dgvNXB.DataSource = TruyXuatCSDL.GetTable("select* from NHAXUATBAN");
                MessageBox.Show("Thêm nhà xuất bản thành công", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Thêm thất bại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "update NHAXUATBAN set TenNhaXuatBan=N'" +
                    txtTenNXB.Text + "' where MaNhaXuatBan=N'" +
                    txtMaNXB.Text + "'";
                TruyXuatCSDL.ThemSuaXoa(sql);
                dgvNXB.DataSource = TruyXuatCSDL.GetTable("select * from NHAXUATBAN");
                MessageBox.Show("Sửa nhà xuất bản thành công!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Sửa nhà xuất bản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "delete from NHAXUATBAN where MaNhaXuatBan=N'" +
                    txtMaNXB.Text + "'";
                TruyXuatCSDL.ThemSuaXoa(sql);
                dgvNXB.DataSource = TruyXuatCSDL.GetTable("select * from NHAXUATBAN");
                MessageBox.Show("Đã xóa nhà xuất bản!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnload_Click(object sender, EventArgs e)
        {
            dgvNXB.DataSource = TruyXuatCSDL.GetTable("select * from NHAXUATBAN");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTKNXB_Click(object sender, EventArgs e)
        {
            if (rdMaNXB.Checked)
            {
                dgvNXB.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA where MaNhaXuatBan like'%" + txtTKNXB.Text + "%'");
            }
            else if (rdTenNXB.Checked)
            {
                dgvNXB.DataSource = TruyXuatCSDL.GetTable("select * from TACGIA where TenNhaXuatBan like'%" + txtTKNXB.Text + "%'");
            }
        }

        private void dgvNXB_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNXB.CurrentRow != null)
            {
                txtMaNXB.Text = dgvNXB.CurrentRow.Cells[0].Value.ToString();
                txtTenNXB.Text = dgvNXB.CurrentRow.Cells[1].Value.ToString();
            }
        }
    }
}

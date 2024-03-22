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
    public partial class frmDGMuon : Form
    {
        public frmDGMuon()
        {
            InitializeComponent();
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
        private void frmDGMuon_Load(object sender, EventArgs e)
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

        private void dgvSach_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSach.CurrentRow != null)
            {
                txtMaSach.Text = dgvSach.CurrentRow.Cells[0].Value.ToString();
                txtTenSach.Text = dgvSach.CurrentRow.Cells[1].Value.ToString();
                txtLoaiSach.Text = dgvSach.CurrentRow.Cells[2].Value.ToString();
                txtMaTG.Text = dgvSach.CurrentRow.Cells[3].Value.ToString();
                txtMaNXB.Text = dgvSach.CurrentRow.Cells[4].Value.ToString();
                dtNgayXB.Text = dgvSach.CurrentRow.Cells[5].Value.ToString();
                txtSlg.Text = dgvSach.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void txtTKSach_TextChanged(object sender, EventArgs e)
        {
            Nhapthongtin();
        }

        private void btnTKSach_Click(object sender, EventArgs e)
        {
            Nhapthongtin();
        }

        private void rdLoaiSach_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdTenSach_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

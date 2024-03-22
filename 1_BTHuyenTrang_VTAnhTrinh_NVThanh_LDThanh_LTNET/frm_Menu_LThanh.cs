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
    public partial class frm_Menu_LThanh : Form
    {
        public frm_Menu_LThanh()
        {
            InitializeComponent();
        }

        private void btnQlyNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có phải là quản lý của thư viện?"
                , "Thoát"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                MessageBox.Show("Bạn không có quyền quản lý nhân viện!");
                btnQlyNV.Enabled = false;
            }
            else
            {
                MessageBox.Show("Xin mời tiếp tục!");
                this.Hide();
                frmNhanVien frm = new frmNhanVien();
                frm.ShowDialog();
                this.Show();

            }

        }

        private void frm_Menu_LThanh_Load(object sender, EventArgs e)
        {
          
                      
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQlSach_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQlySach frm = new frmQlySach();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQlyDG_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQlyDocGia frm = new frmQlyDocGia();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQlyMT_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmChiTietPM frm = new frmChiTietPM();
            frm.ShowDialog();
            this.Show();

        }

        private void btnQlyPM_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPhieuMuon frm = new frmPhieuMuon();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQlyTG_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTacGia frm = new frmTacGia();
            frm.ShowDialog();
            this.Show();
        }

        private void btnQlyNXB_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNXB frm = new frmNXB();
            frm.ShowDialog();
            this.Show();
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBaoCaoSach frm = new frmBaoCaoSach();
            frm.ShowDialog();
            this.Show();
        }
    }
}

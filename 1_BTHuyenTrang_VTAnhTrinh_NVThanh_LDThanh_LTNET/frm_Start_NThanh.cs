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
    public partial class frm_Start_NThanh : Form
    {
        public frm_Start_NThanh()
        {
            InitializeComponent();
        }

        private void dangnhap()
        {
            this.Hide();
            frmDangNhap frm = new frmDangNhap();
            frm.ShowDialog();
            this.Show();
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            dangnhap();
        }

        private void btnThuThu_Click(object sender, EventArgs e)
        {
            dangnhap();

        }

        private void btnDocgia_Click(object sender, EventArgs e)
        {
            dangnhap();
        }
    }
}

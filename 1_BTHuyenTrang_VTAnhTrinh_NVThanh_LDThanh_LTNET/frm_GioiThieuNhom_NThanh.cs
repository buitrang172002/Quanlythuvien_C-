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
    public partial class frm_GioiThieuNhom_NThanh : Form
    {
        public frm_GioiThieuNhom_NThanh()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Start_NThanh bdau = new frm_Start_NThanh();
            bdau.ShowDialog();
            this.Show();
        }
    }
}

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
    public partial class frmDSMuonSachNV : Form
    {
        public frmDSMuonSachNV()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvDSNV.DataSource = TruyXuatCSDL.GetTable("SELECT MaNhanVienLapPhieu, COUNT(*) AS SoLuongXuat FROM PHIEUMUON WHERE MaNhanVienLapPhieu = N'" + txtmaNV.Text + "' AND NgayLap = N'" + dtNgayTao.Value.ToString("yyyy-MM-dd") + "'");

            dgvDSNV.Columns[0].HeaderText = "Mã nhân viên";
            dgvDSNV.Columns[1].HeaderText = "Số lượng sách cho mượn trong một ngày";


            dgvDSNV.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvDSNV.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

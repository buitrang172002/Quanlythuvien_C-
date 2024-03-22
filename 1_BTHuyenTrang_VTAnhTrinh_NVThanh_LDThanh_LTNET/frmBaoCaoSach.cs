using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;

namespace _1_BTHuyenTrang_VTAnhTrinh_NVThanh_LDThanh_LTNET
{
    public partial class frmBaoCaoSach : Form
    {
        public frmBaoCaoSach()
        {
            InitializeComponent();
        }

        private void sáchCủaNhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSachNXB frm = new frmSachNXB();
            frm.ShowDialog();
            this.Show();
        }

        private void sáchĐộcGiảMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSachDGMuon frm = new frmSachDGMuon();
            frm.ShowDialog();
            this.Show();
        }

        private void sáchĐộcGiảTrảQuáHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSachDGMuonQuaHan frm = new frmSachDGMuonQuaHan();
            frm.ShowDialog();
            this.Show();
        }

        private void danhSáchChoMượnSáchCủaNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDSMuonSachNV frm = new frmDSMuonSachNV();
            frm.ShowDialog();
            this.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExportExcel(string path)
        {
            //khởi tạo Excel
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            // tạo côt
            for (int i = 0; i < dgvDanhSach.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvDanhSach.Columns[i].HeaderText;
            }

            // chạy dòng
            for (int i = 0; i < dgvDanhSach.Rows.Count; i++)
                for (int j = 0; j < dgvDanhSach.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvDanhSach.Rows[i].Cells[j].Value;
                }

            application.Columns.AutoFit(); // rõ từng dòng
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Sach excel";
            // dduoi file
            savefile.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(savefile.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!" + ex.Message);
                }
            }

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvDanhSach.DataSource = TruyXuatCSDL.GetTable("select * from SACH");
            dgvDanhSach.Columns[0].HeaderText = "Mã sách";
            dgvDanhSach.Columns[1].HeaderText = "Tên sách";
            dgvDanhSach.Columns[2].HeaderText = "Loại sách";
            dgvDanhSach.Columns[3].HeaderText = "Mã tác giả";
            dgvDanhSach.Columns[4].HeaderText = "Mã nhà xuất bản";
            dgvDanhSach.Columns[5].HeaderText = "Ngày xuất bản";
            dgvDanhSach.Columns[6].HeaderText = "Số lượng";
          
            dgvDanhSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDanhSach.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDanhSach.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDanhSach.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDanhSach.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDanhSach.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvDanhSach.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcel_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Sach excel";
            // dduoi file
            savefile.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportExcel(savefile.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!" + ex.Message);
                }
            }
        }
    }
}

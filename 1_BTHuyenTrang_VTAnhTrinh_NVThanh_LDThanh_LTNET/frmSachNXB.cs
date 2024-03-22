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
    public partial class frmSachNXB : Form
    {
        public frmSachNXB()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            dgvSachNXB.DataSource = TruyXuatCSDL.GetTable("SELECT MaSach, TenSach FROM Sach WHERE MaNhaXuatBan = N'" + txtmaNXB.Text + "'");

            dgvSachNXB.Columns[0].HeaderText = "Mã sách";
            dgvSachNXB.Columns[1].HeaderText = "Tên sách";
            
            
            dgvSachNXB.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
           
            dgvSachNXB.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ExportExcel(string path)
        {
            //khởi tạo Excel
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);

            // tạo côt
            for (int i = 0; i < dgvSachNXB.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dgvSachNXB.Columns[i].HeaderText;
            }

            // chạy dòng
            for (int i = 0; i < dgvSachNXB.Rows.Count; i++)
                for (int j = 0; j < dgvSachNXB.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dgvSachNXB.Rows[i].Cells[j].Value;
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
            if (savefile.ShowDialog()== DialogResult.OK){
                try
                {
                    ExportExcel(savefile.FileName);
                    MessageBox.Show("Xuất file thành công!");
                }catch(Exception ex)
                {
                    MessageBox.Show("Xuất file không thành công!"+ex.Message);
                }
            }
           
        }

        private void frmSachNXB_Load(object sender, EventArgs e)
        {

        }
    }
}

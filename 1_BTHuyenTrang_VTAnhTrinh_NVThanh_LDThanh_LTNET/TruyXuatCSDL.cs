using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_BTHuyenTrang_VTAnhTrinh_NVThanh_LDThanh_LTNET
{
    class TruyXuatCSDL
    {
        private static string DuongDan = @"Data Source=DESKTOP-A2J7GB9\SQLEXPRESS;Initial Catalog=QuanLyThuVien;Integrated Security=True";
        // phương thức tạo kết nối
        private static SqlConnection TaoKetNoi()
        {
            // tạo đường đi 
            return new SqlConnection(DuongDan);
        }
        //Phương thức lấy ra một bảng
        public static DataTable GetTable(string sql)
        {
            SqlConnection DuongOng = TaoKetNoi();
            DuongOng.Open();
            SqlDataAdapter MayBom = new SqlDataAdapter(sql, DuongOng);
            DataTable ThungChua = new DataTable();
            MayBom.Fill(ThungChua);
            DuongOng.Close();
            MayBom.Dispose();
            return ThungChua;
        }
        // Phương thức lấy ra một dữ liệu dành cho tbTaiKhoan 
        public static string LayMotGiaTri(string sql)
        {
            SqlConnection KetNoi = TaoKetNoi();
            KetNoi.Open();
            SqlCommand lenh = new SqlCommand(sql, KetNoi);
            object KetQua = lenh.ExecuteScalar();
            if (KetQua == null)
            {
                return " ";
            }
            else
            {
                return KetQua.ToString();
            }
            KetNoi.Close();
            lenh.Dispose();
        }
        // Phương thức lấy ra số lượng bản ghi từ truy vấn SQL
        public static int LayMotGiaTriDem(string sql)
        {
            int count = 0;
            SqlConnection KetNoi = TaoKetNoi();

            using (KetNoi)
            {
                KetNoi.Open();
                SqlCommand lenh = new SqlCommand(sql, KetNoi);
                count = (int)lenh.ExecuteScalar();
            }

            return count;
        }
        // Phương thứ lấy một giá trị cho muontra
        public static SqlDataReader LayMotGT(string sql)
        {
            SqlConnection KetNoi = TaoKetNoi();
            KetNoi.Open();
            SqlCommand lenh = new SqlCommand(sql, KetNoi);
            SqlDataReader reader = lenh.ExecuteReader(CommandBehavior.CloseConnection);
            // Không đóng kết nối tại đây
            lenh.Dispose();
            return reader;
        }
        // Phương thức thêm sửa xóa 
        public static void ThemSuaXoa(string sql)
        {
            SqlConnection KetNoi = TaoKetNoi();
            KetNoi.Open();
            SqlCommand Lenh = new SqlCommand(sql, KetNoi);
            Lenh.ExecuteNonQuery();
            KetNoi.Close();
            Lenh.Dispose();
        }
        public static List<string> LayDanhSachMaNhanVien()
        {
            List<string> danhSachMaNhanVien = new List<string>();
           
            using (SqlConnection connection = TaoKetNoi())
            {
                string query = "SELECT MaNhanVien FROM NhanVien"; // Truy vấn để lấy MaNhanVien từ bảng NhanVien

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string maNhanVien = reader["MaNhanVien"].ToString();
                    danhSachMaNhanVien.Add(maNhanVien);
                }
            }

            return danhSachMaNhanVien;
        }
        public static bool KiemTraMaNVTonTai(string maNV)
        {
            bool result = false;
            SqlConnection KetNoi = TaoKetNoi(); // Tạo kết nối đến cơ sở dữ liệu

            try
            {
                string sqlCheckMaNV = "SELECT COUNT(*) FROM NHANVIEN WHERE MaNhanVien = N'" + maNV + "'";

                KetNoi.Open();
                SqlCommand command = new SqlCommand(sqlCheckMaNV, KetNoi);
                int countMaNV = (int)command.ExecuteScalar();

                result = countMaNV > 0;
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Lỗi khi kiểm tra mã nhân viên: " + ex.Message);
            }
            finally
            {
                KetNoi.Close(); // Đóng kết nối trong finally để đảm bảo kết nối được đóng ngay cả khi có lỗi xảy ra
            }

            return result;
        }

        public static bool KiemTraTacGia(string maNV)
        {
            bool result = false;
            SqlConnection KetNoi = TaoKetNoi(); // Tạo kết nối đến cơ sở dữ liệu

            try
            {
                string sqlCheckMaNV = "SELECT COUNT(*) FROM TACGIA WHERE MaTacGia = N'" + maNV + "'";

                KetNoi.Open();
                SqlCommand command = new SqlCommand(sqlCheckMaNV, KetNoi);
                int countMaNV = (int)command.ExecuteScalar();

                result = countMaNV > 0;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Lỗi khi kiểm tra mã nhân viên: " + ex.Message);
            }
            finally
            {
                KetNoi.Close(); // Đóng kết nối trong finally để đảm bảo kết nối được đóng ngay cả khi có lỗi xảy ra
            }

            return result;
        }
        public static bool KiemTraSach(string maNV)
        {
            bool result = false;
            SqlConnection KetNoi = TaoKetNoi(); // Tạo kết nối đến cơ sở dữ liệu

            try
            {
                string sqlCheckMaNV = "SELECT COUNT(*) FROM SACH WHERE MaSach = N'" + maNV + "'";

                KetNoi.Open();
                SqlCommand command = new SqlCommand(sqlCheckMaNV, KetNoi);
                int countMaNV = (int)command.ExecuteScalar();

                result = countMaNV > 0;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Lỗi khi kiểm tra mã nhân viên: " + ex.Message);
            }
            finally
            {
                KetNoi.Close(); // Đóng kết nối trong finally để đảm bảo kết nối được đóng ngay cả khi có lỗi xảy ra
            }

            return result;
        }

        public static bool KiemTraPM(string maNV)
        {
            bool result = false;
            SqlConnection KetNoi = TaoKetNoi(); // Tạo kết nối đến cơ sở dữ liệu

            try
            {
                string sqlCheckMaNV = "SELECT COUNT(*) FROM PHIEUMUON WHERE MaPhieuMuon = N'" + maNV + "'";

                KetNoi.Open();
                SqlCommand command = new SqlCommand(sqlCheckMaNV, KetNoi);
                int countMaNV = (int)command.ExecuteScalar();

                result = countMaNV > 0;
            }
            catch (Exception ex)
            {
                // MessageBox.Show("Lỗi khi kiểm tra mã nhân viên: " + ex.Message);
            }
            finally
            {
                KetNoi.Close(); // Đóng kết nối trong finally để đảm bảo kết nối được đóng ngay cả khi có lỗi xảy ra
            }

            return result;
        }
    }
}

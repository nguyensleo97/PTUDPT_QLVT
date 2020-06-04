using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data;
using System.Data.SqlClient;

namespace QLVT
{
    static class Program
    {
        public static SqlConnection conn = new SqlConnection();
        public static SqlConnection connection;
        public static String connstr = null;
        public static SqlDataReader myReader;

        public static String servername = "";  //chua server đang làm việc
        public static String username = "";    //Để biêt ai đang sử dụng ct này
        public static String mlogin = "";      //Chứa tên đăng nhập
        public static String password = "";

        public static String database = "QLVT";
        public static String remotelogin = "HTKN";
        public static String remotepass = "123456";
        public static String mloginDN = "";
        public static String passwordDN = "";
        public static String mGroup = "";
        public static String mHoTen = "";     //Chứa tên người đăng nhập và sẽ hiển thị ở thanh trạng thái
        public static int mChiNhanh = 0;

        public static BindingSource bds_dspm = new BindingSource();  // giữ bdsPM khi đăng nhập
        public static formMain formChinh;
        public static FormDangNhap formDangNhap; 
        public static formPhieuNhap formPhieuNhap;
        public static formDatHang formDatHang;

        public static int KetNoi()
        {
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close();
            try
            {
                Program.connstr = "Data Source=" + Program.servername + ";Initial Catalog=" +
                      Program.database + ";User ID=" +
                      Program.mlogin + ";password=" + Program.password;
                Program.conn.ConnectionString = Program.connstr;
                Program.conn.Open();
                return 1;
            }

            catch (Exception e)
            {
                MessageBox.Show("Lỗi kết nối cơ sở dữ liệu.\nBạn xem lại user name và password.\n " + e.Message, "", MessageBoxButtons.OK);
                return 0;
            }
        }

        public static int getMaNV()
        {
            using (SqlConnection conn = new SqlConnection(Program.connstr))
            using (SqlCommand cmd = new SqlCommand("sp_MaNVAuto", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;
                conn.Open();
                cmd.ExecuteNonQuery();
                //MessageBox.Show(returnParameter.Value.ToString());
                return (int)returnParameter.Value;
            }
        }
        public static String getMaDH()
        {
            String lenh = "EXEC dbo.sp_MaDHAuto";
            SqlDataReader kt = Program.ExecSqlDataReader(lenh);
            if (kt == null) return "";
            kt.Read();
            String maDH = kt.GetString(0);
            kt.Close();
            //Program.conn.Close();
            return maDH;
        }
        public static String getMaPX()
        {
            String lenh = "EXEC dbo.sp_MaPXAuto";
            SqlDataReader kt = Program.ExecSqlDataReader(lenh);
            if (kt == null) return "";
            kt.Read();
            String maPX = kt.GetString(0);
            kt.Close();
            //Program.conn.Close();
            return maPX;
        }

        public static int KiemTraTonTaiTaiKhoan(string ho, string ten, string diaChi, DateTime ngaySinh)
        {
            conn.Close();
            using (SqlConnection conn = new SqlConnection(Program.connstr)) ;
            using (SqlCommand cmd = new SqlCommand("sp_TimNhanVienTheoThongTin", conn))
            {

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Ho", ho);
                cmd.Parameters.AddWithValue("Ten", ten);
                cmd.Parameters.AddWithValue("DiaChi", diaChi);
                cmd.Parameters.AddWithValue("NgaySinh", ngaySinh);
                var returnParameter = cmd.Parameters.Add("@result", SqlDbType.Int);
                returnParameter.Direction = ParameterDirection.ReturnValue;

                conn.Open();
                cmd.ExecuteNonQuery();
                return (int)returnParameter.Value;
            }
        }
        public static bool taoLogin(ThongTinLogin thongTinLogin)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connstr))
                using (SqlCommand cmd = new SqlCommand("sp_TaoTaiKhoan", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@LGNAME", thongTinLogin.LoginName));
                    cmd.Parameters.Add(new SqlParameter("@PASS", thongTinLogin.Pass));
                    cmd.Parameters.Add(new SqlParameter("@USERNAME", thongTinLogin.UserName));
                    cmd.Parameters.Add(new SqlParameter("@ROLE", thongTinLogin.Role));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Tạo login không thành công", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
        }

        public static bool chuyenNV(int maNV, int maNVMoi, int maNVTT)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(Program.connstr))
                using (SqlCommand cmd = new SqlCommand("sp_ChuyenChiNhanh", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaNV", maNV));
                    cmd.Parameters.Add(new SqlParameter("@MaNVMoi", maNVMoi));
                    cmd.Parameters.Add(new SqlParameter("@MaNVTimThay", maNVTT));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chuyển chi nhánh không thành công", "Lỗi", MessageBoxButtons.OK);
                return false;
            }
        }

        public static SqlDataReader ExecSqlDataReader(String strLenh)
        {
            SqlDataReader myreader;
            SqlCommand sqlcmd = new SqlCommand(strLenh, Program.conn);
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandTimeout = 600;
            if (Program.conn.State == ConnectionState.Closed) Program.conn.Open();
            try
            {
                myreader = sqlcmd.ExecuteReader(); return myreader;

            }
            catch (SqlException ex)
            {
                Program.conn.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
        }
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SkinManager.EnableFormSkins();
            XtraForm1 xtraForm1 = new XtraForm1();
            // formChinh = new formMain();   
            
            Application.Run(xtraForm1);
            
        }
    }
}

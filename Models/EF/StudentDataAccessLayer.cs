using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Models.EF
{
    public class StudentDataAccessLayer
    {
        string connectionString = ConnectionString.CName;

        public IEnumerable<SinhVien> GetAllStudent()
        {
            List<SinhVien> lstStudent = new List<SinhVien>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                var query = "Select * from SinhVien as SV " +
                    "join ChiTietThanhVien as CTSV on CTSV.MaSinhVien = SV.MaSinhVien" + "join LopSinhVien as LSV on CTSV.MaLSH = LSV.MaLSH";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    SinhVien student = new SinhVien();
                    student.HoTen = rdr["HoTen"].ToString();
                    student.ChiTietThanhVien.SoDienThoai = rdr["SoDienThoai"].ToString();
                    student.ChiTietThanhVien.Email = rdr["MatKhau"].ToString();

                    lstStudent.Add(student);
                }
                con.Close();
            }
            return lstStudent;
        }

        public IEnumerable<SinhVien> GetSinhVienById(string term)
        {
            List<SinhVien> lstStudent = new List<SinhVien>();
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                var query = "Select * from SinhVien as SV join ChiTietThanhVien as CTSV on CTSV.MaSinhVien = SV.MaSinhVien join LopSinhVien as LSV on LSV.MaLSH = CTSV.MaLSH " +
                    "where SV.HoTen like '%"+term+"%'";
                SqlCommand cmd = new SqlCommand(query, con);

                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    SinhVien student = new SinhVien();
                    student.MaSinhVien = rdr["MaSinhVien"].ToString();
                    student.HoTen = rdr["HoTen"].ToString();
                    student.MatKhau = rdr["MatKhau"].ToString();

                    lstStudent.Add(student);
                }
                con.Close();
                //if (lstStudent == null)
                //{
                   
                //}
            }
            return lstStudent;
        }
    }
}

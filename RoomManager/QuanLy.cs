﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Globalization;

namespace RoomManager
{
    public partial class QuanLy : Form
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);

        public class TKB 
        {
            //
            public string Phong { get; set; }
            public string Lop { get; set; }
            public string Mon { get; set; }
            public string GV { get; set; }
            public int TietBD { get; set; }
            public int TietKT { get; set; }
            public DateTime NgayMuon { get; set; }
            public string NguoiMuon { get; set; }
            public string NguoiTra { get; set; }
            public string LyDo { get; set; }

            //
            public TKB(string Phong, string Lop, string Mon, int TietBD, int TietKT, DateTime NgayMuon, string NguoiMuon, string NguoiTra, string LyDo)
            {
                if (Phong != "" 
                    && Lop != "" 
                    && Mon != "" 
                    && TietBD > 0 
                    && TietKT > TietBD 
                    && NguoiMuon != "" 
                    && NguoiTra != "")
                {
                    this.Phong = Phong;
                    this.Lop = Lop;
                    this.Mon = Mon;
                    this.TietBD = TietBD;
                    this.TietKT = TietKT;
                    this.NgayMuon = NgayMuon;
                    this.NguoiMuon = NguoiMuon;
                    this.NguoiTra = NguoiTra;
                    this.LyDo = LyDo;
                }
                else
                {
                    throw new Exception("Gặp lỗi trong việc khởi tạo đối tượng TKB");
                }
            }
            public TKB(string Phong, string Lop, string Mon, string GV, int TietBD, int TietKT, DateTime NgayMuon, string NguoiMuon, string NguoiTra, string LyDo)
            {
                if (Phong != ""
                    && Lop != ""
                    && Mon != ""
                    && TietBD > 0
                    && TietKT > TietBD
                    && NguoiMuon != ""
                    && NguoiTra != "")
                {
                    this.Phong = Phong;
                    this.Lop = Lop;
                    this.Mon = Mon;
                    this.GV = GV;
                    this.TietBD = TietBD;
                    this.TietKT = TietKT;
                    this.NgayMuon = NgayMuon;
                    this.NguoiMuon = NguoiMuon;
                    this.NguoiTra = NguoiTra;
                    this.LyDo = LyDo;
                }
                else
                {
                    throw new Exception("Gặp lỗi trong việc khởi tạo đối tượng TKB");
                }
            }
        }

        public class PhongTrong
        {
            //
            public string TenPhong { get; set; }
            public string TietTrong { get; set; }
            public DateTime Ngay { get; set; }

            //
            public PhongTrong(string IDPhong, string TietTrong, DateTime NgayMuon)
            {
                if (IDPhong != "" && TietTrong != "" && NgayMuon is DateTime)
                {
                    this.TenPhong = IDPhong;
                    this.TietTrong = TietTrong;
                    this.Ngay = NgayMuon;
                }
                else
                {
                    throw new Exception("Không được để trống");
                }
            }
        }

        public class cbbItem
        {
            //
            public string Text { get; set; }
            public object Value { get; set; }

            //
            //public override string ToString()
            //{
            //    return Text;
            //}
            public cbbItem(string t, object v)
            {
                if (t != "" && v != (object)"")
                {
                    this.Text = t;
                    this.Value = v;
                }
                else
                {
                    throw new Exception("Không thể trống");
                }
            }
        }

        public QuanLy()
        {
            InitializeComponent();
            try
            {
                cn.Open();
            }
            catch (SqlException ex)
            {
                throw new Exception("Lỗi kết nối");
                //MessageBox.Show("Loi ket noi !!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                cn.Close();
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            cn.Open();

            string sql = "SELECT " +
                            "P.TenPhong, " +
                            "LH.TenLop, " +
                            "M.TenMon, " +
                            "TKB.TietBD, " +
                            "TKB.TietKT, " +
                            "TKB.Ngay, " +
                            "MP.TenNgMuon, " +
                            "TP.TenNgTra, " +
                            "MP.Note " +
                        "FROM " +
                            "TKBieu TKB, " +
                            "MuonPhong MP, " +
                            "TraPhong TP, " +
                            "Phong P, " +
                            "LopHoc LH," +
                            "Mon M " +
                        "WHERE " +
                            "TKB.MaMP LIKE MP.MaMP " +
                            "AND TKB.MaTP LIKE TP.MaTP " +
                            "AND TKB.MaPhong LIKE P.MaPhong " +
                            "AND TKB.MaLH LIKE LH.MaLH " +
                            "AND LH.MaMon LIKE M.MaMon";

            List<TKB> list = new List<TKB>();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            int  TietBD, TietKT; 
            DateTime NgayMuon;
            string NguoiMuon, NguoiTra, LyDo, Phong, Lop, Mon;
            while (dr.Read())
            {
                Phong = dr.GetString(0);
                Lop = dr.GetString(1);
                Mon = dr.GetString(2);
                TietBD = dr.GetInt32(3);
                TietKT = dr.GetInt32(4);
                NgayMuon = dr.GetDateTime(5);
                NguoiMuon = dr.GetString(6);
                NguoiTra = dr.GetString(7);
                LyDo = dr.GetString(8);
                TKB tkbieu = new TKB(Phong, Lop, Mon, TietBD, TietKT, NgayMuon, NguoiMuon, NguoiTra, LyDo);
                list.Add(tkbieu);
            }
            dr.Close();
            dgvTKB.DataSource = list;
            cn.Close();
        }

        private void btnPT_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sql = "select TKB.* from TKBieu TKB";
            List<PhongTrong> list = new List<PhongTrong>();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            int IDPhong, TietBD, TietKT;
            string TenPhong;
            DateTime Ngay;
            int[,] tiet = new int[10, 14];
            string[] TenP = new string[10];
            DateTime NgayDuocChon = DateTime.ParseExact(dtpPT.Text, "dd/MM/yyyy", new CultureInfo("en-US"));
            while (dr.Read())
            {
                IDPhong = dr.GetInt32(0);
                TietBD = dr.GetInt32(2);
                TietKT = dr.GetInt32(3);
                Ngay = dr.GetDateTime(4);

                // Cẩn thận với setting datetime của máy (dd-mm-yyyy hay mm-dd-yyy)
                if (Ngay.Date == NgayDuocChon)
                //if (Ngay.Date == Convert.ToDateTime(dtpPT.Text))
                {
                    for (int i = TietBD; i <= TietKT; i++)
                    {
                        tiet[IDPhong-1, i] = 1;
                    }
                }
            }
            dr.Close();
            sql = "select P.MaPhong, P.TenPhong from Phong P";
            cmd = new SqlCommand(sql, cn);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                IDPhong = dr.GetInt32(0);
                TenPhong = dr.GetString(1);
                TenP[IDPhong - 1] = TenPhong;
            }
            dr.Close();
            for (int i = 0; i < 10; i++)
            {
               string tt = ""; 
               for (int j = 1; j <= 13; j++)
               {
                   if( tiet[i, j] != 1)
                   {
                       tt += j + ", ";
                   }
               }
               tt = tt.TrimEnd(' ');
               tt = tt.TrimEnd(',');
               
                // Cẩn thận với setting datetime của máy (dd-mm-yyyy hay mm-dd-yyy)
               PhongTrong room = new PhongTrong(TenP[i], tt, NgayDuocChon);
               list.Add(room);
            }
            dgvTKB.DataSource = list;
            cn.Close();
        }
        string newValue = "";
        string newDisp = "";
        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "";

            if (cn != null && cn.State == ConnectionState.Closed)
                cn.Open();
            else throw new Exception("Error when open connection");

            cbbItem cbb = (cbbItem)cbbLoai.SelectedItem;
            string value = cbb.Value.ToString();

            switch (value)
            {
                case "MaMon":
                    {
                        sql = "select MaMon, TenMon from Mon";
                        newDisp = "TenMon";
                        newValue = "MaMon";
                        break;
                    }
                case "MaPhong":
                    {
                        sql = "select MaPhong,TenPhong from Phong";
                        newDisp = "TenPhong";
                        newValue = "MaPhong";
                        break;
                    }
                case "MaGV":
                    {
                        sql = "select MaGV, TenGV from GiangVien";
                        newDisp = "TenGV";
                        newValue = "MaGV";
                        break;
                    }
            }
            List<cbbItem> list= new List<cbbItem>();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            ad.Fill(ds);
            cbbChiTiet.DataSource = ds.Tables[0];
            cbbChiTiet.DisplayMember = newDisp;
            cbbChiTiet.ValueMember = newValue;

            cn.Close();
        }

        private void QuanLy_Load(object sender, EventArgs e)
        {
            cbbItem i1,i2,i3;
            i1 = new cbbItem("Môn học","MaMon");
            i2 = new cbbItem("Phòng", "MaPhong");
            i3 = new cbbItem("Giảng viên", "MaGV");
            List<cbbItem> list= new List<cbbItem>();
            list.Add(i1);
            list.Add(i2);
            list.Add(i3);
            cbbLoai.DataSource = list;
            cbbLoai.DisplayMember = "Text";
            cbbLoai.ValueMember = "Value";
        }

        private void btnTK_Click(object sender, EventArgs e)
        {
            cn.Open();
            string sql = "";
            DataTable dsCT = (DataTable)cbbChiTiet.DataSource;
            string Ma = dsCT.Rows[cbbChiTiet.SelectedIndex][0].ToString();
            cbbItem cbbL = (cbbItem)cbbLoai.SelectedItem;
            string Loai = cbbL.Value.ToString();

            //sql =   "SELECT P.TenPhong, " +
            //            "LH.TenLop, " +
            //            "M.TenMon, " +
            //            "GV.TenGV, " +
            //            "TKB.TietBD, " +
            //            "TKB.TietKT, " +
            //            "TKB.Ngay, " +
            //            "MP.TenNgMuon, " +
            //            "TP.TenNgTra, " +
            //            "MP.Note " +
            //        "FROM " +
            //            "TKBieu TKB, " +
            //            "MuonPhong MP, " +
            //            "TraPhong TP, " +
            //            "Phong P, " +
            //            "LopHoc LH, " +
            //            "Mon M, " +
            //            "GiangVien GV " +
            //        "WHERE " +
            //            "TKB.MaMP LIKE MP.MaMP " +
            //            "AND TKB.MaTP LIKE TP.MaTP " +
            //            "AND TKB.MaPhong LIKE P.MaPhong " +
            //            "AND TKB.MaLH LIKE LH.MaLH " +
            //            "AND GV.MaGV LIKE LH.MaGV " +
            //            "AND LH.MaMon LIKE M.MaMon ";
            sql = "SELECT P.TenPhong, LH.TenLop,  M.TenMon,  GV.TenGV, TKB.TietBD,TKB.TietKT,TKB.Ngay,MP.TenNgMuon,TP.TenNgTra, MP.Note "
                    +"FROM TKBieu TKB, MuonPhong MP, TraPhong TP, Phong P, LopHoc LH, Mon M, GiangVien GV "
                    +"WHERE TKB.MaMP LIKE MP.MaMP AND TKB.MaTP LIKE TP.MaTP AND TKB.MaPhong LIKE P.MaPhong AND TKB.MaLH LIKE LH.MaLH AND GV.MaGV LIKE LH.MaGV AND LH.MaMon LIKE M.MaMon ";
            if (Loai == "MaMon")
            {
                sql += "AND M.MaMon LIKE " + Ma;
            }
            if (Loai == "MaPhong")
            {
                sql += "AND TKB.MaPhong LIKE " + Ma;
            }
            if (Loai == "MaGV")
            {
                sql += "AND LH.MaGV LIKE " + Ma;
            }

            List<TKB> list = new List<TKB>();
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();

            int  TietBD, TietKT; 
            DateTime NgayMuon;
            string NguoiMuon, NguoiTra, LyDo, Phong, Lop, Mon, GV;

            while (dr.Read())
            {
                Phong = dr.GetString(0);
                Lop = dr.GetString(1);
                Mon = dr.GetString(2);
                GV = dr.GetString(3);
                TietBD = dr.GetInt32(4);
                TietKT = dr.GetInt32(5);
                NgayMuon = dr.GetDateTime(6);
                NguoiMuon = dr.GetString(7);
                NguoiTra = dr.GetString(8);
                LyDo = dr.GetString(9);
                TKB tkbieu = new TKB(Phong, Lop, Mon, GV,TietBD, TietKT, NgayMuon, NguoiMuon, NguoiTra, LyDo);
                list.Add(tkbieu);
            }

            dr.Close();
            dgvTKB.DataSource = list;

            cn.Close();
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace RoomManager
{
    public partial class Sua : Form
    {
        public class cbbItem
        {
            //
            public string Text { get; set; }
            public object Value { get; set; }

            public cbbItem(string t, object v)
            {
                this.Text = t;
                this.Value = v;
            }
        }
        PhongHu FPhongHu;
        SqlConnection cn = new SqlConnection();
        public Sua(PhongHu f)
        {
            FPhongHu = f;
            InitializeComponent();
            try
            {
                //string cnstr = "Server = .; Database = QLPH; Integrated Security = true;";
                //cn.ConnectionString = cnstr;
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString);

                if (cn != null && cn.State == ConnectionState.Closed)
                {
                    cn.Open();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Loi ket noi !!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                cn.Close();
            }

            ////////////////////////////////////////////////////////////

            List<cbbItem> list = new List<cbbItem>();
            cn.Open();
            string name;
            object v;
            string sql = "select MaPhong, TenPhong from Phong";
            SqlCommand cmd = new SqlCommand(sql, cn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                v = Convert.ToString(dr.GetInt32(0));
                name = dr.GetString(1);
                cbbItem item = new cbbItem(name, v);
                list.Add(item);
            }
            cbbPhong.DataSource = list;
            cbbPhong.DisplayMember = "Text";
            cbbPhong.ValueMember = "Value";
            dr.Close();

            ////////////////////////////////////////////////////////

            cbbItem cbb = (cbbItem)cbbPhong.SelectedItem;
            string value = cbb.Value.ToString();
            if (value != "")
            {
                string sql1 = "select * from Phong where MaPhong like " + value;
                bool mc, at, asang, ml, rdc;
                SqlCommand cmd1 = new SqlCommand(sql1, cn);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    mc = dr1.GetBoolean(2);
                    at = dr1.GetBoolean(3);
                    asang = dr1.GetBoolean(4);
                    ml = dr1.GetBoolean(5);
                    rdc = dr1.GetBoolean(6);
                    if (mc == true) { radMCTot.Checked = true; radMCHong.Checked = false; } else { radMCTot.Checked = false; radMCHong.Checked = true; }
                    if (at == true) { radATTot.Checked = true; radATHong.Checked = false; } else { radATTot.Checked = false; radATHong.Checked = true; }
                    if (asang == true) { radASTot.Checked = true; radASHong.Checked = false; } else { radASTot.Checked = false; radASHong.Checked = true; }
                    if (ml == true) { radMLTot.Checked = true; radMLHong.Checked = false; } else { radMLTot.Checked = false; radMLHong.Checked = true; }
                    if (rdc == true) { radRDCTot.Checked = true; radRDCHong.Checked = false; } else { radRDCTot.Checked = false; radRDCHong.Checked = true; }
                }
                dr1.Close();
            }
            cn.Close();
        }

        private void cbbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cn != null && cn.State == ConnectionState.Closed)
                cn.Open();
            cbbItem cbb = (cbbItem)cbbPhong.SelectedItem;
            string value = cbb.Value.ToString();
            if (value != "")
            {
                string sql1 = "select * from Phong where MaPhong like " + value;
                bool mc, at, asang, ml, rdc;
                SqlCommand cmd1 = new SqlCommand(sql1, cn);
                SqlDataReader dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    mc = dr1.GetBoolean(2);
                    at = dr1.GetBoolean(3);
                    asang = dr1.GetBoolean(4);
                    ml = dr1.GetBoolean(5);
                    rdc = dr1.GetBoolean(6);
                    if (mc == true) { radMCTot.Checked = true; radMCHong.Checked = false; } else { radMCTot.Checked = false; radMCHong.Checked = true; }
                    if (at == true) { radATTot.Checked = true; radATHong.Checked = false; } else { radATTot.Checked = false; radATHong.Checked = true; }
                    if (asang == true) { radASTot.Checked = true; radASHong.Checked = false; } else { radASTot.Checked = false; radASHong.Checked = true; }
                    if (ml == true) { radMLTot.Checked = true; radMLHong.Checked = false; } else { radMLTot.Checked = false; radMLHong.Checked = true; }
                    if (rdc == true) { radRDCTot.Checked = true; radRDCHong.Checked = false; } else { radRDCTot.Checked = false; radRDCHong.Checked = true; }
                }
                dr1.Close();
            }
            cn.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            cbbItem cbb = (cbbItem)cbbPhong.SelectedItem;
            int idroom = Convert.ToInt32(cbb.Value.ToString());
            cn.Open();
            SqlCommand cmd = new SqlCommand("QLPHRoomUpdate", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@IDPhong", idroom ));
            cmd.Parameters.Add(new SqlParameter("@MC", (radMCTot.Checked == true)?true:false ));
            cmd.Parameters.Add(new SqlParameter("@AT", (radATTot.Checked == true)?true:false ));
            cmd.Parameters.Add(new SqlParameter("@AS",(radASTot.Checked == true)?true:false ));
            cmd.Parameters.Add(new SqlParameter("@ML", (radMLTot.Checked == true)?true:false ));
            cmd.Parameters.Add(new SqlParameter("@RO", (radRDCTot.Checked == true)?true:false ));
            cmd.ExecuteNonQuery();
            cn.Close();
            if (MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                this.Close();
        }
      
        private void btnQuaylai_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sua_FormClosing(object sender, FormClosingEventArgs e)
        {
            FPhongHu.GetData();
        }

    }
}

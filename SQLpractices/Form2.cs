using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SQLpractices
{
    
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=LAPTOP-UP3DFBO5\SQLEXPRESS;Initial Catalog=Quanlybanhang;Persist Security Info=True;User ID=duy;Password=1";
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();
            string MVT = txtMVT.Text.Trim();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from VATTU where MaVTu='"+MVT+"'";
            cmd.Connection = conn;

            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                String tenVT = read.GetString(1);
                String DVT = read.GetString(2);
                float PT = read.GetFloat(3);
                txtTenVT.Text = tenVT;
                txtDVT.Text = DVT;
                txtphantram.Text = PT.ToString();
            }
            read.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Danh_sach ds = new Danh_sach();
            ds.Show();
        }
    }
}

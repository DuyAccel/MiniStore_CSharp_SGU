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
    public partial class Danh_sach : Form
    {
        public Danh_sach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strcon = @"Data Source=LAPTOP-UP3DFBO5\SQLEXPRESS;Initial Catalog=Quanlybanhang;Persist Security Info=True;User ID=duy;Password=1";
            SqlConnection conn = new SqlConnection(strcon);
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from VATTU";
            cmd.Connection = conn;

            listView1.View = View.Details;
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                ListViewItem listItem = new ListViewItem(read.GetString(0));
                listItem.SubItems.Add(read.GetString(1));
                listItem.SubItems.Add(read.GetString(2));
                listItem.SubItems.Add(read.GetFloat(3).ToString());
                listView1.Items.Add(listItem);
            }
            read.Close();
        }
    }
}

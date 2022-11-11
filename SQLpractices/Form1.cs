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
    public partial class Form1 : Form
    {
        string strCon = @"Data Source=LAPTOP-UP3DFBO5\SQLEXPRESS;Initial Catalog=Quanlybanhang;Persist Security Info=True;User ID=duy;Password=1";
        SqlConnection con;
        SqlCommand cmd;
        public Form1()
        {
            if(con == null)
            {
                con = new SqlConnection(strCon);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            string sql = "select MaNCC, TenNCC from NHACC";
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = con;

            InitializeComponent();
            listView1.View = View.List;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0) + "  /  " +reader.GetString(1));
                lvi.SubItems.Add(reader.GetString(0));
                listView1.Items.Add(lvi);
            }

            reader.Close();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (con == null)
            {
                con = new SqlConnection(strCon);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            if (listView1.SelectedItems.Count == 0)
                return;

            listView2.Items.Clear();

            string mancc = listView1.SelectedItems[0].SubItems[1].Text;
            string sql = $"select SoDH, NgayDH from dondh where mancc = '{mancc}'";
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            cmd.Connection = con;

            listView2.View = View.Details;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0));
                lvi.SubItems.Add(reader.GetDateTime(1).ToString());
                listView2.Items.Add(lvi);
            }

            reader.Close();
        }
    }
}

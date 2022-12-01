using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace SQLpractices
{
    internal class SQLConnection
    {
        string strCon = @"Data Source=LAPTOP-UP3DFBO5\SQLEXPRESS;Initial Catalog=Quanlybanhang;Persist Security Info=True;User ID=duy;Password=1";
        SqlConnection con;
        SqlCommand cmd;

        public SQLConnection()
        {
            if (con == null)
            {
                con = new SqlConnection(strCon);
            }
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            
        }
        
        public void insertVTu(ArrayList data, ListView lst)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string CmdTxt = "insert into VATTU values (@Ma, @Ten, @Dvi, @Ptram)";
            cmd.CommandText = CmdTxt;
            cmd.Parameters.Add("@Ma", SqlDbType.Char);
            cmd.Parameters.Add("@Ten", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Dvi", SqlDbType.NVarChar);
            cmd.Parameters.Add("@Ptram", SqlDbType.Real);

            cmd.Parameters[0].Value = data[0];
            cmd.Parameters[1].Value = data[1];
            cmd.Parameters[2].Value = data[2];
            cmd.Parameters[3].Value = data[3];

            int Try = cmd.ExecuteNonQuery();
            if (Try != 0)
            {
                MessageBox.Show("Successfull");
                this.Fill(lst);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        public void Fill (ListView listView1)
        {
            cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            string CmdTxt = "select MaNCC, TenNCC from NHACC";
            cmd.CommandText = CmdTxt;
            listView1.View = View.List;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem lvi = new ListViewItem(reader.GetString(0) + "  /  " + reader.GetString(1));
                lvi.SubItems.Add(reader.GetString(0));
                listView1.Items.Add(lvi);
            }

            reader.Close();
        }
    }
}

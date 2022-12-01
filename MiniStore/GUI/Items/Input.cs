using MiniStore.BUS;
using MiniStore.ExtendedFeatures;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.GUI.Items
{
    public partial class Input : UserControl
    {
        private Barcode scanner;
        public Input()
        {
            InitializeComponent();
            Search_gridview.DataSource = ProductBUS.getAllProduct();
            scanner = new Barcode();
            Quantity_txt.TextChanged += Quantity_txt_TextChanged;
            Paying_txt.TextChanged += Paying_txt_TextChanged;
        }

        private void Paying_txt_TextChanged(object sender, EventArgs e)
        {
            if (Paying_txt.Texts.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(Paying_txt.Texts)))
                {
                    Paying_txt.Texts = Paying_txt.Texts.Remove(Paying_txt.Texts.Length - 1, 1);
                }
            }
        }

        private void Quantity_txt_TextChanged(object sender, EventArgs e)
        {
            if (Quantity_txt.Texts.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(Quantity_txt.Texts)))
                {
                    Quantity_txt.Texts = Quantity_txt.Texts.Remove(Quantity_txt.Texts.Length - 1, 1);
                }
            }
        }
        private void IncreaseQty()
        {
            if (Quantity_txt.Texts.Length == 0)
            {
                Quantity_txt.Texts = "1";
                return;
            }
            int Qty = int.Parse(Quantity_txt.Texts);
            Quantity_txt.Texts = "" + (Qty + 1);
        }
        private void DescreaseQty()
        {
            if (Quantity_txt.Texts.Length == 0)
            {
                Quantity_txt.Texts = "1";
                return;
            }
            int Qty = int.Parse(Quantity_txt.Texts);
            if (Qty == 1) Qty++;
            Quantity_txt.Texts = "" + (Qty - 1);
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {

        }

        private void Search_gridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Search_gridview.SelectedRows.Count > 0)
            {
                ID_txt.Texts = Search_gridview.SelectedRows[0].Cells[0].Value.ToString();
                Quantity_txt.Texts = "1";
                pictureBox1.ImageLocation = Search_gridview.SelectedRows[0].Cells[6].Value.ToString();
            }
        }
        
        private void Scan_btn_Click(object sender, EventArgs e)
        {
            scanner.Scan(this.Barcode_pic, this.ID_txt, this.Quantity_txt);
        }

        private void Stop_btn_Click(object sender, EventArgs e)
        {
            scanner.StopScan();
        }

        private void Plus_btn_Click(object sender, EventArgs e)
        {
            IncreaseQty();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DescreaseQty();
        }
    }
}

using MiniStore.BUS;
using MiniStore.DTO;
using MiniStore.ExtendedFeatures;
using MiniStore.GUI.Features;
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
        private DataTable data =new DataTable();
        public Input()
        {
            InitializeComponent();
            Search_gridview.DataSource = ProductBUS.getAllProduct();
            scanner = new Barcode();
            Quantity_txt.TextChanged += Quantity_txt_TextChanged;
            TotalPrice_txt.TextChanged += Paying_txt_TextChanged;

        }
        private void Paying_txt_TextChanged(object sender, EventArgs e)
        {
            Quantity_txt.Texts = "";
            ID_txt.Texts = "";
            pictureBox1.ImageLocation = null;
            Price_txt.Texts = "";
            if (TotalPrice_txt.Texts.Length > 0)
            {
                if (!(new Regex(@"^[0-9\b]+$").IsMatch(TotalPrice_txt.Texts)))
                {
                    TotalPrice_txt.Texts = TotalPrice_txt.Texts.Remove(TotalPrice_txt.Texts.Length - 1, 1);
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
        private void reloadTotalPrice()
        {
            int total = 0;
            foreach (DataGridViewRow row in Product_gridview.Rows)
            {
                total += int.Parse(row.Cells[4].Value.ToString());
            }
            TotalPrice_txt.Texts = "" + total;
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
            if (Quantity_txt.Texts.Length == 0 || Quantity_txt.Texts == "0")
            {
                Quantity_txt.Texts = "1";
                return;
            }
            int Qty = int.Parse(Quantity_txt.Texts);
            if (Qty == 1) Qty++;
            Quantity_txt.Texts = "" + (Qty - 1);
        }

        private void addProduct()
        {
            ProductDTO product = ProductBUS.getProduct(ID_txt.Texts);
            if (product == null)
            {
                ConfirmDialog.Show("Product does not Exist!\nCreate a new one?");
                if (ConfirmDialog.Confirm.Confimation)
                {
                    ProductSetting.Show();
                }
                return;
            }
            int Qty;
            foreach (DataGridViewRow index in Product_gridview.Rows)
            {
                if (index.Cells[0].Value.ToString() == $"{product.Id}")
                {
                    Qty = int.Parse(index.Cells[2].Value.ToString());
                    index.Cells[2].Value = ""+(Qty + int.Parse(Quantity_txt.Texts.ToString()));
                    return;
                }
                
            }
            Product_gridview.Rows.Add(new object[] { null, null, null, null, null, null });
            DataGridViewRow row = (DataGridViewRow)Product_gridview.Rows[0].Clone();
            Product_gridview.Rows.RemoveAt(Product_gridview.Rows.Count - 1);
            row.Cells[0].Value = product.Id;
            row.Cells[1].Value = product.Name;
            row.Cells[2].Value = Quantity_txt.Texts;
            ((DataGridViewImageCell)row.Cells[3]).Value = Image.FromFile(product.Imgdir);
            row.Cells[4].Value = Price_txt.Texts;
            row.Cells[5].Value = product.Provider;
            Product_gridview.Rows.Add(row);
        }

        private void reset()
        {
            Product_gridview.Rows.Clear();
            Search_gridview.DataSource = ProductBUS.getAllProduct();
            ID_txt.Texts = "";
            Quantity_txt.Texts = "";
            pictureBox1.ImageLocation = null;
            TotalPrice_txt.Texts = "";
            Search_txt.Texts = "";
            Barcode_pic.ImageLocation = null;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            addProduct();
            reloadTotalPrice();
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

        private void Product_gridview_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (Product_gridview.SelectedRows.Count < 1) return;

            ID_txt.Texts = Product_gridview.SelectedRows[0].Cells[0].Value.ToString();
            Quantity_txt.Texts = Product_gridview.SelectedRows[0].Cells[2].Value.ToString();
            pictureBox1.Image = (Image)Product_gridview.SelectedRows[0].Cells[3].Value;
            Price_txt.Texts = Product_gridview.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Edit_btn_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Product_gridview.Rows)
            {
                if (row.Cells[0].Value.ToString() == ID_txt.Texts)
                {
                    row.Cells[2].Value = Quantity_txt.Texts;
                    row.Cells[4].Value = Price_txt.Texts;
                    reloadTotalPrice();
                    return;
                }
            }
            MessageDialog.Show("Invalid Product ID!!!");
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            reset();   
        }

        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            List<InputDetailDTO> details = new List<InputDetailDTO>();
            foreach(DataGridViewRow row in Product_gridview.Rows)
            {
                details.Add(new InputDetailDTO(
                    row.Cells[0].Value.ToString(),
                    int.Parse(row.Cells[2].Value.ToString()),
                    int.Parse(row.Cells[4].Value.ToString())
                    ));
            }
            InputDTO input = new InputDTO(
                User_txt.Texts.ToString(),
                int.Parse(TotalPrice_txt.Texts.ToString()),
                DateTime.Now
                );
            InputBUS.addInput(input, details);
            reset();
        }

        
    }
}

using MiniStore.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.GUI.Features
{
    public partial class Payment : UserControl
    {
        private List<ProductDTO> products;
        public Payment()
        {
            InitializeComponent();
            products = new List<ProductDTO>(); 
        }
        private void loadTable()
        {

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

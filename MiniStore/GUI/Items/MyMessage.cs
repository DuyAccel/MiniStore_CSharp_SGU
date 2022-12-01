using MiniStore.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.GUI.Items
{
    public partial class MyMessage : UserControl
    {
        public Form parent;
        public MyMessage(string message)
        {
            InitializeComponent();
            this.Message_label.Text = message; 
        }
        internal MyMessage(string message, bool signal)
        {
            InitializeComponent();
            this.Message_label.Text = message;
            Message_picture.Image = global::MiniStore.Properties.Resources.successful;
        } 
        private void Confirm_btn_Click(object sender, EventArgs e)
        {
            parent.Close();
        }

    }
}

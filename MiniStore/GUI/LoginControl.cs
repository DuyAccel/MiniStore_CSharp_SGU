using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.GUI
{
    public partial class LoginControl : UserControl
    {
        private MainScreen parent;
        public LoginControl(MainScreen parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        
        private void Login_btn_Click(object sender, EventArgs e)
        {
            parent.loginEvent();   
        }
    }
}

using MiniStore.BUS;
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
using MiniStore.GUI.Items;
using ZXing.QrCode.Internal;
using System.IO;

namespace MiniStore.GUI
{
    public partial class LoginControl : UserControl
    {
        private MainScreen parent;
        private EmployeeDTO employee;
        public LoginControl(MainScreen parent)
        {
            this.parent = parent;
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private int loginVerification()
        {
            employee = EmployeeBUS.getEmployee(UserN_txt.Texts);
            if (employee == null)
            {
                MyMessage message = new MyMessage("Username does not exist!!");
                MyDialog dialog = new MyDialog(message);
                message.parent = dialog;
                dialog.ShowDialog();
                return 0;
            } 
            if (employee.Pass != Pass_txt.Texts)
            {
                MyMessage message = new MyMessage("Password is incorrect!!!");
                MyDialog dialog = new MyDialog(message);
                message.parent = dialog;
                dialog.ShowDialog();
                return 1;
            }
            return 2;

        }
        private void Login_btn_Click(object sender, EventArgs e)
        {
            if (loginVerification() != 2) return;
            parent.LoginEvent(employee);
        }

        
    }
}

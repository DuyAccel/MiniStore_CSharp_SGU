using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniStore.GUI.Items
{
    public class ConfirmDialog
    {
        public static Confirmation Confirm;
        private static MyDialog myD;
        public ConfirmDialog(string message)
        {
            Confirm = new Confirmation(message);
            myD = new MyDialog(Confirm);
            Confirm.parent = myD;
            myD.ShowDialog();
        }
        public static void Show(string message)
        {
            Confirm = new Confirmation(message);
            myD = new MyDialog(Confirm);
            Confirm.parent = myD;
            myD.ShowDialog();
        }
    }
}

using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore.GUI
{
    public partial class MainScreen : Form
    {
        private GUIControl gui = new GUIControl();
        private TestControl test = new TestControl();
        private MainControl main = new MainControl(); 
        private FeaturesControl feature = new FeaturesControl();
        private LoginControl login;

        private List<FeatureIcon> features = new List<FeatureIcon>(); 
        private FeatureIcon cashier = new FeatureIcon();
        private FeatureIcon inventory = new FeatureIcon();
        private FeatureIcon employee = new FeatureIcon();
        private FeatureIcon consumer = new FeatureIcon();
        private FeatureIcon statistic = new FeatureIcon();
        private FeatureIcon setting = new FeatureIcon();
        private FeatureIcon help = new FeatureIcon();

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle = 0x00020000;
                return cp;
            }
        }
        
        private void init()
        {

            login = new LoginControl(this);
            login.Dock = DockStyle.Fill;
            feature.Dock = DockStyle.Fill;

            this.DoubleBuffered = true;
            this.ScreenPanel.Controls.Add(login);

           
        }
        private void initFeatures()
        {
            cashier.setFeatureName("Cashier");
            inventory.setFeatureName("Inventory Management");
            employee.setFeatureName("Employee Management");
            consumer.setFeatureName("Consumer Management");
            statistic.setFeatureName("Statistic");
            setting.setFeatureName("Account Setting");
            help.setFeatureName("Help");

            inventory.setIcon(FontAwesome.Sharp.IconChar.Warehouse);
            employee.setIcon(FontAwesome.Sharp.IconChar.UsersGear);
            consumer.setIcon(FontAwesome.Sharp.IconChar.UsersRectangle);
            statistic.setIcon(FontAwesome.Sharp.IconChar.ChartColumn);
            setting.setIcon(FontAwesome.Sharp.IconChar.Gears);
            help.setIcon(FontAwesome.Sharp.IconChar.CircleInfo);

            features.Add(cashier);
            features.Add(inventory);
            features.Add(employee);
            features.Add(consumer);
            features.Add(statistic);
            features.Add(setting);
            features.Add(help);

        }
        public MainScreen()
        {
            InitializeComponent();
            init();
            initFeatures();
        }

        public void loginEvent()
        {

            this.ScreenPanel.Controls.Clear();
            feature.AddFeatures(features);
            this.ScreenPanel.Controls.Add(feature);
            
        }


        private void switchFeature()
        {
            this.Controls.Clear();  
            gui.Dock = DockStyle.Fill;
            this.Controls.Add(test);
        }



        private void TaskbarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private bool isFullScreen = false;
        private void FullScreen_btn_Click(object sender, EventArgs e)
        {
            if (isFullScreen)
            {
                this.WindowState = FormWindowState.Normal;
                this.FullScreen_btn.IconChar = FontAwesome.Sharp.IconChar.Square;
                isFullScreen = false;
                return;
            }
            this.WindowState = FormWindowState.Maximized;
            this.FullScreen_btn.IconChar = FontAwesome.Sharp.IconChar.Compress;
            isFullScreen = true;

        }

        private void Hide_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

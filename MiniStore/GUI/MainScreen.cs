using AForge.Video.DirectShow;
using FontAwesome.Sharp;
using Kho;
using MiniStore.DTO;
using MiniStore.GUI.Controls;
using MiniStore.GUI.Features;
using MiniStore.GUI.Items;
using QLKH_QLNV;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace MiniStore.GUI
{
    public partial class MainScreen : Form
    {
        private EmployeeDTO employee;
        private MainControl main;
        private FeaturesControl feature = new FeaturesControl();
        private LoginControl login;

        private Cashier Cashier;
        private Inventory Inventory;
        private QLNV EmployeeMng;
        private QLKH ConsumerMng;
        private QLProduct ProductMng;
        private EmployeeItem AccountSetting;
       


        private List<FeatureIcon> BigFeatures = new List<FeatureIcon>();
        private List<FeatureButton> SmallFeatures = new List<FeatureButton>();
        private FeatureIcon B_cashier;
        private FeatureIcon B_inventory;
        private FeatureIcon B_employee;
        private FeatureIcon B_consumer;
        private FeatureIcon B_statistic;
        private FeatureIcon B_setting;
        private FeatureIcon B_help;
        private FeatureButton s_cashier;
        private FeatureButton s_inventory;
        private FeatureButton s_employee;
        private FeatureButton s_consumer;
        private FeatureButton s_statistic;
        private FeatureButton s_setting;
        private FeatureButton s_help;

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
        
        private void initLogin()
        {

            login = new LoginControl(this);
            main = new MainControl(this);

            Cashier = new Cashier();
            Inventory = new Inventory();
            EmployeeMng = new QLNV();
            ConsumerMng = new QLKH();
            ProductMng = new QLProduct();
            AccountSetting = new EmployeeItem(0);


            login.Dock = DockStyle.Fill;
            feature.Dock = DockStyle.Fill;
            main.Dock = DockStyle.Fill;

            this.DoubleBuffered = true;
            this.ScreenPanel.Controls.Add(login);
        }
        private void initFeatures()
        {
            FeatureIcon.main = this;

            B_cashier = new FeatureIcon();
            B_inventory = new FeatureIcon();
            B_employee = new FeatureIcon();
            B_consumer = new FeatureIcon();
            B_statistic = new FeatureIcon();
            B_setting = new FeatureIcon();
            B_help = new FeatureIcon();


            B_cashier.setFeatureName("Cashier");
            B_inventory.setFeatureName("Inventory Management");
            B_employee.setFeatureName("Employee Management");
            B_consumer.setFeatureName("Consumer Management");
            B_statistic.setFeatureName("Statistic");
            B_setting.setFeatureName("Account Setting");
            B_help.setFeatureName("Help");

            B_inventory.setIcon(IconChar.Warehouse);
            B_employee.setIcon(IconChar.UsersGear);
            B_consumer.setIcon(IconChar.UsersRectangle);
            B_statistic.setIcon(IconChar.ChartColumn);
            B_setting.setIcon(IconChar.Gears);
            B_help.setIcon(IconChar.CircleInfo);

            FeatureButton.main = this;

            s_cashier = new FeatureButton();
            s_inventory = new FeatureButton();
            s_employee = new FeatureButton();
            s_consumer = new FeatureButton();
            s_statistic = new FeatureButton();
            s_setting = new FeatureButton();
            s_help = new FeatureButton();

            s_cashier.IconChar = IconChar.MoneyBill1Wave;
            s_inventory.IconChar = IconChar.Warehouse;
            s_employee.IconChar = IconChar.UserGear;             
            s_consumer.IconChar = IconChar.UsersRectangle;
            s_statistic.IconChar = IconChar.ChartColumn;
            s_setting.IconChar = IconChar.Gears;
            s_help.IconChar = IconChar.CircleInfo;

            B_cashier.Fname = s_cashier.Fname = FeatureName.Cashier;
            B_inventory.Fname = s_inventory.Fname = FeatureName.Inventory;
            B_employee.Fname = s_employee.Fname = FeatureName.Employee;
            B_consumer.Fname = s_consumer.Fname = FeatureName.Consumer;
            B_statistic.Fname = s_statistic.Fname = FeatureName.Statistic;
            B_setting.Fname = s_setting.Fname = FeatureName.Setting;
            B_help.Fname = s_help.Fname = FeatureName.Help;
            
            
        }
        public MainScreen()
        {
            InitializeComponent();
            initLogin();
            initFeatures();
        }

        public void LoginEvent(EmployeeDTO user)
        {
            switch (user.Role)
            {
                case EmployeeRole.Cashier:
                    SmallFeatures.Add(s_cashier);
                    SmallFeatures.Add(s_consumer);
                    SmallFeatures.Add(s_setting);
                    SmallFeatures.Add(s_help);

                    BigFeatures.Add(B_cashier);
                    BigFeatures.Add(B_consumer);
                    BigFeatures.Add(B_setting);
                    BigFeatures.Add(B_help);
                    break;
                case EmployeeRole.InventoryManger:
                    SmallFeatures.Add(s_inventory);
                    SmallFeatures.Add(s_setting);
                    SmallFeatures.Add(s_help);

                    BigFeatures.Add(B_inventory);
                    BigFeatures.Add(B_setting);
                    BigFeatures.Add(B_help);
                    break;
                default:
                    SmallFeatures.Add(s_cashier);
                    SmallFeatures.Add(s_inventory);
                    SmallFeatures.Add(s_employee);
                    SmallFeatures.Add(s_consumer);
                    SmallFeatures.Add(s_statistic);
                    SmallFeatures.Add(s_setting);
                    SmallFeatures.Add(s_help);

                    BigFeatures.Add(B_cashier);
                    BigFeatures.Add(B_inventory);
                    BigFeatures.Add(B_employee);
                    BigFeatures.Add(B_consumer);
                    BigFeatures.Add(B_statistic);
                    BigFeatures.Add(B_setting);
                    BigFeatures.Add(B_help);
                    break;
            }

            feature.init(user.Name, user.Imgdir);
            main.init(user.Imgdir);

            feature.AddFeatures(BigFeatures);
            main.AddFeatures(SmallFeatures);

            this.ScreenPanel.Controls.Clear();
            this.ScreenPanel.Controls.Add(feature);
            employee = user;
        }
        
        public void SwitchScreenEvent(bool signal)
        {
            this.ScreenPanel.Controls.Clear();
            if (signal)
            {
                ScreenPanel.Controls.Add(main);
                return;
            }
            ScreenPanel.Controls.Add(feature);
        }

        public void SwitchFeatureEvent(FeatureName f)
        {
            
            switch (f)
            {
                case FeatureName.Cashier:
                    main.SwitchFeature(Cashier, f);
                    break;
                case FeatureName.Employee:
                    main.SwitchFeature(EmployeeMng, f);
                    break;
                case FeatureName.Consumer:
                    main.SwitchFeature(ConsumerMng, f);
                    break;
                case FeatureName.Setting:
                    AccountSetting.initUser(employee);
                    main.SwitchFeature(AccountSetting, f);
                    break;
                case FeatureName.Inventory:
                    main.SwitchFeature(Inventory, f);
                    break;
            }
        }
        
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            
            ConfirmDialog.Show("Exit Application?");
            if (ConfirmDialog.Confirm.Confimation)
            {
                this.Dispose();
            }

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

        private void ButtonPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

    }
}

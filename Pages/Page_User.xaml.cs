﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Co_work.Pages
{
    /// <summary>
    /// Page_User.xaml 的交互逻辑
    /// </summary>
    public partial class Page_User : Page
    {
        public MainWindow Owner = new MainWindow();

        public Page_User_Login page_User_Login;

        public Page_User()
        {
            InitializeComponent();
        }

        private void Btn_Logout_Click(object sender, RoutedEventArgs e)
        {
            Owner.isLogined = false;
            Owner.User = null;
            CheckLoginState();
        }

        public void CheckLoginState()
        {
            if (!Owner.isLogined)
            {
                if (page_User_Login == null)
                {
                    page_User_Login = new Page_User_Login();
                    page_User_Login.Owner = this;
                }
                Owner.Change_Page.Content = new Frame()
                {
                    Content = page_User_Login
                };
                page_User_Login.Tb_Id.Focus();
            }
            else
            {
                Lb_Id.Content = Owner.User.ID;
                Lb_Name.Content = Owner.User.Name;
            }
        }
    }
}

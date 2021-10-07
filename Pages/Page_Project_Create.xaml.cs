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
    /// Page_Project_Create.xaml 的交互逻辑
    /// </summary>
    public partial class Page_Project_Create : Page
    {
        public Page_Project Owner;
        public Page_Project_Create()
        {
            InitializeComponent();
        }

        private void Btn_Save_Click(object sender, RoutedEventArgs e)
        {
            if (newProjectName.Text != "")
            {
                (this.Owner as Page_Project).newProjectName = newProjectName.Text;
                if (newProjectIntro.Text == "")
                    newProjectIntro.Text = "无";
                (this.Owner as Page_Project).newProjectIntro = newProjectIntro.Text;
                (this.Owner as Page_Project).newProjectDeadline = newProjectDeadline.Text;
                ChangePageProject();
                (this.Owner as Page_Project).CreatProject();
                newProjectName.Text = "";
                newProjectIntro.Text = "";
                newProjectDeadline.Text = "";
            }
        }

        private void ChangePageProject()
        {
            (this.Owner.Owner as MainWindow).Change_Page.Content = new Frame()
            {
                Content = this.Owner
            };
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Collections.Specialized;

namespace TradeBlotterAppl
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    /// 
    /// This uis a method
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        public string username;

        private void PageAction(object sender, RoutedEventArgs e)
        {
            //MainWindow userLog = new MainWindow();
            //bool? result1 = userLog.ShowDialog();
            username = txtUserName.Text;
            string password = txtPassword.Password;
            var client = new WebClient();
            string naam;
            using (client)
            {
                var values = new NameValueCollection();
                values["username"] = username;
                values["password"] = password;
                var res = client.UploadValues("http://10.87.226.147:8080/TeamOneTradeBlotterFinalWeb/rest/traders/signinsecure", values);
                var str = Encoding.Default.GetString(res);
                if (str == "true")
                {
                    MainWindow userLog = new MainWindow(username);
                    //FilterWindow filterWindowFilter = new FilterWindow();
                    naam = txtUserName.Text;
                    userLog.lstUserName.Items.Add(naam);
                    bool? result1 = userLog.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Sorry failed to log in. Try again!");
                }

            }

        }

        private void goToSignUp(object sender, RoutedEventArgs e)
        {
            SignUpWindow newUserAdd = new SignUpWindow();
            bool? resultLoginAttempt = newUserAdd.ShowDialog();
        }

        private void sendToBack(object sender, EventArgs e)
        {
        
        }

        private void txtUserName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}


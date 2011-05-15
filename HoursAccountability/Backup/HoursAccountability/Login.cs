using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HoursAccountability
{
    public partial class Login : Form
    {
        private bool _remembered = false;
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            TwinfieldSession.LogonResult logonResult;
            TwinfieldSession.LogonAction nextAction;
            string cluster;

            TwinfieldSession.Header header
                = HoursAccounting.TwfSession.Logon(txtUser.Text, txtPassword.Text, txtOrganisation.Text, out logonResult, out nextAction, out cluster);

            // Check result values, return if anything is not ok
            if (logonResult == HoursAccountability.TwinfieldSession.LogonResult.Ok)
            {
                if (nextAction == HoursAccountability.TwinfieldSession.LogonAction.None)
                {
                    HoursAccounting.SessionId = header.SessionID;

                    if (chkRemember.Checked)
                    {
                        Microsoft.Win32.RegistryKey userAppKey = Application.UserAppDataRegistry;
                        userAppKey.SetValue("user", txtUser.Text);
                        userAppKey.SetValue("password", DPAPI.Encrypt(txtPassword.Text));

                    }
                    else if (_remembered)
                    {
                        Application.UserAppDataRegistry.DeleteValue("user", false);
                        Application.UserAppDataRegistry.DeleteValue("password", false);
                    }

                    this.Close();
                }
                else
                {
                    switch (nextAction)
                    {
                        case HoursAccountability.TwinfieldSession.LogonAction.ChangePassword:
                            MessageBox.Show("Password must be changed, this is not yet supported.");
                            return;
                        case HoursAccountability.TwinfieldSession.LogonAction.SMSLogon:
                            MessageBox.Show("SMS must be used to login, this is not yet supported.");
                            return;
                        default:
                            MessageBox.Show("Unknown action necessary to login.");
                            return;
                    }
                }
            }
            else
            {
                MessageBox.Show("result: " + logonResult.ToString());
                return;
            }   
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Microsoft.Win32.RegistryKey userAppKey = Application.UserAppDataRegistry;
            string user = (string)userAppKey.GetValue("user");
            string encryptedPassword = (string)userAppKey.GetValue("password");

            if (user != null)
            {
                _remembered = true;
                txtUser.Text = user;
            }
            if (encryptedPassword != null)
            {
                _remembered = true;
                txtPassword.Text = DPAPI.Decrypt(encryptedPassword);
            }
        }
    }
}

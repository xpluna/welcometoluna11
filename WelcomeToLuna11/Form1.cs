using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WelcomeToLuna11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBoxAutoStart.Checked = Properties.Settings.Default.AutoStart;
        }

        private void checkBoxAutoStart_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoStart.Checked)
            {
                // Add the program to the registry for auto-start
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.SetValue(Application.ProductName, Application.ExecutablePath);

                key.Close();
            }
            else
            {
                // Remove the program from the registry to prevent auto-start
                RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                key.DeleteValue(Application.ProductName, false);

                key.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (checkBoxAutoStart.Checked != Properties.Settings.Default.AutoStart)
            {
                // Show a confirmation dialog or take other appropriate action
                DialogResult result = MessageBox.Show("Auto-start setting has changed. Do you want to save?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Save the new auto-start setting
                    Properties.Settings.Default.AutoStart = checkBoxAutoStart.Checked;
                    Properties.Settings.Default.Save();
                }
                else if (result == DialogResult.No)
                {
                    // Restore the previous auto-start setting
                    checkBoxAutoStart.Checked = Properties.Settings.Default.AutoStart;
                }
                else
                {
                    // Cancel closing the application
                    e.Cancel = true;
                }
            }
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            // Create an instance of AboutForm
            AboutForm aboutForm = new AboutForm();

            // Show the new form
            aboutForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://dsc.gg/xpluna");
        }
    }
}

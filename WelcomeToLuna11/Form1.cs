using Microsoft.Win32;
using System;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace WelcomeToLuna11
{
    public partial class Form1 : Form
    {
        private const string GithubApiUrl = "https://api.github.com/repos/xpluna/welcometoluna11/releases/latest";
        private const string CurrentVersion = "1.0.0";

        public Form1()
        {
            InitializeComponent();
        }

        private async void CheckForUpdates()
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // GitHub requires a User-Agent header
                    client.DefaultRequestHeaders.Add("User-Agent", "WelcometoLuna11");

                    HttpResponseMessage response = await client.GetAsync(GithubApiUrl);
                    response.EnsureSuccessStatusCode();

                    string responseBody = await response.Content.ReadAsStringAsync();
                    JObject release = JObject.Parse(responseBody);

                    string latestVersion = release["tag_name"]?.ToString();
                    string releaseUrl = release["html_url"]?.ToString();

                    if (IsNewerVersion(latestVersion, CurrentVersion))
                    {
                        MessageBox.Show($"A new version ({latestVersion}) is available! Download it here: {releaseUrl}", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("You have the latest version.", "No Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error checking for updates: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsNewerVersion(string latestVersion, string currentVersion)
        {
            Version latest = new Version(latestVersion);
            Version current = new Version(currentVersion);
            return latest.CompareTo(current) > 0;
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

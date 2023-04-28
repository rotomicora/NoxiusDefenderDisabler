using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

/*
---------------------------------------------------
            NOXIUS DEFENDER DISABLER
---------------------------------------------------
           Developed by rotomicora#0001
---------------------------------------------------
            https://discord.gg/noxius
---------------------------------------------------
*/

namespace NoxiusDefenderDisabler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/noxius");
        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/franafp");
        }

        private void disable_Click(object sender, EventArgs e)
        {
            RegistryKey key1 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            key1.SetValue("DisableAntiSpyware", 1);
            if (key1.GetValue("DisableAntiSpyware").ToString() == "0")
            {
                MessageBox.Show("Failed to disable Windows Defender", "NoxiusDefenderDisabler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (key1.GetValue("DisableAntiSpyware").ToString() == "1")
            {
                MessageBox.Show("Windows Defender Disabled Sucessfully", "NoxiusDefenderDisabler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            key1.Dispose();
        }

        private void enable_Click(object sender, EventArgs e)
        {
            RegistryKey key1 = Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender", true);
            key1.SetValue("DisableAntiSpyware", 0);
            if (key1.GetValue("DisableAntiSypware") != null && key1.GetValue("DisableAntiSypware").ToString() == "0")
            {
                MessageBox.Show("Windows Defender Enabled Sucessfully", "NoxiusDefenderDisabler", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Failed to enable Windows Defender", "NoxiusDefenderDisabler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            key1.Dispose();
        }
    }
}

using Kockie_Optimizer_Csharp.Classes;
using Microsoft.VisualStudio.Services.CircuitBreaker;
using Microsoft.Win32;
using System.Diagnostics;

namespace Kockie_Optimizer_Csharp
{
    public partial class OW : Form
    {
        public int tweaksDefine;
        public OW()
        {
            InitializeComponent();
        }

        private void btnBasicTweaks_Click(object sender, EventArgs e)
        {
            Optimize.BasicTweaks();
        }

        private void btnUndoTweaks1_Click(object sender, EventArgs e)
        {
            Optimize.RemoveBasicTweaks();
        }

        private void btnAdvancedTweaks_Click(object sender, EventArgs e)
        {
            Optimize.AdvancedTweaks();
        }

        private void btnUndotweaks_Click(object sender, EventArgs e)
        {
            Optimize.RemoveAdvancedTweaks();
        }

        private void btnUndodefender_Click(object sender, EventArgs e)
        {
            Optimize.RemoveDefender();
        }

        private void btnActivatedefender_Click(object sender, EventArgs e)
        {
            Optimize.ActiveDefender();
        }

        private void btnRmvDefaultApps_Click(object sender, EventArgs e)
        {
            try
            {
                string batDirectory = "./Files/removeDefaultApps.bat";
                Process.Start("cmd.exe", batDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
        }

        private void btnReinstallDefaultApps_Click(object sender, EventArgs e)
        {
            try
            {
                string batDirectory = "./Files/reinstallDefaultApps.bat";
                Process.Start("cmd.exe", batDirectory);
                Utilities.RestartExplorer();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            
        }

        private void btnInstallCommonApps_Click(object sender, EventArgs e)
        {
            try
            {
                string batDirectory = "./Files/installNecessaryApps.bat";
                Process.Start("cmd.exe", batDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            
        }

        private void btnRemoveCommonApps_Click(object sender, EventArgs e)
        {
            try
            {
                string batDirectory = "./Files/removeNecessaryApps.bat";
                Process.Start("cmd.exe", batDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            
        }
    }
}

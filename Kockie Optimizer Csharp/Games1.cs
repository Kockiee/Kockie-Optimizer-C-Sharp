using Microsoft.VisualStudio.Services.FileContainer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kockie_Optimizer_Csharp
{
    public partial class Games1 : Form
    {
        public int chkState;
        public Games1()
        {
            InitializeComponent();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 0;
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 1;
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 2;
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 3;
        }

        private void btnOT1_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkState == 0)
                {
                    ConfiginFortnite("FortAlto");
                }
                else if (chkState == 1)
                {
                    ConfiginFortnite("FortBaixo");
                }
                else
                {
                    MessageBox.Show("Selecione uma opção válida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Current configuration not found {ex}");
            }
        }

        private void btnOT2_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkState == 2)
                {
                    ConfiginGtaV("GtavAlto");
                }
                else if (chkState == 3)
                {
                    ConfiginGtaV("GtavBaixo");
                }
                else
                {
                    MessageBox.Show("Selecione uma opção válida.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Current configuration not found {ex}");
            }
        }
        private void ConfiginGtaV(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\Commandline.txt";
            DialogResult dialog = this.folderBrowserDialog1.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                string destiny = folderBrowserDialog1.SelectedPath + "\\Commandline.txt";
                if (File.Exists(destiny))
                {
                    File.Copy(config, destiny, true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
                else
                {
                    var commandline = File.Create(destiny);
                    commandline.Close();
                    File.Copy(config, destiny, true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
            }
        }
        private void ConfiginFortnite(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\GameUserSettings.ini";
            string destiny = Environment.ExpandEnvironmentVariables("%localappdata%\\FortniteGame\\Saved\\Config\\WindowsClient\\GameUserSettings.ini");
            File.Copy(config, destiny, true);
            MessageBox.Show("Alteração feita com sucesso !");
        }
    }
}

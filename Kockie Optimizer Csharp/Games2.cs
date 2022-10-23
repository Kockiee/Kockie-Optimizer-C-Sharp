using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.VisualStudio.Services.Graph.GraphResourceIds;

namespace Kockie_Optimizer_Csharp
{
    public partial class Games2 : Form
    {
        public int chkState;
        public Games2()
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
            if (chkState == 0)
            {
                ConfiginWarzone("WzAlto");
            }
            else if (chkState == 1)
            {
                ConfiginWarzone("WzBaixo");
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida.");
            }
        }

        private void btnOT2_Click(object sender, EventArgs e)
        {
            if (chkState == 2)
            {
                ConfiginValorant("ValAlto");
            }
            else if (chkState == 3)
            {
                ConfiginValorant("ValBaixo");
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida.");
            }
        }

        private void ConfiginValorant(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\";
            folderBrowserDialog2.InitialDirectory = Application.LocalUserAppDataPath + "/Local/VALORANT/Saved/Config";
            DialogResult dialog = this.folderBrowserDialog2.ShowDialog();
            if (dialog == DialogResult.OK)
            {
                string destiny = folderBrowserDialog2.SelectedPath + "\\RiotUserSettings.ini";
                string destiny2 = folderBrowserDialog2.SelectedPath + "\\GameUserSettings.ini";
                if (File.Exists(destiny) && File.Exists(destiny2))
                {
                    File.Copy(config + "GameUserSettings.ini", destiny2, true);
                    File.Copy(config + "RiotUserSettings.ini", destiny, true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
                else
                {
                    var settingsFile = File.Create(destiny);
                    var settingsFile2 = File.Create(destiny2);
                    settingsFile2.Close();
                    settingsFile.Close();
                    File.Copy(config + "GameUserSettings.ini", destiny2, true);
                    File.Copy(config + "RiotUserSettings.ini", destiny, true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
            }
        }

        private void ConfiginWarzone(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\config.cfg";
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Call of Duty Modern Warfare\\players"))
            {
                string destiny = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Call of Duty Modern Warfare\\players\\config.cfg";
                if (File.Exists(destiny))
                {
                    File.Copy(config, destiny, true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
                else
                {
                    File.Create(destiny);
                    File.Copy(config, destiny, true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
            }
            else
            {
                DialogResult dialog = this.folderBrowserDialog1.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    string destiny = folderBrowserDialog1.SelectedPath + "\\config.cfg";
                    if (File.Exists(destiny))
                    {
                        File.Copy(config, destiny, true);
                        MessageBox.Show("Alteração feita com sucesso !");
                    }
                    else
                    {
                        var settingsFile = File.Create(destiny);
                        settingsFile.Close();
                        File.Copy(config, destiny, true);
                        MessageBox.Show("Alteração feita com sucesso !");
                    }
                }
            }
        }

        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }
    }
}

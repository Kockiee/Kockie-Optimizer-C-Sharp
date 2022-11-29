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
    public partial class Games4 : Form
    {
        public int chkState;
        public Games4()
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

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 5;
        }

        private void btnOT1_Click(object sender, EventArgs e)
        {
            if (chkState == 0)
            {
                configinLOL("LolAlto");
            }
            else if (chkState == 1)
            {
                configinLOL("LolBaixo");
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
                configinMinecraft("MineAlto");
            }
            else if (chkState == 3)
            {
                configinMinecraft("MineBaixo");
            }
            else if (chkState == 5)
            {
                configinMinecraft("MineVeryLow");
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida.");
            }
        }

        private void configinLOL(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\game.cfg";
            if (Directory.Exists("C:\\Riot Games\\League of Legends\\Config"))
            {
                string destiny = "C:\\Riot Games\\League of Legends\\Config\\game.cfg";
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
            else
            {
                DialogResult dialog = this.folderBrowserDialog1.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    string destiny = folderBrowserDialog1.SelectedPath + "\\game.cfg";
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

        private void configinMinecraft(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\options.txt";
            string config1 = Application.StartupPath + $"Files\\{localoftheconfiguration}\\optionsof.txt";
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\.minecraft"))
            {
                string destiny = $"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\.minecraft";
                if (File.Exists(destiny + "\\options.txt") && File.Exists(destiny + "optionof.txt"))
                {
                    File.Copy(config, destiny + "\\options.txt", true);
                    File.Copy(config1, destiny + "\\optionsof.txt", true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
                else
                {
                    var settingsFile = File.Create(destiny + "\\options.txt");
                    var settingsFile1 = File.Create(destiny + "\\optionsof.txt");
                    settingsFile.Close();
                    settingsFile1.Close();
                    File.Copy(config, destiny + "\\options.txt", true);
                    File.Copy(config1, destiny + "\\optionsof.txt", true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
            }
            else
            {
                DialogResult dialog = this.folderBrowserDialog2.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    string destiny = folderBrowserDialog2.SelectedPath;
                    if (File.Exists(destiny + "\\options.txt") && File.Exists(destiny + "optionof.txt"))
                    {
                        File.Copy(config, destiny + "\\options.txt", true);
                        File.Copy(config1, destiny + "\\optionsof.txt", true);
                        MessageBox.Show("Alteração feita com sucesso !");
                    }
                    else
                    {
                        var settingsFile = File.Create(destiny + "\\options.txt");
                        var settingsFile1 = File.Create(destiny + "\\optionsof.txt");
                        settingsFile.Close();
                        settingsFile1.Close();
                        File.Copy(config, destiny + "\\options.txt", true);
                        File.Copy(config1, destiny + "\\optionsof.txt", true);
                        MessageBox.Show("Alteração feita com sucesso !");
                    }
                }
            }
        }
    }
}

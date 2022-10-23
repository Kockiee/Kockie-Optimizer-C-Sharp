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
    public partial class Games3 : Form
    {
        public int chkState;
        public Games3()
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
                configinCSGO("CsAlto");
            }
            else if (chkState == 1)
            {
                configinCSGO("CsBaixo");
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
                configinRoblox("RobloxAlto");
            }
            else if (chkState == 3)
            {
                configinRoblox("RobloxBaixo");
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida.");
            }
        }

        private void configinCSGO(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\boost.cfg";
            MessageBox.Show("Após a modificação ser concluída, vá para as propriedades do jogo (na Steam) e nas opções de inicialização, adicione a seguinte linha de comando: +exec boost.cfg");
            if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\csgo\\cfg"))
            {
                string destiny = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "\\Steam\\steamapps\\common\\Counter-Strike Global Offensive\\csgo\\cfg";
                if (File.Exists(destiny + "\\boost.cfg"))
                {
                    File.Copy(config, destiny + "\\boost.cfg", true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
                else
                {
                    var settingsFile = File.Create(destiny + "\\boost.cfg");
                    settingsFile.Close();
                    File.Copy(config, destiny + "\\boost.cfg", true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
            }
            else
            {
                DialogResult dialog = this.folderBrowserDialog1.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    string destiny = folderBrowserDialog1.SelectedPath + "\\boost.cfg";
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
        private void configinRoblox(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\GlobalBasicSettings_13.xml";
            if (Directory.Exists(Application.LocalUserAppDataPath + "\\Local\\Roblox"))
            {
                string destiny = Application.LocalUserAppDataPath + "\\Local\\Roblox";
                if (File.Exists(destiny + "\\GlobalBasicSettings_13.xml"))
                {
                    File.Copy(config, destiny + "\\GlobalBasicSettings_13.xml", true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
                else
                {
                    var settingsFile = File.Create(destiny + "\\GlobalBasicSettings_13.xml");
                    settingsFile.Close();
                    File.Copy(config, destiny + "\\GlobalBasicSettings_13.xml", true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
            }
            else
            {
                DialogResult dialog = this.folderBrowserDialog1.ShowDialog();
                if (dialog == DialogResult.OK)
                {
                    string destiny = folderBrowserDialog1.SelectedPath + "\\GlobalBasicSettings_13.xml";
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
    }
}

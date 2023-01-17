using Microsoft.Win32;
using System.Security.Principal;

namespace Kockie_Optimizer_Csharp
{
    public partial class Games5 : Form
    {
        public int chkState;
        string user = Environment.UserName;
        public Games5()
        {
            InitializeComponent();
        }

        private void chk1_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 1;
        }

        private void chk2_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 2;
        }

        private void chk3_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 3;
        }

        private void chk4_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 4;
        }

        private void chk5_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 5;
        }

        private void chk6_CheckedChanged(object sender, EventArgs e)
        {
            chkState = 6;
        }

        private void btnOT1_Click(object sender, EventArgs e)
        {
            Registry.SetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\cod.exe\PerfOptions", "CpuPriorityClass", 3, RegistryValueKind.DWord);
            if (chkState == 1)
            {
                configinWarzone2("Wz2Alto");
            }
            else if (chkState == 2)
            {
                configinWarzone2("Wz2Baixo");
            }
            else if (chkState == 3)
            {
                configinWarzone2("Wz2Verylow");
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida.");
            }
        }

        private void btnOT2_Click(object sender, EventArgs e)
        {
            if (chkState == 4)
            {
                configinPUBG("PubgAlto");
            }
            else if (chkState == 5)
            {
                configinPUBG("PubgBaixo");
            }
            else if (chkState == 6)
            {
                configinPUBG("PubgVerylow");
            }
        }

        private void configinWarzone2(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\options.3.cod22.cst";
            if (Directory.Exists($@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Call of Duty/players"))
            {
                string destiny = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}/Call of Duty/players/options.3.cod22.cst";
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
                    string destiny = folderBrowserDialog1.SelectedPath + "\\options.3.cod22.cst";
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

        private void configinPUBG(string localoftheconfiguration)
        {

            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\GameUserSettings.ini";
            if (Directory.Exists($"C:\\Users\\{user}\\AppData\\Local\\TslGame\\Saved\\Config\\WindowsNoEditor"))
            {
                string destiny = $"C:\\Users\\{user}\\AppData\\Local\\TslGame\\Saved\\Config\\WindowsNoEditor\\GameUserSettings.ini";
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
                    string destiny = folderBrowserDialog1.SelectedPath + @"/GameUserSettings.ini";
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

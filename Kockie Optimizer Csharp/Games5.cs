using Microsoft.Win32;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace Kockie_Optimizer_Csharp
{
    public partial class Games5 : Form
    {
        public int chkState;
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
                configinWarzone2("Wz2VeryLow");
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida.");
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
    }
}

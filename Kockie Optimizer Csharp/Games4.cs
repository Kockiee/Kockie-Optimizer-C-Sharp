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

        private void btnOT1_Click(object sender, EventArgs e)
        {
            if (chkState == 0)
            {
                configinLOL("");
            }
            else if (chkState == 1)
            {
                configinLOL("");
            }
            else
            {
                MessageBox.Show("Selecione uma opção válida.");
            }
        }

        private void configinLOL(string localoftheconfiguration)
        {
            string config = Application.StartupPath + $"Files\\{localoftheconfiguration}\\game.cfg";
            MessageBox.Show("Após a modificação ser concluída, vá para as propriedades do jogo (na Steam) e nas opções de inicialização, adicione a seguinte linha de comando: +exec game.cfg");
            if (Directory.Exists("C:\\Riot Games\\League of Legends\\Config"))
            {
                string destiny = "C:\\Riot Games\\League of Legends\\Config";
                if (File.Exists(destiny + "\\game.cfg"))
                {
                    File.Copy(config, destiny + "\\game.cfg", true);
                    MessageBox.Show("Alteração feita com sucesso !");
                }
                else
                {
                    var settingsFile = File.Create(destiny + "\\game.cfg");
                    settingsFile.Close();
                    File.Copy(config, destiny + "\\game.cfg", true);
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
    }
}

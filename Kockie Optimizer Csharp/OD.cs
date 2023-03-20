using Kockie_Optimizer_Csharp.Classes;

namespace Kockie_Optimizer_Csharp
{
    public partial class OD : Form
    {
        public OD()
        {
            InitializeComponent();
        }

        private void btnVerifyFiles_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Para parar o processo basta fechar a janela do cmd";
            Utilities.RunCommandWithWindow("sfc /scannow");
            lblInfo.Text = "";
        }

        private void btnVerifyFilesSystem_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Para parar o process basta\n fechar a janela do cmd";
            Utilities.RunCommandWithWindow("DISM /Online /Cleanup-image /Restorehealth");
            lblInfo.Text = "";
        }

        private void btnSimpleClean_Click(object sender, EventArgs e)
        {
            Utilities.RunCommandWithWindow("cleanmgr.exe /d c:");
        }

        private void btnAdvancedClean_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "Para parar o process basta\n fechar a janela do cmd";
            Utilities.RunCommandWithWindow("cleanmgr.exe /sageset:1");
            Utilities.RunCommand("cleanmgr.exe /sagerun:1");
            lblInfo.Text = "";
        }
    }
}

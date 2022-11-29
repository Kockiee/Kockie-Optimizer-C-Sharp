using System.Diagnostics;
using System.Windows.Forms;
using Kockie_Optimizer_Csharp.Classes;

namespace Kockie_Optimizer_Csharp
{

    public partial class KockieOptimizer : Form
    {
        public KockieOptimizer()
        {
            InitializeComponent();
        }

        public int FormGameState;

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        private void HideNB()
        {
            btnBack.Hide();
            btnNext.Hide();
        }

        private void lblOtimizarWindows_Click(object sender, EventArgs e)
        {
            HideNB();
            Utilities.OpenForm<OW>();
        }

        private void lblOtimizarJogos_Click(object sender, EventArgs e)
        {
            btnNext.Show();
            btnBack.Show();
            Utilities.OpenForm<Games1>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideNB();
            Utilities.OpenForm<InitialPnl>();
            var os = System.Environment.OSVersion.ToString();
            lblOS.Text = os;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDATE.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(FormGameState == 0)
            {
                Utilities.OpenForm<Games2>();
                FormGameState = 1;
            }
            else if(FormGameState == 1)
            {
                Utilities.OpenForm<Games3>();
                FormGameState = 2;
            }
            else if (FormGameState == 2)
            {
                Utilities.OpenForm<Games4>();
                FormGameState = 3;
            }
            else if (FormGameState == 3)
            {
                Utilities.OpenForm<Games5>();
                FormGameState = 4;
            }
            else if (FormGameState == 4)
            {
                Utilities.OpenForm<Games1>();
                FormGameState = 0;
            }
            else
            {
                Utilities.OpenForm<Games2>();
                FormGameState = 1;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (FormGameState == 0)
            {
                Utilities.OpenForm<Games5>();
                FormGameState = 4;
            }
            else if (FormGameState == 1)
            {
                Utilities.OpenForm<Games1>();
                FormGameState = 0;
            }
            else if (FormGameState == 2)
            {
                Utilities.OpenForm<Games2>();
                FormGameState = 1;
            }
            else if (FormGameState == 3)
            {
                Utilities.OpenForm<Games3>();
                FormGameState = 2;
            }
            else if (FormGameState == 4)
            {
                Utilities.OpenForm<Games4>();
                FormGameState = 3;
            }
            else if (FormGameState == 5)
            {
                Utilities.OpenForm<Games5>();
                FormGameState = 4;
            }
            else
            {
                Utilities.OpenForm<Games4>();
                FormGameState = 3;
            }
        }

        private void btnYoutube_Click(object sender, EventArgs e)
        {
            string target = "https://www.youtube.com/channel/UCYLoDNZ_JOE_W1LFkSTLWpQ";
            Process.Start(new ProcessStartInfo { FileName = target, UseShellExecute = true });
        }

        private void btnGithub_Click(object sender, EventArgs e)
        {
            string target = "https://github.com/Kockiee";
            Process.Start(new ProcessStartInfo { FileName = target, UseShellExecute = true });
        }

        private void btnDiscord_Click(object sender, EventArgs e)
        {
            string target = "https://discord.gg/kAe7f285JE";
            Process.Start(new ProcessStartInfo { FileName = target, UseShellExecute = true });
        }

        private void lblUtilities_Click(object sender, EventArgs e)
        {
            HideNB();
            Utilities.OpenForm<UT>();
        }

        private void lblOtimizarJogos_MouseHover(object sender, EventArgs e)
        {
            lblOtimizarJogos.ForeColor = Color.Silver;
        }

        private void lblOtimizarWindows_MouseHover(object sender, EventArgs e)
        {
            lblOtimizarWindows.ForeColor = Color.Silver;
        }

        private void lblUtilities_MouseHover(object sender, EventArgs e)
        {
            lblUtilities.ForeColor = Color.Silver;
        }

        private void lblOtimizarJogos_MouseLeave(object sender, EventArgs e)
        {
            lblOtimizarJogos.ForeColor = Color.White;
        }

        private void lblUtilities_MouseLeave(object sender, EventArgs e)
        {
            lblUtilities.ForeColor = Color.White;
        }

        private void lblOtimizarWindows_MouseLeave(object sender, EventArgs e)
        {
            lblOtimizarWindows.ForeColor = Color.White;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            HideNB();
            Utilities.OpenForm<InitialPnl>();
        }
    }
}
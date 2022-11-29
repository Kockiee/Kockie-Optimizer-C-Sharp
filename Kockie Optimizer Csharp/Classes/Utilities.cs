using Microsoft.VisualStudio.Services.CircuitBreaker;
using Microsoft.Win32;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.ServiceProcess;

namespace Kockie_Optimizer_Csharp.Classes
{
    internal static class Utilities
    {
        //Methods taken from: https://github.com/hellzerg/optimizer/blob/master/Optimizer/Utilities.cs

        internal static void DisableHibernation()
        {
            Process.Start("cmd.exe", "powercfg -h off");
        }

        internal static void EnableHibernation()
        {
            Process.Start("cmd.exe", "powercfg -h on");
        }

        internal static bool ServiceExists(string serviceName)
        {
            return ServiceController.GetServices().Any(serviceController => serviceController.ServiceName.Equals(serviceName));
        }

        internal static void StopService(string serviceName)
        {
            if (ServiceExists(serviceName))
            {
                ServiceController sc = new ServiceController(serviceName);
                if (sc.CanStop)
                {
                    sc.Stop();
                }
            }
        }

        internal static void StartService(string serviceName)
        {
            if (ServiceExists(serviceName))
            {
                ServiceController sc = new ServiceController(serviceName);
                sc.Start();
            }
        }

        internal static void RunCommand(string command)
        {
            using (Process p = new Process())
            {
                p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.Verb = "runas";
                p.StartInfo.Arguments = $"/c {command}";
                p.StartInfo.CreateNoWindow = true;
                p.Start();
                p.WaitForExit();
                p.Close();
            }
        }

        internal static void OpenForm<MiForm>() where MiForm : Form, new()
        {
            Panel pnlMain = Application.OpenForms["KockieOptimizer"].Controls["pnlMain"] as Panel;
            Form formulario;
            formulario = pnlMain.Controls.OfType<MiForm>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                pnlMain.Controls.Add(formulario);
                pnlMain.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        internal static void DisableHPET()
        {
            RunCommand("bcdedit /deletevalue useplatformclock");
            Thread.Sleep(500);
            RunCommand("bcdedit /set disabledynamictick yes");
            MessageBox.Show("Hpet Desativado !");
        }

        internal static void EnableHPET()
        {
            RunCommand("bcdedit /set useplatformclock true");
            Thread.Sleep(500);
            RunCommand("bcdedit /set disabledynamictick no");
            MessageBox.Show("Hpet Ativado !");
        }

        internal static void RestartExplorer()
        {
            const string explorer = "explorer.exe";
            string explorerPath = string.Format("{0}\\{1}", Environment.GetEnvironmentVariable("WINDIR"), explorer);

            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if (string.Compare(process.MainModule.FileName, explorerPath, StringComparison.OrdinalIgnoreCase) == 0)
                    {
                        process.Kill();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            Thread.Sleep(TimeSpan.FromSeconds(1));
            Process.Start(explorer);
        }

        internal static void TryDeleteRegistryValue(bool localMachine, string path, string valueName)
        {
            try
            {
                if (localMachine) Registry.LocalMachine.OpenSubKey(path, true).DeleteValue(valueName, false);
                if (!localMachine) Registry.CurrentUser.OpenSubKey(path, true).DeleteValue(valueName, false);
            }
            catch
            {
                MessageBox.Show("One or several records cannot be modified");
            }
        }

        public static RegistryKey OpenSubKeyWritable(this RegistryKey registryKey, string subkeyName, RegistryRights? rights = null)
        {
            RegistryKey subKey = null;

            if (rights == null)
                subKey = registryKey.OpenSubKey(subkeyName, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl);
            else
                subKey = registryKey.OpenSubKey(subkeyName, RegistryKeyPermissionCheck.ReadWriteSubTree, rights.Value);

            if (subKey == null)
            {
                MessageBox.Show("Sub Key Not Found");
            }

            return subKey;
        }

        internal static void RestoreWindowsPhotoViewer()
        {
            const string PHOTO_VIEWER_SHELL_COMMAND =
                @"%SystemRoot%\System32\rundll32.exe ""%ProgramFiles%\Windows Photo Viewer\PhotoViewer.dll"", ImageView_Fullscreen %1";
            const string PHOTO_VIEWER_CLSID = "{FFE2A43C-56B9-4bf5-9A79-CC6D4285608A}";

            Registry.SetValue(@"HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open", "MuiVerb", "@photoviewer.dll,-3043");
            Registry.SetValue(
                @"HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open\command", valueName: null,
                PHOTO_VIEWER_SHELL_COMMAND, RegistryValueKind.ExpandString
            );
            Registry.SetValue(@"HKEY_CLASSES_ROOT\Applications\photoviewer.dll\shell\open\DropTarget", "Clsid", PHOTO_VIEWER_CLSID);

            string[] imageTypes = { "Paint.Picture", "giffile", "jpegfile", "pngfile" };
            foreach (string type in imageTypes)
            {
                Registry.SetValue(
                    $@"HKEY_CLASSES_ROOT\{type}\shell\open\command", valueName: null,
                    PHOTO_VIEWER_SHELL_COMMAND, RegistryValueKind.ExpandString
                );
                Registry.SetValue($@"HKEY_CLASSES_ROOT\{type}\shell\open\DropTarget", "Clsid", PHOTO_VIEWER_CLSID);
            }
        }

        internal static void UnlockAllCores()
        {
            try
            {
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Power\PowerSettings\54533251-82be-4824-96c1-47b60b740d00\0cc5b647-c1df-4637-891a-dec35c318583", "ValueMax", 0, RegistryValueKind.DWord);
                Registry.SetValue(@"HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\Power\PowerSettings\54533251-82be-4824-96c1-47b60b740d00\0cc5b647-c1df-4637-891a-dec35c318583", "ValueMin", 0, RegistryValueKind.DWord);
            }
            catch { }
        }
    }
}

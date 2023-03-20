namespace Kockie_Optimizer_Csharp
{
    partial class OD
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnVerifyFiles = new Guna.UI2.WinForms.Guna2Button();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnVerifyFilesSystem = new Guna.UI2.WinForms.Guna2Button();
            lblInfo = new Guna.UI2.WinForms.Guna2HtmlLabel();
            btnSimpleClean = new Guna.UI2.WinForms.Guna2Button();
            btnAdvancedClean = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // btnVerifyFiles
            // 
            btnVerifyFiles.BackColor = Color.Transparent;
            btnVerifyFiles.BorderRadius = 3;
            btnVerifyFiles.DisabledState.BorderColor = Color.DarkGray;
            btnVerifyFiles.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVerifyFiles.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVerifyFiles.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVerifyFiles.FillColor = Color.CornflowerBlue;
            btnVerifyFiles.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerifyFiles.ForeColor = Color.White;
            btnVerifyFiles.Location = new Point(270, 158);
            btnVerifyFiles.Name = "btnVerifyFiles";
            btnVerifyFiles.PressedColor = Color.FromArgb(128, 128, 255);
            btnVerifyFiles.ShadowDecoration.BorderRadius = 10;
            btnVerifyFiles.ShadowDecoration.Depth = 5;
            btnVerifyFiles.ShadowDecoration.Enabled = true;
            btnVerifyFiles.Size = new Size(189, 45);
            btnVerifyFiles.TabIndex = 4;
            btnVerifyFiles.Tag = "Verifica e corrige arquivos corrompidos.";
            btnVerifyFiles.Text = "Verificar arquivos";
            btnVerifyFiles.Click += btnVerifyFiles_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Mula R Black", 24F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.ForeColor = SystemColors.Control;
            guna2HtmlLabel1.Location = new Point(145, 12);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(439, 47);
            guna2HtmlLabel1.TabIndex = 15;
            guna2HtmlLabel1.Text = "Otimizações para o Windows";
            // 
            // btnVerifyFilesSystem
            // 
            btnVerifyFilesSystem.BackColor = Color.Transparent;
            btnVerifyFilesSystem.BorderRadius = 3;
            btnVerifyFilesSystem.DisabledState.BorderColor = Color.DarkGray;
            btnVerifyFilesSystem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnVerifyFilesSystem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnVerifyFilesSystem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnVerifyFilesSystem.FillColor = Color.CornflowerBlue;
            btnVerifyFilesSystem.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVerifyFilesSystem.ForeColor = Color.White;
            btnVerifyFilesSystem.Location = new Point(270, 95);
            btnVerifyFilesSystem.Name = "btnVerifyFilesSystem";
            btnVerifyFilesSystem.PressedColor = Color.FromArgb(128, 128, 255);
            btnVerifyFilesSystem.ShadowDecoration.BorderRadius = 10;
            btnVerifyFilesSystem.ShadowDecoration.Depth = 5;
            btnVerifyFilesSystem.ShadowDecoration.Enabled = true;
            btnVerifyFilesSystem.Size = new Size(189, 57);
            btnVerifyFilesSystem.TabIndex = 16;
            btnVerifyFilesSystem.Tag = "Verifica e corrige o sistema de arquivos do windows";
            btnVerifyFilesSystem.Text = "Verificar sistema de arquivos";
            btnVerifyFilesSystem.Click += btnVerifyFilesSystem_Click;
            // 
            // lblInfo
            // 
            lblInfo.BackColor = Color.Transparent;
            lblInfo.Font = new Font("Mula Bold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblInfo.ForeColor = SystemColors.Control;
            lblInfo.Location = new Point(124, 369);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(3, 2);
            lblInfo.TabIndex = 17;
            lblInfo.Text = null;
            // 
            // btnSimpleClean
            // 
            btnSimpleClean.BackColor = Color.Transparent;
            btnSimpleClean.BorderRadius = 3;
            btnSimpleClean.DisabledState.BorderColor = Color.DarkGray;
            btnSimpleClean.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSimpleClean.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSimpleClean.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSimpleClean.FillColor = Color.CornflowerBlue;
            btnSimpleClean.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSimpleClean.ForeColor = Color.White;
            btnSimpleClean.Location = new Point(270, 209);
            btnSimpleClean.Name = "btnSimpleClean";
            btnSimpleClean.PressedColor = Color.FromArgb(128, 128, 255);
            btnSimpleClean.ShadowDecoration.BorderRadius = 10;
            btnSimpleClean.ShadowDecoration.Depth = 5;
            btnSimpleClean.ShadowDecoration.Enabled = true;
            btnSimpleClean.Size = new Size(189, 45);
            btnSimpleClean.TabIndex = 18;
            btnSimpleClean.Tag = "Verifica e corrige o sistema de arquivos do windows";
            btnSimpleClean.Text = "Limpeza simples";
            btnSimpleClean.Click += btnSimpleClean_Click;
            // 
            // btnAdvancedClean
            // 
            btnAdvancedClean.BackColor = Color.Transparent;
            btnAdvancedClean.BorderRadius = 3;
            btnAdvancedClean.DisabledState.BorderColor = Color.DarkGray;
            btnAdvancedClean.DisabledState.CustomBorderColor = Color.DarkGray;
            btnAdvancedClean.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnAdvancedClean.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnAdvancedClean.FillColor = Color.CornflowerBlue;
            btnAdvancedClean.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdvancedClean.ForeColor = Color.White;
            btnAdvancedClean.Location = new Point(270, 260);
            btnAdvancedClean.Name = "btnAdvancedClean";
            btnAdvancedClean.PressedColor = Color.FromArgb(128, 128, 255);
            btnAdvancedClean.ShadowDecoration.BorderRadius = 10;
            btnAdvancedClean.ShadowDecoration.Depth = 5;
            btnAdvancedClean.ShadowDecoration.Enabled = true;
            btnAdvancedClean.Size = new Size(189, 45);
            btnAdvancedClean.TabIndex = 19;
            btnAdvancedClean.Tag = "Verifica e corrige o sistema de arquivos do windows";
            btnAdvancedClean.Text = "Limpeza Avançada";
            btnAdvancedClean.Click += btnAdvancedClean_Click;
            // 
            // OD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(37, 37, 37);
            ClientSize = new Size(755, 487);
            Controls.Add(btnAdvancedClean);
            Controls.Add(btnSimpleClean);
            Controls.Add(lblInfo);
            Controls.Add(btnVerifyFilesSystem);
            Controls.Add(guna2HtmlLabel1);
            Controls.Add(btnVerifyFiles);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OD";
            Text = "OD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnVerifyFiles;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button btnVerifyFilesSystem;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblInfo;
        private Guna.UI2.WinForms.Guna2Button btnSimpleClean;
        private Guna.UI2.WinForms.Guna2Button btnAdvancedClean;
    }
}
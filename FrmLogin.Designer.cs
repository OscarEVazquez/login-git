namespace login_git
{
    partial class FrmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PnlBarraAccion = new Panel();
            PtbMinimizarVentana = new PictureBox();
            PtbCerrarVentana = new PictureBox();
            TxtUsuario = new TextBox();
            LblUsuario = new Label();
            LblContraseña = new Label();
            TxtContraseña = new TextBox();
            LlblRecordarContraseña = new LinkLabel();
            ChbRecordarUsuario = new CheckBox();
            BtnLogin = new Button();
            PtbLogo = new PictureBox();
            PnlBarraAccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PtbMinimizarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PtbCerrarVentana).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PtbLogo).BeginInit();
            SuspendLayout();
            // 
            // PnlBarraAccion
            // 
            PnlBarraAccion.BackColor = Color.FromArgb(162, 148, 249);
            PnlBarraAccion.Controls.Add(PtbMinimizarVentana);
            PnlBarraAccion.Controls.Add(PtbCerrarVentana);
            PnlBarraAccion.Dock = DockStyle.Top;
            PnlBarraAccion.Location = new Point(0, 0);
            PnlBarraAccion.Name = "PnlBarraAccion";
            PnlBarraAccion.Size = new Size(303, 34);
            PnlBarraAccion.TabIndex = 0;
            PnlBarraAccion.MouseMove += PnlBarraAccion_MouseMove;
            // 
            // PtbMinimizarVentana
            // 
            PtbMinimizarVentana.Image = Properties.Resources.minimize_118918;
            PtbMinimizarVentana.Location = new Point(220, 10);
            PtbMinimizarVentana.Name = "PtbMinimizarVentana";
            PtbMinimizarVentana.Size = new Size(26, 17);
            PtbMinimizarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            PtbMinimizarVentana.TabIndex = 10;
            PtbMinimizarVentana.TabStop = false;
            // 
            // PtbCerrarVentana
            // 
            PtbCerrarVentana.Image = Properties.Resources.cross_icon_icons_com_48317;
            PtbCerrarVentana.Location = new Point(260, 10);
            PtbCerrarVentana.Name = "PtbCerrarVentana";
            PtbCerrarVentana.Size = new Size(26, 17);
            PtbCerrarVentana.SizeMode = PictureBoxSizeMode.Zoom;
            PtbCerrarVentana.TabIndex = 9;
            PtbCerrarVentana.TabStop = false;
            // 
            // TxtUsuario
            // 
            TxtUsuario.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            TxtUsuario.Location = new Point(28, 202);
            TxtUsuario.Name = "TxtUsuario";
            TxtUsuario.Size = new Size(235, 27);
            TxtUsuario.TabIndex = 1;
            // 
            // LblUsuario
            // 
            LblUsuario.AutoSize = true;
            LblUsuario.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            LblUsuario.Location = new Point(28, 179);
            LblUsuario.Name = "LblUsuario";
            LblUsuario.Size = new Size(62, 20);
            LblUsuario.TabIndex = 2;
            LblUsuario.Text = "Usuario";
            // 
            // LblContraseña
            // 
            LblContraseña.AutoSize = true;
            LblContraseña.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            LblContraseña.Location = new Point(28, 244);
            LblContraseña.Name = "LblContraseña";
            LblContraseña.Size = new Size(86, 20);
            LblContraseña.TabIndex = 4;
            LblContraseña.Text = "Contraseña";
            // 
            // TxtContraseña
            // 
            TxtContraseña.Font = new Font("Yu Gothic UI Semibold", 11.25F, FontStyle.Bold);
            TxtContraseña.Location = new Point(28, 267);
            TxtContraseña.Name = "TxtContraseña";
            TxtContraseña.Size = new Size(235, 27);
            TxtContraseña.TabIndex = 3;
            TxtContraseña.UseSystemPasswordChar = true;
            // 
            // LlblRecordarContraseña
            // 
            LlblRecordarContraseña.AutoSize = true;
            LlblRecordarContraseña.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LlblRecordarContraseña.Location = new Point(75, 430);
            LlblRecordarContraseña.Name = "LlblRecordarContraseña";
            LlblRecordarContraseña.Size = new Size(157, 17);
            LlblRecordarContraseña.TabIndex = 5;
            LlblRecordarContraseña.TabStop = true;
            LlblRecordarContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // ChbRecordarUsuario
            // 
            ChbRecordarUsuario.AutoSize = true;
            ChbRecordarUsuario.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChbRecordarUsuario.Location = new Point(28, 311);
            ChbRecordarUsuario.Name = "ChbRecordarUsuario";
            ChbRecordarUsuario.Size = new Size(119, 25);
            ChbRecordarUsuario.TabIndex = 6;
            ChbRecordarUsuario.Text = "Recordarme";
            ChbRecordarUsuario.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.FromArgb(229, 217, 242);
            BtnLogin.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnLogin.ForeColor = SystemColors.ControlText;
            BtnLogin.Location = new Point(28, 366);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(235, 35);
            BtnLogin.TabIndex = 7;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            // 
            // PtbLogo
            // 
            PtbLogo.Image = Properties.Resources.vip_diamond_icon_263920;
            PtbLogo.Location = new Point(94, 71);
            PtbLogo.Name = "PtbLogo";
            PtbLogo.Size = new Size(106, 96);
            PtbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            PtbLogo.TabIndex = 8;
            PtbLogo.TabStop = false;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(205, 193, 255);
            ClientSize = new Size(303, 463);
            Controls.Add(PtbLogo);
            Controls.Add(BtnLogin);
            Controls.Add(ChbRecordarUsuario);
            Controls.Add(LlblRecordarContraseña);
            Controls.Add(LblContraseña);
            Controls.Add(TxtContraseña);
            Controls.Add(LblUsuario);
            Controls.Add(TxtUsuario);
            Controls.Add(PnlBarraAccion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmLogin";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            PnlBarraAccion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PtbMinimizarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)PtbCerrarVentana).EndInit();
            ((System.ComponentModel.ISupportInitialize)PtbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlBarraAccion;
        private TextBox TxtUsuario;
        private Label LblUsuario;
        private Label LblContraseña;
        private TextBox TxtContraseña;
        private LinkLabel LlblRecordarContraseña;
        private CheckBox ChbRecordarUsuario;
        private Button BtnLogin;
        private PictureBox PtbLogo;
        private PictureBox PtbMinimizarVentana;
        private PictureBox PtbCerrarVentana;
    }
}

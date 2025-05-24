namespace UNC_FF
{
    partial class LoginPainel
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPainel));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.FecharLogo = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.LogoImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.UsuarioLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.SenhaLogin = new Guna.UI2.WinForms.Guna2TextBox();
            this.LoginButon = new Guna.UI2.WinForms.Guna2Button();
            this.LabelVerificação = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 15;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ResizeForm = false;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.White;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FecharLogo
            // 
            this.FecharLogo.BackColor = System.Drawing.Color.Transparent;
            this.FecharLogo.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.FecharLogo.HoverState.ImageSize = new System.Drawing.Size(32, 32);
            this.FecharLogo.Image = ((System.Drawing.Image)(resources.GetObject("FecharLogo.Image")));
            this.FecharLogo.ImageOffset = new System.Drawing.Point(0, 0);
            this.FecharLogo.ImageRotate = 0F;
            this.FecharLogo.ImageSize = new System.Drawing.Size(32, 32);
            this.FecharLogo.Location = new System.Drawing.Point(421, 12);
            this.FecharLogo.Name = "FecharLogo";
            this.FecharLogo.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.FecharLogo.Size = new System.Drawing.Size(39, 37);
            this.FecharLogo.TabIndex = 2;
            this.FecharLogo.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // LogoImage
            // 
            this.LogoImage.BackColor = System.Drawing.Color.Black;
            this.LogoImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogoImage.BackgroundImage")));
            this.LogoImage.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.LogoImage.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.LogoImage.Image = ((System.Drawing.Image)(resources.GetObject("LogoImage.Image")));
            this.LogoImage.ImageOffset = new System.Drawing.Point(0, 0);
            this.LogoImage.ImageRotate = 0F;
            this.LogoImage.Location = new System.Drawing.Point(185, 49);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.LogoImage.Size = new System.Drawing.Size(116, 99);
            this.LogoImage.TabIndex = 3;
            this.LogoImage.Click += new System.EventHandler(this.guna2ImageButton2_Click);
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.BorderColor = System.Drawing.Color.White;
            this.UsuarioLogin.BorderRadius = 3;
            this.UsuarioLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UsuarioLogin.DefaultText = "";
            this.UsuarioLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.UsuarioLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.UsuarioLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsuarioLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.UsuarioLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsuarioLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsuarioLogin.ForeColor = System.Drawing.Color.Black;
            this.UsuarioLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.UsuarioLogin.Location = new System.Drawing.Point(141, 157);
            this.UsuarioLogin.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.PlaceholderForeColor = System.Drawing.Color.Black;
            this.UsuarioLogin.PlaceholderText = "Usuário";
            this.UsuarioLogin.SelectedText = "";
            this.UsuarioLogin.Size = new System.Drawing.Size(200, 30);
            this.UsuarioLogin.TabIndex = 4;
            this.UsuarioLogin.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // SenhaLogin
            // 
            this.SenhaLogin.BorderColor = System.Drawing.Color.White;
            this.SenhaLogin.BorderRadius = 3;
            this.SenhaLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SenhaLogin.DefaultText = "";
            this.SenhaLogin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SenhaLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SenhaLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SenhaLogin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SenhaLogin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SenhaLogin.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.SenhaLogin.ForeColor = System.Drawing.Color.Black;
            this.SenhaLogin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SenhaLogin.Location = new System.Drawing.Point(141, 199);
            this.SenhaLogin.Margin = new System.Windows.Forms.Padding(6);
            this.SenhaLogin.Name = "SenhaLogin";
            this.SenhaLogin.PlaceholderForeColor = System.Drawing.Color.Black;
            this.SenhaLogin.PlaceholderText = "Senha";
            this.SenhaLogin.SelectedText = "";
            this.SenhaLogin.Size = new System.Drawing.Size(200, 30);
            this.SenhaLogin.TabIndex = 5;
            this.SenhaLogin.UseSystemPasswordChar = true;
            this.SenhaLogin.TextChanged += new System.EventHandler(this.guna2TextBox2_TextChanged);
            // 
            // LoginButon
            // 
            this.LoginButon.BorderColor = System.Drawing.Color.Transparent;
            this.LoginButon.BorderRadius = 3;
            this.LoginButon.BorderThickness = 1;
            this.LoginButon.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.LoginButon.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.LoginButon.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.LoginButon.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.LoginButon.FillColor = System.Drawing.Color.Teal;
            this.LoginButon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoginButon.ForeColor = System.Drawing.Color.Black;
            this.LoginButon.Location = new System.Drawing.Point(152, 250);
            this.LoginButon.Name = "LoginButon";
            this.LoginButon.Size = new System.Drawing.Size(180, 45);
            this.LoginButon.TabIndex = 6;
            this.LoginButon.Text = "Login";
            this.LoginButon.Click += new System.EventHandler(this.LoginButon_Click_1);
            // 
            // LabelVerificação
            // 
            this.LabelVerificação.BackColor = System.Drawing.Color.Transparent;
            this.LabelVerificação.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelVerificação.Location = new System.Drawing.Point(12, 300);
            this.LabelVerificação.Name = "LabelVerificação";
            this.LabelVerificação.Size = new System.Drawing.Size(33, 15);
            this.LabelVerificação.TabIndex = 7;
            this.LabelVerificação.Text = "Status";
            // 
            // LoginPainel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(472, 327);
            this.Controls.Add(this.LabelVerificação);
            this.Controls.Add(this.LoginButon);
            this.Controls.Add(this.SenhaLogin);
            this.Controls.Add(this.UsuarioLogin);
            this.Controls.Add(this.LogoImage);
            this.Controls.Add(this.FecharLogo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "LoginPainel";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton FecharLogo;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ImageButton LogoImage;
        private Guna.UI2.WinForms.Guna2TextBox UsuarioLogin;
        private Guna.UI2.WinForms.Guna2TextBox SenhaLogin;
        private Guna.UI2.WinForms.Guna2Button LoginButon;
        private Guna.UI2.WinForms.Guna2HtmlLabel LabelVerificação;
    }
}


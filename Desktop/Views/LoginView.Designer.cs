namespace Desktop.Views
{
    partial class LoginView
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
            pictureBox1 = new PictureBox();
            CheckVerContraseña = new CheckBox();
            TxtPassword = new TextBox();
            label2 = new Label();
            TxtEmail = new TextBox();
            label1 = new Label();
            BtnIniciarSesion = new Button();
            BtnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.freepik_br_5b61cdb2_68b3_4ea5_848f_688cebd8b9b5;
            pictureBox1.Location = new Point(-1, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(361, 298);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // CheckVerContraseña
            // 
            CheckVerContraseña.AutoSize = true;
            CheckVerContraseña.Location = new Point(504, 162);
            CheckVerContraseña.Margin = new Padding(1);
            CheckVerContraseña.Name = "CheckVerContraseña";
            CheckVerContraseña.Size = new Size(103, 19);
            CheckVerContraseña.TabIndex = 28;
            CheckVerContraseña.Text = "Ver contraseña";
            CheckVerContraseña.UseVisualStyleBackColor = true;
            CheckVerContraseña.CheckedChanged += CheckVerContraseña_CheckedChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(461, 119);
            TxtPassword.Margin = new Padding(1);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(210, 23);
            TxtPassword.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(378, 122);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 26;
            label2.Text = "Password:";
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(461, 55);
            TxtEmail.Margin = new Padding(1);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(210, 23);
            TxtEmail.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(399, 58);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 24;
            label1.Text = "Email:";
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.Location = new Point(411, 217);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(120, 23);
            BtnIniciarSesion.TabIndex = 29;
            BtnIniciarSesion.Text = "Inicias Sesion";
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            BtnIniciarSesion.Click += BtnIniciarSesion_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(566, 217);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(120, 23);
            BtnCancelar.TabIndex = 30;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 300);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(CheckVerContraseña);
            Controls.Add(TxtPassword);
            Controls.Add(label2);
            Controls.Add(TxtEmail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private CheckBox CheckVerContraseña;
        private TextBox TxtPassword;
        private Label label2;
        private TextBox TxtEmail;
        private Label label1;
        private Button BtnIniciarSesion;
        private Button BtnCancelar;
    }
}
namespace CapaPresentacion.Vistas
{
    partial class Login
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
            User = new Label();
            Password = new Label();
            RegisterButton = new Button();
            LoginButton = new Button();
            textBoxUser = new TextBox();
            textBoxPassword = new TextBox();
            SuspendLayout();
            // 
            // User
            // 
            User.AutoSize = true;
            User.Location = new Point(59, 48);
            User.Name = "User";
            User.Size = new Size(47, 15);
            User.TabIndex = 0;
            User.Text = "Usuario";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.Location = new Point(60, 126);
            Password.Name = "Password";
            Password.Size = new Size(67, 15);
            Password.TabIndex = 1;
            Password.Text = "Contraseña";
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(59, 221);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(75, 23);
            RegisterButton.TabIndex = 2;
            RegisterButton.Text = "Registrarse\r\n";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(297, 221);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Ingresar";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // textBoxUser
            // 
            textBoxUser.Location = new Point(233, 45);
            textBoxUser.Name = "textBoxUser";
            textBoxUser.Size = new Size(139, 23);
            textBoxUser.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(233, 123);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(139, 23);
            textBoxPassword.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(593, 475);
            Controls.Add(textBoxUser);
            Controls.Add(LoginButton);
            Controls.Add(RegisterButton);
            Controls.Add(Password);
            Controls.Add(User);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label User;
        private Label Password;
        private Button RegisterButton;
        private Button LoginButton;
        private TextBox textBoxUser;
        private TextBox textBoxPassword;
    }
}
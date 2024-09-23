namespace CapaPresentacion.Vistas
{
    partial class HomePage
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
            dataGridViewUsuarios = new DataGridView();
            buttonMaxAge = new Button();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            tabHome = new TabControl();
            tabPageHome = new TabPage();
            comboBoxG = new ComboBox();
            buttonRefresc = new Button();
            tabPage2 = new TabPage();
            btnRegister = new Button();
            textBoxTelefono = new TextBox();
            textBoxPrimerApellido = new TextBox();
            textBoxEdad = new TextBox();
            textBoxDireccion = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxSegundoNombre = new TextBox();
            textBoxPrimerNombre = new TextBox();
            textBoxSegundoApellido = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label11 = new Label();
            label12 = new Label();
            comboBoxGenero = new ComboBox();
            textBoxNumeroDocumento = new TextBox();
            label13 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).BeginInit();
            tabHome.SuspendLayout();
            tabPageHome.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsuarios
            // 
            dataGridViewUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsuarios.Location = new Point(8, 64);
            dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            dataGridViewUsuarios.Size = new Size(929, 231);
            dataGridViewUsuarios.TabIndex = 0;
            // 
            // buttonMaxAge
            // 
            buttonMaxAge.Location = new Point(166, 381);
            buttonMaxAge.Name = "buttonMaxAge";
            buttonMaxAge.Size = new Size(61, 32);
            buttonMaxAge.TabIndex = 1;
            buttonMaxAge.Text = "Calcular";
            buttonMaxAge.UseVisualStyleBackColor = true;
            buttonMaxAge.Click += buttonMaxAge_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 339);
            label1.Name = "label1";
            label1.Size = new Size(208, 15);
            label1.TabIndex = 2;
            label1.Text = "Seleccione que genero desea contar  : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(403, 339);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 4;
            label2.Text = "Promedio de Edad :";
            // 
            // button1
            // 
            button1.Location = new Point(386, 374);
            button1.Name = "button1";
            button1.Size = new Size(155, 39);
            button1.TabIndex = 3;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(694, 339);
            label3.Name = "label3";
            label3.Size = new Size(243, 15);
            label3.TabIndex = 6;
            label3.Text = "Pulsar Para saber quien es la persona mayor: ";
            // 
            // button2
            // 
            button2.Location = new Point(730, 374);
            button2.Name = "button2";
            button2.Size = new Size(155, 39);
            button2.TabIndex = 5;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabHome
            // 
            tabHome.Controls.Add(tabPageHome);
            tabHome.Controls.Add(tabPage2);
            tabHome.Location = new Point(12, 35);
            tabHome.Name = "tabHome";
            tabHome.SelectedIndex = 0;
            tabHome.Size = new Size(959, 577);
            tabHome.TabIndex = 8;
            // 
            // tabPageHome
            // 
            tabPageHome.BackColor = Color.Transparent;
            tabPageHome.Controls.Add(comboBoxG);
            tabPageHome.Controls.Add(buttonRefresc);
            tabPageHome.Controls.Add(dataGridViewUsuarios);
            tabPageHome.Controls.Add(button1);
            tabPageHome.Controls.Add(label3);
            tabPageHome.Controls.Add(buttonMaxAge);
            tabPageHome.Controls.Add(button2);
            tabPageHome.Controls.Add(label1);
            tabPageHome.Controls.Add(label2);
            tabPageHome.Location = new Point(4, 24);
            tabPageHome.Name = "tabPageHome";
            tabPageHome.Padding = new Padding(3);
            tabPageHome.Size = new Size(951, 549);
            tabPageHome.TabIndex = 0;
            tabPageHome.Text = "Home";
            // 
            // comboBoxG
            // 
            comboBoxG.FormattingEnabled = true;
            comboBoxG.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxG.Location = new Point(17, 383);
            comboBoxG.Name = "comboBoxG";
            comboBoxG.Size = new Size(119, 23);
            comboBoxG.TabIndex = 27;
            // 
            // buttonRefresc
            // 
            buttonRefresc.Location = new Point(862, 6);
            buttonRefresc.Name = "buttonRefresc";
            buttonRefresc.Size = new Size(75, 23);
            buttonRefresc.TabIndex = 9;
            buttonRefresc.Text = "Actualizar";
            buttonRefresc.UseVisualStyleBackColor = true;
            buttonRefresc.Click += buttonRefresc_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnRegister);
            tabPage2.Controls.Add(textBoxTelefono);
            tabPage2.Controls.Add(textBoxPrimerApellido);
            tabPage2.Controls.Add(textBoxEdad);
            tabPage2.Controls.Add(textBoxDireccion);
            tabPage2.Controls.Add(textBoxCorreo);
            tabPage2.Controls.Add(textBoxSegundoNombre);
            tabPage2.Controls.Add(textBoxPrimerNombre);
            tabPage2.Controls.Add(textBoxSegundoApellido);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(comboBoxGenero);
            tabPage2.Controls.Add(textBoxNumeroDocumento);
            tabPage2.Controls.Add(label13);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(951, 549);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Registrar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(567, 411);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(166, 59);
            btnRegister.TabIndex = 44;
            btnRegister.Text = "Registrarse";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click_2;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(612, 51);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(121, 23);
            textBoxTelefono.TabIndex = 43;
            // 
            // textBoxPrimerApellido
            // 
            textBoxPrimerApellido.Location = new Point(212, 220);
            textBoxPrimerApellido.Name = "textBoxPrimerApellido";
            textBoxPrimerApellido.Size = new Size(121, 23);
            textBoxPrimerApellido.TabIndex = 42;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(612, 223);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.Size = new Size(121, 23);
            textBoxEdad.TabIndex = 41;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(612, 153);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(121, 23);
            textBoxDireccion.TabIndex = 40;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(612, 100);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(121, 23);
            textBoxCorreo.TabIndex = 39;
            // 
            // textBoxSegundoNombre
            // 
            textBoxSegundoNombre.Location = new Point(212, 150);
            textBoxSegundoNombre.Name = "textBoxSegundoNombre";
            textBoxSegundoNombre.Size = new Size(121, 23);
            textBoxSegundoNombre.TabIndex = 38;
            // 
            // textBoxPrimerNombre
            // 
            textBoxPrimerNombre.Location = new Point(212, 97);
            textBoxPrimerNombre.Name = "textBoxPrimerNombre";
            textBoxPrimerNombre.Size = new Size(121, 23);
            textBoxPrimerNombre.TabIndex = 37;
            // 
            // textBoxSegundoApellido
            // 
            textBoxSegundoApellido.Location = new Point(212, 284);
            textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            textBoxSegundoApellido.Size = new Size(121, 23);
            textBoxSegundoApellido.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(486, 290);
            label10.Name = "label10";
            label10.Size = new Size(39, 15);
            label10.TabIndex = 35;
            label10.Text = "Gnero";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(86, 287);
            label9.Name = "label9";
            label9.Size = new Size(101, 15);
            label9.TabIndex = 34;
            label9.Text = "Segundo Apellido";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(486, 226);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 33;
            label8.Text = "Edad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 223);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 32;
            label7.Text = "Primer Apellido";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 156);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 31;
            label6.Text = "Direccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 103);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 30;
            label5.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 153);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 29;
            label4.Text = "Segundo Nombre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(86, 100);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 28;
            label11.Text = "Primer Nombre";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(486, 54);
            label12.Name = "label12";
            label12.Size = new Size(52, 15);
            label12.TabIndex = 27;
            label12.Text = "Telefono";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            comboBoxGenero.Location = new Point(612, 284);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(121, 23);
            comboBoxGenero.TabIndex = 26;
            // 
            // textBoxNumeroDocumento
            // 
            textBoxNumeroDocumento.Location = new Point(212, 46);
            textBoxNumeroDocumento.Name = "textBoxNumeroDocumento";
            textBoxNumeroDocumento.Size = new Size(121, 23);
            textBoxNumeroDocumento.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(86, 49);
            label13.Name = "label13";
            label13.Size = new Size(117, 15);
            label13.TabIndex = 24;
            label13.Text = "Número Documento";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 937);
            Controls.Add(tabHome);
            Name = "HomePage";
            Text = "HomePage";
            Load += HomePage_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsuarios).EndInit();
            tabHome.ResumeLayout(false);
            tabPageHome.ResumeLayout(false);
            tabPageHome.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsuarios;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private Button buttonMaxAge;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;
        private DataGridView dataGridViewMaxAge;
        private DataGridViewTextBoxColumn NombreColumn;
        private DataGridViewTextBoxColumn Apellido;
        private TabControl tabHome;
        private TabPage tabPageHome;
        private TabPage tabPage2;
        private Button btnRegister;
        private TextBox textBoxTelefono;
        private TextBox textBoxPrimerApellido;
        private TextBox textBoxEdad;
        private TextBox textBoxDireccion;
        private TextBox textBoxCorreo;
        private TextBox textBoxSegundoNombre;
        private TextBox textBoxPrimerNombre;
        private TextBox textBoxSegundoApellido;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label11;
        private Label label12;
        private ComboBox comboBoxGenero;
        private TextBox textBoxNumeroDocumento;
        private Label label13;
        private Button buttonRefresc;
        private DataGridView dataGridViewAvarage;
        private ComboBox comboBoxG;
    }
}
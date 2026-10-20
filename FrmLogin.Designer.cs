namespace TRABAJO_P
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            label1 = new Label();
            label2 = new Label();
            txtusuario = new TextBox();
            txtcontrasena = new TextBox();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            mostrarcontra = new Button();
            label5 = new Label();
            label6 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 195);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 0;
            label1.Text = "USUARIO (3 letras";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 278);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 1;
            label2.Text = "CONTRASEÑA:";
            // 
            // txtusuario
            // 
            txtusuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtusuario.Location = new Point(200, 195);
            txtusuario.Name = "txtusuario";
            txtusuario.Size = new Size(229, 33);
            txtusuario.TabIndex = 2;
            // 
            // txtcontrasena
            // 
            txtcontrasena.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcontrasena.Location = new Point(200, 270);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.Size = new Size(229, 33);
            txtcontrasena.TabIndex = 3;
            txtcontrasena.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(146, 147);
            label3.Name = "label3";
            label3.Size = new Size(170, 25);
            label3.TabIndex = 4;
            label3.Text = "INICIO DE SESIÓN";
            // 
            // button1
            // 
            button1.Location = new Point(49, 354);
            button1.Name = "button1";
            button1.Size = new Size(148, 88);
            button1.TabIndex = 5;
            button1.Text = "INGRESAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 354);
            button2.Name = "button2";
            button2.Size = new Size(148, 88);
            button2.TabIndex = 6;
            button2.Text = "SALIR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(59, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 132);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(49, 220);
            label4.Name = "label4";
            label4.Size = new Size(86, 25);
            label4.TabIndex = 8;
            label4.Text = "mínimo):";
            // 
            // mostrarcontra
            // 
            mostrarcontra.Location = new Point(200, 309);
            mostrarcontra.Name = "mostrarcontra";
            mostrarcontra.Size = new Size(22, 20);
            mostrarcontra.TabIndex = 9;
            mostrarcontra.UseVisualStyleBackColor = true;
            mostrarcontra.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(228, 313);
            label5.Name = "label5";
            label5.Size = new Size(111, 15);
            label5.TabIndex = 10;
            label5.Text = "Mostrar Contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(127, 468);
            label6.Name = "label6";
            label6.Size = new Size(187, 21);
            label6.TabIndex = 11;
            label6.Text = "¿Olvidaste tu contraseña?";
            label6.Click += label6_Click;
            // 
            // button4
            // 
            button4.Location = new Point(329, 468);
            button4.Name = "button4";
            button4.Size = new Size(39, 23);
            button4.TabIndex = 12;
            button4.Text = "Sí";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 513);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(mostrarcontra);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(txtcontrasena);
            Controls.Add(txtusuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Text = "FrmLogin";
            FormClosing += FrmLogin_FormClosing;
            Load += FrmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusuario;
        private TextBox txtcontrasena;
        private Label label3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label4;
        private Button mostrarcontra;
        private Label label5;
        private Label label6;
        private Button button4;
    }
}
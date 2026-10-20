namespace TRABAJO_P
{
    partial class FrmGestionExpedientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGestionExpedientes));
            lblregistrodeexpedientes = new Label();
            lblcodigo = new Label();
            lblnumerodedocumento = new Label();
            lblremitente = new Label();
            lblasunto = new Label();
            lbltipodedocumento = new Label();
            txtcodigo = new TextBox();
            txtremitente = new TextBox();
            txtasunto = new TextBox();
            txtnumerodeldocumento = new TextBox();
            cbtipodedocumento = new ComboBox();
            bttvalidar = new Button();
            bttregistrar = new Button();
            txasalida = new DataGridView();
            dgvcodigo = new DataGridViewTextBoxColumn();
            dgvremitente = new DataGridViewTextBoxColumn();
            dgvasunto = new DataGridViewTextBoxColumn();
            dgvtipodedocumento = new DataGridViewTextBoxColumn();
            dgvnumerodeldocumento = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)txasalida).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblregistrodeexpedientes
            // 
            lblregistrodeexpedientes.AutoSize = true;
            lblregistrodeexpedientes.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblregistrodeexpedientes.Location = new Point(82, 25);
            lblregistrodeexpedientes.Name = "lblregistrodeexpedientes";
            lblregistrodeexpedientes.Size = new Size(312, 32);
            lblregistrodeexpedientes.TabIndex = 0;
            lblregistrodeexpedientes.Text = "REGISTRO DE EXPEDIENTES";
            // 
            // lblcodigo
            // 
            lblcodigo.AutoSize = true;
            lblcodigo.Font = new Font("Segoe UI", 12F);
            lblcodigo.Location = new Point(46, 94);
            lblcodigo.Name = "lblcodigo";
            lblcodigo.Size = new Size(73, 21);
            lblcodigo.TabIndex = 1;
            lblcodigo.Text = "CÓDIGO:";
            // 
            // lblnumerodedocumento
            // 
            lblnumerodedocumento.AutoSize = true;
            lblnumerodedocumento.Font = new Font("Segoe UI", 12F);
            lblnumerodedocumento.Location = new Point(46, 235);
            lblnumerodedocumento.Name = "lblnumerodedocumento";
            lblnumerodedocumento.Size = new Size(212, 21);
            lblnumerodedocumento.TabIndex = 2;
            lblnumerodedocumento.Text = "NUMERO DEL DOCUMENTO:";
            lblnumerodedocumento.Click += label3_Click;
            // 
            // lblremitente
            // 
            lblremitente.AutoSize = true;
            lblremitente.Font = new Font("Segoe UI", 12F);
            lblremitente.Location = new Point(46, 126);
            lblremitente.Name = "lblremitente";
            lblremitente.Size = new Size(93, 21);
            lblremitente.TabIndex = 3;
            lblremitente.Text = "REMITENTE:";
            // 
            // lblasunto
            // 
            lblasunto.AutoSize = true;
            lblasunto.Font = new Font("Segoe UI", 12F);
            lblasunto.Location = new Point(46, 160);
            lblasunto.Name = "lblasunto";
            lblasunto.Size = new Size(74, 21);
            lblasunto.TabIndex = 4;
            lblasunto.Text = "ASUNTO:";
            // 
            // lbltipodedocumento
            // 
            lbltipodedocumento.AutoSize = true;
            lbltipodedocumento.Font = new Font("Segoe UI", 12F);
            lbltipodedocumento.Location = new Point(46, 193);
            lbltipodedocumento.Name = "lbltipodedocumento";
            lbltipodedocumento.Size = new Size(170, 21);
            lbltipodedocumento.TabIndex = 5;
            lbltipodedocumento.Text = "TIPO DE DOCUMENTO:";
            // 
            // txtcodigo
            // 
            txtcodigo.Font = new Font("Segoe UI", 12F);
            txtcodigo.Location = new Point(264, 91);
            txtcodigo.Name = "txtcodigo";
            txtcodigo.Size = new Size(196, 29);
            txtcodigo.TabIndex = 6;
            // 
            // txtremitente
            // 
            txtremitente.Font = new Font("Segoe UI", 12F);
            txtremitente.Location = new Point(264, 123);
            txtremitente.Name = "txtremitente";
            txtremitente.Size = new Size(196, 29);
            txtremitente.TabIndex = 7;
            // 
            // txtasunto
            // 
            txtasunto.Font = new Font("Segoe UI", 12F);
            txtasunto.Location = new Point(264, 158);
            txtasunto.Name = "txtasunto";
            txtasunto.Size = new Size(299, 29);
            txtasunto.TabIndex = 8;
            // 
            // txtnumerodeldocumento
            // 
            txtnumerodeldocumento.Font = new Font("Segoe UI", 12F);
            txtnumerodeldocumento.Location = new Point(264, 232);
            txtnumerodeldocumento.Name = "txtnumerodeldocumento";
            txtnumerodeldocumento.Size = new Size(196, 29);
            txtnumerodeldocumento.TabIndex = 9;
            txtnumerodeldocumento.TextChanged += txtnumerodeldocumento_TextChanged;
            // 
            // cbtipodedocumento
            // 
            cbtipodedocumento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbtipodedocumento.Font = new Font("Segoe UI", 12F);
            cbtipodedocumento.FormattingEnabled = true;
            cbtipodedocumento.Items.AddRange(new object[] { "DNI", "RUC" });
            cbtipodedocumento.Location = new Point(264, 193);
            cbtipodedocumento.Name = "cbtipodedocumento";
            cbtipodedocumento.Size = new Size(196, 29);
            cbtipodedocumento.TabIndex = 10;
            // 
            // bttvalidar
            // 
            bttvalidar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttvalidar.Location = new Point(593, 94);
            bttvalidar.Name = "bttvalidar";
            bttvalidar.Size = new Size(142, 68);
            bttvalidar.TabIndex = 11;
            bttvalidar.Text = "VALIDAR";
            bttvalidar.UseVisualStyleBackColor = true;
            bttvalidar.Click += bttvalidar_Click;
            // 
            // bttregistrar
            // 
            bttregistrar.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bttregistrar.Location = new Point(593, 193);
            bttregistrar.Name = "bttregistrar";
            bttregistrar.Size = new Size(142, 68);
            bttregistrar.TabIndex = 12;
            bttregistrar.Text = "REGISTRAR";
            bttregistrar.UseVisualStyleBackColor = true;
            bttregistrar.Click += bttregistrar_Click;
            // 
            // txasalida
            // 
            txasalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txasalida.Columns.AddRange(new DataGridViewColumn[] { dgvcodigo, dgvremitente, dgvasunto, dgvtipodedocumento, dgvnumerodeldocumento, Column1 });
            txasalida.Location = new Point(46, 278);
            txasalida.Name = "txasalida";
            txasalida.Size = new Size(689, 178);
            txasalida.TabIndex = 13;
            // 
            // dgvcodigo
            // 
            dgvcodigo.HeaderText = "CÓDIGO";
            dgvcodigo.Name = "dgvcodigo";
            // 
            // dgvremitente
            // 
            dgvremitente.HeaderText = "REMITENTE";
            dgvremitente.Name = "dgvremitente";
            // 
            // dgvasunto
            // 
            dgvasunto.HeaderText = "ASUNTO";
            dgvasunto.Name = "dgvasunto";
            // 
            // dgvtipodedocumento
            // 
            dgvtipodedocumento.HeaderText = "DNI/RUC";
            dgvtipodedocumento.Name = "dgvtipodedocumento";
            // 
            // dgvnumerodeldocumento
            // 
            dgvnumerodeldocumento.HeaderText = "NUMERO DEL DOCUMENTO";
            dgvnumerodeldocumento.Name = "dgvnumerodeldocumento";
            // 
            // Column1
            // 
            Column1.HeaderText = "VALIDACIÓN";
            Column1.Name = "Column1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(448, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(260, 76);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // FrmGestionExpedientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 489);
            Controls.Add(pictureBox1);
            Controls.Add(txasalida);
            Controls.Add(bttregistrar);
            Controls.Add(bttvalidar);
            Controls.Add(cbtipodedocumento);
            Controls.Add(txtnumerodeldocumento);
            Controls.Add(txtasunto);
            Controls.Add(txtremitente);
            Controls.Add(txtcodigo);
            Controls.Add(lbltipodedocumento);
            Controls.Add(lblasunto);
            Controls.Add(lblremitente);
            Controls.Add(lblnumerodedocumento);
            Controls.Add(lblcodigo);
            Controls.Add(lblregistrodeexpedientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmGestionExpedientes";
            Text = "FrmGestionExpedientes";
            FormClosing += FrmGestionExpedientes_FormClosing;
            Load += FrmGestionExpedientes_Load;
            ((System.ComponentModel.ISupportInitialize)txasalida).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblregistrodeexpedientes;
        private Label lblcodigo;
        private Label lblnumerodedocumento;
        private Label lblremitente;
        private Label lblasunto;
        private Label lbltipodedocumento;
        private TextBox txtcodigo;
        private TextBox txtremitente;
        private TextBox txtasunto;
        private TextBox txtnumerodeldocumento;
        private ComboBox cbtipodedocumento;
        private Button bttvalidar;
        private Button bttregistrar;
        private DataGridView txasalida;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn dgvcodigo;
        private DataGridViewTextBoxColumn dgvremitente;
        private DataGridViewTextBoxColumn dgvasunto;
        private DataGridViewTextBoxColumn dgvtipodedocumento;
        private DataGridViewTextBoxColumn dgvnumerodeldocumento;
        private DataGridViewTextBoxColumn Column1;
    }
}
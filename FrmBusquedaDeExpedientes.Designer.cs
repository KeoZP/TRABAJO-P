namespace TRABAJO_P
{
    partial class FrmBusquedaDeExpedientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaDeExpedientes));
            lblbusquedadeexpedientes = new Label();
            lblcodigoabuscar = new Label();
            txtcodigoabuscar = new TextBox();
            bttbuscar = new Button();
            bttordenarporcodigo = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            txasalida = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txasalida).BeginInit();
            SuspendLayout();
            // 
            // lblbusquedadeexpedientes
            // 
            lblbusquedadeexpedientes.AutoSize = true;
            lblbusquedadeexpedientes.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbusquedadeexpedientes.Location = new Point(50, 30);
            lblbusquedadeexpedientes.Name = "lblbusquedadeexpedientes";
            lblbusquedadeexpedientes.Size = new Size(327, 32);
            lblbusquedadeexpedientes.TabIndex = 0;
            lblbusquedadeexpedientes.Text = "BUSQUEDA DE EXPEDIENTES";
            lblbusquedadeexpedientes.Click += lblbusquedadeexpedientes_Click;
            // 
            // lblcodigoabuscar
            // 
            lblcodigoabuscar.AutoSize = true;
            lblcodigoabuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblcodigoabuscar.Location = new Point(12, 103);
            lblcodigoabuscar.Name = "lblcodigoabuscar";
            lblcodigoabuscar.Size = new Size(142, 25);
            lblcodigoabuscar.TabIndex = 1;
            lblcodigoabuscar.Text = "CÓDIGO O DNI:";
            // 
            // txtcodigoabuscar
            // 
            txtcodigoabuscar.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtcodigoabuscar.Location = new Point(160, 100);
            txtcodigoabuscar.Name = "txtcodigoabuscar";
            txtcodigoabuscar.Size = new Size(217, 33);
            txtcodigoabuscar.TabIndex = 2;
            // 
            // bttbuscar
            // 
            bttbuscar.Location = new Point(383, 103);
            bttbuscar.Name = "bttbuscar";
            bttbuscar.Size = new Size(68, 30);
            bttbuscar.TabIndex = 3;
            bttbuscar.Text = "BUSCAR";
            bttbuscar.UseVisualStyleBackColor = true;
            bttbuscar.Click += bttbuscar_Click;
            // 
            // bttordenarporcodigo
            // 
            bttordenarporcodigo.Location = new Point(457, 103);
            bttordenarporcodigo.Name = "bttordenarporcodigo";
            bttordenarporcodigo.Size = new Size(146, 30);
            bttordenarporcodigo.TabIndex = 4;
            bttordenarporcodigo.Text = "ORDENAR POR CÓDIGO";
            bttordenarporcodigo.UseVisualStyleBackColor = true;
            bttordenarporcodigo.Click += bttordenarporcodigo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(450, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 85);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(609, 103);
            button1.Name = "button1";
            button1.Size = new Size(69, 30);
            button1.TabIndex = 7;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txasalida
            // 
            txasalida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            txasalida.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            txasalida.Location = new Point(12, 150);
            txasalida.Name = "txasalida";
            txasalida.Size = new Size(666, 227);
            txasalida.TabIndex = 8;
            // 
            // Column1
            // 
            Column1.HeaderText = "CÓDIGO";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "DNI/RUC";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "REMITENTE";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "ASUNTO";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "FECHA";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "ESTADO";
            Column6.Name = "Column6";
            // 
            // FrmBusquedaDeExpedientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 462);
            Controls.Add(txasalida);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(bttordenarporcodigo);
            Controls.Add(bttbuscar);
            Controls.Add(txtcodigoabuscar);
            Controls.Add(lblcodigoabuscar);
            Controls.Add(lblbusquedadeexpedientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmBusquedaDeExpedientes";
            Text = "FrmBusquedaDeExpedientes";
            FormClosing += FrmBusquedaDeExpedientes_FormClosing;
            Load += FrmBusquedaDeExpedientes_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)txasalida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblbusquedadeexpedientes;
        private Label lblcodigoabuscar;
        private TextBox txtcodigoabuscar;
        private Button bttbuscar;
        private Button bttordenarporcodigo;
        private PictureBox pictureBox1;
        private Button button1;
        private DataGridView txasalida;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}
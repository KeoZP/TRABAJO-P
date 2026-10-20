namespace TRABAJO_P
{
    partial class FrmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            menuStrip1 = new MenuStrip();
            iNICIOToolStripMenuItem = new ToolStripMenuItem();
            iNICIODESESIÓNToolStripMenuItem = new ToolStripMenuItem();
            gESTIONDEEXPEDIENTESToolStripMenuItem = new ToolStripMenuItem();
            rEGISTRODEEXPEDIENTESToolStripMenuItem = new ToolStripMenuItem();
            bUSQUEDADEEXPEDIENTESToolStripMenuItem = new ToolStripMenuItem();
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1 = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { iNICIOToolStripMenuItem, gESTIONDEEXPEDIENTESToolStripMenuItem, bUSQUEDADEEXPEDIENTESToolStripMenuItem, sALIRToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(930, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iNICIOToolStripMenuItem
            // 
            iNICIOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { iNICIODESESIÓNToolStripMenuItem });
            iNICIOToolStripMenuItem.Name = "iNICIOToolStripMenuItem";
            iNICIOToolStripMenuItem.Size = new Size(54, 20);
            iNICIOToolStripMenuItem.Text = "INICIO";
            iNICIOToolStripMenuItem.Click += iNICIOToolStripMenuItem_Click;
            // 
            // iNICIODESESIÓNToolStripMenuItem
            // 
            iNICIODESESIÓNToolStripMenuItem.Name = "iNICIODESESIÓNToolStripMenuItem";
            iNICIODESESIÓNToolStripMenuItem.Size = new Size(168, 22);
            iNICIODESESIÓNToolStripMenuItem.Text = "INICIO DE SESIÓN";
            iNICIODESESIÓNToolStripMenuItem.Click += iNICIODESESIÓNToolStripMenuItem_Click;
            // 
            // gESTIONDEEXPEDIENTESToolStripMenuItem
            // 
            gESTIONDEEXPEDIENTESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { rEGISTRODEEXPEDIENTESToolStripMenuItem });
            gESTIONDEEXPEDIENTESToolStripMenuItem.Name = "gESTIONDEEXPEDIENTESToolStripMenuItem";
            gESTIONDEEXPEDIENTESToolStripMenuItem.Size = new Size(156, 20);
            gESTIONDEEXPEDIENTESToolStripMenuItem.Text = "GESTION DE EXPEDIENTES";
            gESTIONDEEXPEDIENTESToolStripMenuItem.Click += gESTIONDEEXPEDIENTESToolStripMenuItem_Click;
            // 
            // rEGISTRODEEXPEDIENTESToolStripMenuItem
            // 
            rEGISTRODEEXPEDIENTESToolStripMenuItem.Name = "rEGISTRODEEXPEDIENTESToolStripMenuItem";
            rEGISTRODEEXPEDIENTESToolStripMenuItem.Size = new Size(216, 22);
            rEGISTRODEEXPEDIENTESToolStripMenuItem.Text = "REGISTRO DE EXPEDIENTES";
            rEGISTRODEEXPEDIENTESToolStripMenuItem.Click += rEGISTRODEEXPEDIENTESToolStripMenuItem_Click;
            // 
            // bUSQUEDADEEXPEDIENTESToolStripMenuItem
            // 
            bUSQUEDADEEXPEDIENTESToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bUSQUEDADEEXPEDIENTESToolStripMenuItem1 });
            bUSQUEDADEEXPEDIENTESToolStripMenuItem.Name = "bUSQUEDADEEXPEDIENTESToolStripMenuItem";
            bUSQUEDADEEXPEDIENTESToolStripMenuItem.Size = new Size(117, 20);
            bUSQUEDADEEXPEDIENTESToolStripMenuItem.Text = "ADMINISTRACIÓN";
            // 
            // bUSQUEDADEEXPEDIENTESToolStripMenuItem1
            // 
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1.Name = "bUSQUEDADEEXPEDIENTESToolStripMenuItem1";
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1.Size = new Size(224, 22);
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1.Text = "BUSQUEDA DE EXPEDIENTES";
            bUSQUEDADEEXPEDIENTESToolStripMenuItem1.Click += bUSQUEDADEEXPEDIENTESToolStripMenuItem1_Click;
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(49, 20);
            sALIRToolStripMenuItem.Text = "SALIR";
            sALIRToolStripMenuItem.Click += sALIRToolStripMenuItem_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(930, 593);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 615);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenuPrincipal";
            Text = "Menu Principal";
            Load += FrmMenuPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem iNICIOToolStripMenuItem;
        private ToolStripMenuItem gESTIONDEEXPEDIENTESToolStripMenuItem;
        private ToolStripMenuItem bUSQUEDADEEXPEDIENTESToolStripMenuItem;
        private ToolStripMenuItem iNICIODESESIÓNToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private ToolStripMenuItem rEGISTRODEEXPEDIENTESToolStripMenuItem;
        private ToolStripMenuItem bUSQUEDADEEXPEDIENTESToolStripMenuItem1;
        protected internal PictureBox pictureBox1;
    }
}

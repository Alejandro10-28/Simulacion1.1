namespace Simulacion1._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlarriba = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxMaximizar = new System.Windows.Forms.PictureBox();
            this.pbxCerrar = new System.Windows.Forms.PictureBox();
            this.pntablero = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new ns1.BunifuGradientPanel();
            this.btnManto = new ns1.BunifuFlatButton();
            this.bunifuFlatButton1 = new ns1.BunifuFlatButton();
            this.btnPrueba2 = new ns1.BunifuFlatButton();
            this.pnlarriba.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).BeginInit();
            this.pntablero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dashboard.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlarriba
            // 
            this.pnlarriba.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.pnlarriba.Controls.Add(this.label1);
            this.pnlarriba.Controls.Add(this.pbxMaximizar);
            this.pnlarriba.Controls.Add(this.pbxCerrar);
            this.pnlarriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlarriba.Location = new System.Drawing.Point(0, 0);
            this.pnlarriba.Name = "pnlarriba";
            this.pnlarriba.Size = new System.Drawing.Size(612, 40);
            this.pnlarriba.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Menu";
            // 
            // pbxMaximizar
            // 
            this.pbxMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxMaximizar.Image = global::Simulacion1._1.Properties.Resources.minimizar__3_;
            this.pbxMaximizar.Location = new System.Drawing.Point(540, 7);
            this.pbxMaximizar.Name = "pbxMaximizar";
            this.pbxMaximizar.Size = new System.Drawing.Size(31, 30);
            this.pbxMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMaximizar.TabIndex = 3;
            this.pbxMaximizar.TabStop = false;
            this.pbxMaximizar.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pbxCerrar
            // 
            this.pbxCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxCerrar.Image = global::Simulacion1._1.Properties.Resources.cerrar__2_;
            this.pbxCerrar.Location = new System.Drawing.Point(577, 5);
            this.pbxCerrar.Name = "pbxCerrar";
            this.pbxCerrar.Size = new System.Drawing.Size(31, 30);
            this.pbxCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxCerrar.TabIndex = 0;
            this.pbxCerrar.TabStop = false;
            this.pbxCerrar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pntablero
            // 
            this.pntablero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(62)))), ((int)(((byte)(138)))));
            this.pntablero.Controls.Add(this.pictureBox1);
            this.pntablero.Controls.Add(this.dashboard);
            this.pntablero.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pntablero.Location = new System.Drawing.Point(0, 40);
            this.pntablero.Name = "pntablero";
            this.pntablero.Size = new System.Drawing.Size(612, 377);
            this.pntablero.TabIndex = 1;
            this.pntablero.Paint += new System.Windows.Forms.PaintEventHandler(this.pntablero_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Simulacion1._1.Properties.Resources.SIMULACION;
            this.pictureBox1.Location = new System.Drawing.Point(189, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(419, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard
            // 
            this.dashboard.Controls.Add(this.bunifuGradientPanel1);
            this.dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.dashboard.Location = new System.Drawing.Point(0, 0);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(183, 377);
            this.dashboard.TabIndex = 21;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnManto);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuFlatButton1);
            this.bunifuGradientPanel1.Controls.Add(this.btnPrueba2);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(199)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(202)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 6);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(155, 369);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // btnManto
            // 
            this.btnManto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnManto.BackColor = System.Drawing.Color.Transparent;
            this.btnManto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManto.BorderRadius = 0;
            this.btnManto.ButtonText = "Manto";
            this.btnManto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManto.DisabledColor = System.Drawing.Color.Black;
            this.btnManto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManto.Iconimage = global::Simulacion1._1.Properties.Resources.media;
            this.btnManto.Iconimage_right = null;
            this.btnManto.Iconimage_right_Selected = null;
            this.btnManto.Iconimage_Selected = null;
            this.btnManto.IconMarginLeft = 0;
            this.btnManto.IconMarginRight = 0;
            this.btnManto.IconRightVisible = true;
            this.btnManto.IconRightZoom = 0D;
            this.btnManto.IconVisible = true;
            this.btnManto.IconZoom = 70D;
            this.btnManto.IsTab = false;
            this.btnManto.Location = new System.Drawing.Point(4, 177);
            this.btnManto.Margin = new System.Windows.Forms.Padding(4);
            this.btnManto.Name = "btnManto";
            this.btnManto.Normalcolor = System.Drawing.Color.Transparent;
            this.btnManto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnManto.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnManto.selected = false;
            this.btnManto.Size = new System.Drawing.Size(151, 50);
            this.btnManto.TabIndex = 21;
            this.btnManto.Text = "Manto";
            this.btnManto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManto.Textcolor = System.Drawing.Color.White;
            this.btnManto.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManto.Click += new System.EventHandler(this.btnManto_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "   Promedio";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::Simulacion1._1.Properties.Resources.media;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 70D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(4, 119);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Black;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(151, 50);
            this.bunifuFlatButton1.TabIndex = 15;
            this.bunifuFlatButton1.Text = "   Promedio";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnPrueba2
            // 
            this.btnPrueba2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrueba2.BackColor = System.Drawing.Color.Transparent;
            this.btnPrueba2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPrueba2.BorderRadius = 0;
            this.btnPrueba2.ButtonText = "  Distribución       triangular";
            this.btnPrueba2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrueba2.DisabledColor = System.Drawing.Color.Black;
            this.btnPrueba2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba2.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrueba2.Iconimage = global::Simulacion1._1.Properties.Resources.precaucion;
            this.btnPrueba2.Iconimage_right = null;
            this.btnPrueba2.Iconimage_right_Selected = null;
            this.btnPrueba2.Iconimage_Selected = null;
            this.btnPrueba2.IconMarginLeft = 0;
            this.btnPrueba2.IconMarginRight = 0;
            this.btnPrueba2.IconRightVisible = true;
            this.btnPrueba2.IconRightZoom = 50D;
            this.btnPrueba2.IconVisible = true;
            this.btnPrueba2.IconZoom = 70D;
            this.btnPrueba2.IsTab = false;
            this.btnPrueba2.Location = new System.Drawing.Point(0, 235);
            this.btnPrueba2.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrueba2.Name = "btnPrueba2";
            this.btnPrueba2.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPrueba2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrueba2.OnHoverTextColor = System.Drawing.Color.Black;
            this.btnPrueba2.selected = false;
            this.btnPrueba2.Size = new System.Drawing.Size(166, 58);
            this.btnPrueba2.TabIndex = 20;
            this.btnPrueba2.Text = "  Distribución       triangular";
            this.btnPrueba2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrueba2.Textcolor = System.Drawing.Color.White;
            this.btnPrueba2.TextFont = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrueba2.Click += new System.EventHandler(this.btnPrueba2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 417);
            this.Controls.Add(this.pntablero);
            this.Controls.Add(this.pnlarriba);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlarriba.ResumeLayout(false);
            this.pnlarriba.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCerrar)).EndInit();
            this.pntablero.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dashboard.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlarriba;
        private System.Windows.Forms.Panel pntablero;
        private ns1.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.PictureBox pbxCerrar;
        private System.Windows.Forms.PictureBox pbxMaximizar;
        private ns1.BunifuFlatButton btnPrueba2;
        private System.Windows.Forms.Panel dashboard;
        private ns1.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label1;
        private ns1.BunifuFlatButton btnManto;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


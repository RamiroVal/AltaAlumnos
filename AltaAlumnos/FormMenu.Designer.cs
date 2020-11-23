namespace AltaAlumnos
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panelSubAlumnos = new System.Windows.Forms.Panel();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnIndividualA = new System.Windows.Forms.Button();
            this.btnAgregaA = new System.Windows.Forms.Button();
            this.btnAlumnos = new System.Windows.Forms.Button();
            this.panelSubCarrera = new System.Windows.Forms.Panel();
            this.btnConsultaC = new System.Windows.Forms.Button();
            this.btnIndividualC = new System.Windows.Forms.Button();
            this.btnAgregaC = new System.Windows.Forms.Button();
            this.btnCarreras = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelSubAlumnos.SuspendLayout();
            this.panelSubCarrera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(95)))));
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.panelSubAlumnos);
            this.panelMenu.Controls.Add(this.btnAlumnos);
            this.panelMenu.Controls.Add(this.panelSubCarrera);
            this.panelMenu.Controls.Add(this.btnCarreras);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSalir.Image = global::AltaAlumnos.Properties.Resources.cerrar_sesion__1_1;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 516);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(250, 45);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "  Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panelSubAlumnos
            // 
            this.panelSubAlumnos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.panelSubAlumnos.Controls.Add(this.btnConsultas);
            this.panelSubAlumnos.Controls.Add(this.btnIndividualA);
            this.panelSubAlumnos.Controls.Add(this.btnAgregaA);
            this.panelSubAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubAlumnos.Location = new System.Drawing.Point(0, 300);
            this.panelSubAlumnos.Name = "panelSubAlumnos";
            this.panelSubAlumnos.Size = new System.Drawing.Size(250, 120);
            this.panelSubAlumnos.TabIndex = 4;
            this.panelSubAlumnos.Visible = false;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultas.Image = global::AltaAlumnos.Properties.Resources.consultoria__1_;
            this.btnConsultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.Location = new System.Drawing.Point(0, 80);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultas.Size = new System.Drawing.Size(250, 40);
            this.btnConsultas.TabIndex = 2;
            this.btnConsultas.Text = "  Consulta Global";
            this.btnConsultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultas.UseVisualStyleBackColor = true;
            this.btnConsultas.Click += new System.EventHandler(this.btnConsultas_Click);
            // 
            // btnIndividualA
            // 
            this.btnIndividualA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIndividualA.FlatAppearance.BorderSize = 0;
            this.btnIndividualA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividualA.ForeColor = System.Drawing.Color.LightGray;
            this.btnIndividualA.Image = global::AltaAlumnos.Properties.Resources.lupa__1_;
            this.btnIndividualA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndividualA.Location = new System.Drawing.Point(0, 40);
            this.btnIndividualA.Name = "btnIndividualA";
            this.btnIndividualA.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIndividualA.Size = new System.Drawing.Size(250, 40);
            this.btnIndividualA.TabIndex = 1;
            this.btnIndividualA.Text = "  Consulta Individual";
            this.btnIndividualA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndividualA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIndividualA.UseVisualStyleBackColor = true;
            this.btnIndividualA.Click += new System.EventHandler(this.btnIndividualA_Click);
            // 
            // btnAgregaA
            // 
            this.btnAgregaA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregaA.FlatAppearance.BorderSize = 0;
            this.btnAgregaA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaA.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregaA.Image = global::AltaAlumnos.Properties.Resources.estudiante__2_;
            this.btnAgregaA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaA.Location = new System.Drawing.Point(0, 0);
            this.btnAgregaA.Name = "btnAgregaA";
            this.btnAgregaA.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregaA.Size = new System.Drawing.Size(250, 40);
            this.btnAgregaA.TabIndex = 0;
            this.btnAgregaA.Text = "  Agregar";
            this.btnAgregaA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregaA.UseVisualStyleBackColor = true;
            this.btnAgregaA.Click += new System.EventHandler(this.btnAgregaA_Click);
            // 
            // btnAlumnos
            // 
            this.btnAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlumnos.FlatAppearance.BorderSize = 0;
            this.btnAlumnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumnos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAlumnos.Location = new System.Drawing.Point(0, 255);
            this.btnAlumnos.Name = "btnAlumnos";
            this.btnAlumnos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnAlumnos.Size = new System.Drawing.Size(250, 45);
            this.btnAlumnos.TabIndex = 3;
            this.btnAlumnos.Text = "Alumno";
            this.btnAlumnos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlumnos.UseVisualStyleBackColor = true;
            this.btnAlumnos.Click += new System.EventHandler(this.btnAlumnos_Click);
            // 
            // panelSubCarrera
            // 
            this.panelSubCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(58)))));
            this.panelSubCarrera.Controls.Add(this.btnConsultaC);
            this.panelSubCarrera.Controls.Add(this.btnIndividualC);
            this.panelSubCarrera.Controls.Add(this.btnAgregaC);
            this.panelSubCarrera.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubCarrera.Location = new System.Drawing.Point(0, 135);
            this.panelSubCarrera.Name = "panelSubCarrera";
            this.panelSubCarrera.Size = new System.Drawing.Size(250, 120);
            this.panelSubCarrera.TabIndex = 2;
            this.panelSubCarrera.Visible = false;
            // 
            // btnConsultaC
            // 
            this.btnConsultaC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultaC.FlatAppearance.BorderSize = 0;
            this.btnConsultaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultaC.ForeColor = System.Drawing.Color.LightGray;
            this.btnConsultaC.Image = global::AltaAlumnos.Properties.Resources.consultoria__1_;
            this.btnConsultaC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaC.Location = new System.Drawing.Point(0, 80);
            this.btnConsultaC.Name = "btnConsultaC";
            this.btnConsultaC.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnConsultaC.Size = new System.Drawing.Size(250, 40);
            this.btnConsultaC.TabIndex = 2;
            this.btnConsultaC.Text = "  Consulta Global";
            this.btnConsultaC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultaC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultaC.UseVisualStyleBackColor = true;
            this.btnConsultaC.Click += new System.EventHandler(this.btnConsultaC_Click);
            // 
            // btnIndividualC
            // 
            this.btnIndividualC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIndividualC.FlatAppearance.BorderSize = 0;
            this.btnIndividualC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividualC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndividualC.ForeColor = System.Drawing.Color.LightGray;
            this.btnIndividualC.Image = global::AltaAlumnos.Properties.Resources.lupa__1_;
            this.btnIndividualC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndividualC.Location = new System.Drawing.Point(0, 40);
            this.btnIndividualC.Name = "btnIndividualC";
            this.btnIndividualC.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnIndividualC.Size = new System.Drawing.Size(250, 40);
            this.btnIndividualC.TabIndex = 1;
            this.btnIndividualC.Text = "  Consulta Individual";
            this.btnIndividualC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIndividualC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIndividualC.UseVisualStyleBackColor = true;
            this.btnIndividualC.Click += new System.EventHandler(this.btnIndividualC_Click);
            // 
            // btnAgregaC
            // 
            this.btnAgregaC.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAgregaC.FlatAppearance.BorderSize = 0;
            this.btnAgregaC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregaC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregaC.ForeColor = System.Drawing.Color.LightGray;
            this.btnAgregaC.Image = global::AltaAlumnos.Properties.Resources.agregar_archivo__1_;
            this.btnAgregaC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaC.Location = new System.Drawing.Point(0, 0);
            this.btnAgregaC.Name = "btnAgregaC";
            this.btnAgregaC.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnAgregaC.Size = new System.Drawing.Size(250, 40);
            this.btnAgregaC.TabIndex = 0;
            this.btnAgregaC.Text = "  Agregar";
            this.btnAgregaC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregaC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregaC.UseVisualStyleBackColor = true;
            this.btnAgregaC.Click += new System.EventHandler(this.btnAgregaC_Click);
            // 
            // btnCarreras
            // 
            this.btnCarreras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarreras.FlatAppearance.BorderSize = 0;
            this.btnCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarreras.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarreras.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCarreras.Location = new System.Drawing.Point(0, 90);
            this.btnCarreras.Name = "btnCarreras";
            this.btnCarreras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCarreras.Size = new System.Drawing.Size(250, 45);
            this.btnCarreras.TabIndex = 1;
            this.btnCarreras.Text = "Carrera";
            this.btnCarreras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarreras.UseVisualStyleBackColor = true;
            this.btnCarreras.Click += new System.EventHandler(this.btnCarreras_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.picLogo.Image = global::AltaAlumnos.Properties.Resources.Tec_Logo_2;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(250, 90);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(38)))), ((int)(((byte)(70)))));
            this.panelTitulo.Controls.Add(this.pictureBox2);
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(250, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(684, 80);
            this.panelTitulo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::AltaAlumnos.Properties.Resources.Logo_Tec_gris;
            this.pictureBox2.Location = new System.Drawing.Point(404, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(280, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitulo.Location = new System.Drawing.Point(29, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(66, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Home";
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(250, 80);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(684, 481);
            this.panelContenedor.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::AltaAlumnos.Properties.Resources.ITC_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(225, 127);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(257, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelSubAlumnos.ResumeLayout(false);
            this.panelSubCarrera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnCarreras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panelSubAlumnos;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnIndividualA;
        private System.Windows.Forms.Button btnAgregaA;
        private System.Windows.Forms.Button btnAlumnos;
        private System.Windows.Forms.Panel panelSubCarrera;
        private System.Windows.Forms.Button btnConsultaC;
        private System.Windows.Forms.Button btnIndividualC;
        private System.Windows.Forms.Button btnAgregaC;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
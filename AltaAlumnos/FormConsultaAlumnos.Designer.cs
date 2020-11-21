namespace AltaAlumnos
{
    partial class FormConsultaAlumnos
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
            this.gridAlumnos = new System.Windows.Forms.DataGridView();
            this.noControl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomAlumno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAlumnos
            // 
            this.gridAlumnos.AllowUserToAddRows = false;
            this.gridAlumnos.AllowUserToDeleteRows = false;
            this.gridAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noControl,
            this.nomAlumno,
            this.carrera,
            this.direccion,
            this.edad});
            this.gridAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAlumnos.Location = new System.Drawing.Point(0, 0);
            this.gridAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gridAlumnos.Name = "gridAlumnos";
            this.gridAlumnos.ReadOnly = true;
            this.gridAlumnos.RowHeadersWidth = 51;
            this.gridAlumnos.RowTemplate.Height = 24;
            this.gridAlumnos.Size = new System.Drawing.Size(815, 355);
            this.gridAlumnos.TabIndex = 0;
            // 
            // noControl
            // 
            this.noControl.HeaderText = "Número de Control";
            this.noControl.MinimumWidth = 6;
            this.noControl.Name = "noControl";
            this.noControl.ReadOnly = true;
            this.noControl.Width = 125;
            // 
            // nomAlumno
            // 
            this.nomAlumno.HeaderText = "Nombre del Alumno";
            this.nomAlumno.MinimumWidth = 6;
            this.nomAlumno.Name = "nomAlumno";
            this.nomAlumno.ReadOnly = true;
            this.nomAlumno.Width = 250;
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Carrera";
            this.carrera.MinimumWidth = 6;
            this.carrera.Name = "carrera";
            this.carrera.ReadOnly = true;
            this.carrera.Width = 125;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 210;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 50;
            // 
            // FormConsultaAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(815, 355);
            this.Controls.Add(this.gridAlumnos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormConsultaAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Alumnos";
            this.Load += new System.EventHandler(this.frmConsultaAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn noControl;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomAlumno;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
    }
}
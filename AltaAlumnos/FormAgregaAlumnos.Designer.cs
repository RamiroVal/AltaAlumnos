namespace AltaAlumnos
{
    partial class formPrincipal 
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
            this.components = new System.ComponentModel.Container();
            this.lblNoControl = new System.Windows.Forms.Label();
            this.txtNoControl = new System.Windows.Forms.TextBox();
            this.cmbCarreras = new System.Windows.Forms.ComboBox();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.numEdad = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNoControl
            // 
            this.lblNoControl.AutoSize = true;
            this.lblNoControl.Location = new System.Drawing.Point(19, 33);
            this.lblNoControl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoControl.Name = "lblNoControl";
            this.lblNoControl.Size = new System.Drawing.Size(60, 13);
            this.lblNoControl.TabIndex = 0;
            this.lblNoControl.Text = "No. Control";
            // 
            // txtNoControl
            // 
            this.txtNoControl.BackColor = System.Drawing.Color.White;
            this.txtNoControl.Location = new System.Drawing.Point(98, 31);
            this.txtNoControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNoControl.Name = "txtNoControl";
            this.txtNoControl.ReadOnly = true;
            this.txtNoControl.Size = new System.Drawing.Size(76, 20);
            this.txtNoControl.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtNoControl, "Número de Control");
            // 
            // cmbCarreras
            // 
            this.cmbCarreras.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCarreras.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCarreras.BackColor = System.Drawing.Color.White;
            this.cmbCarreras.FormattingEnabled = true;
            this.cmbCarreras.Location = new System.Drawing.Point(290, 31);
            this.cmbCarreras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbCarreras.Name = "cmbCarreras";
            this.cmbCarreras.Size = new System.Drawing.Size(92, 21);
            this.cmbCarreras.TabIndex = 0;
            this.cmbCarreras.Tag = "";
            this.toolTip1.SetToolTip(this.cmbCarreras, "Nombre de la Carrera");
            this.cmbCarreras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCarreras_KeyPress);
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(232, 33);
            this.lblCarrera.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(41, 13);
            this.lblCarrera.TabIndex = 4;
            this.lblCarrera.Text = "Carrera";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(19, 91);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(98, 89);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(284, 20);
            this.txtNombre.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtNombre, "Nombre del Alumno");
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtNombre.Validated += new System.EventHandler(this.txtNombre_Validated);
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(98, 123);
            this.txtDomicilio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(284, 20);
            this.txtDomicilio.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtDomicilio, "Domicilio del Alumno");
            this.txtDomicilio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDomicilio_KeyPress);
            this.txtDomicilio.Validated += new System.EventHandler(this.txtDomicilio_Validated);
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(19, 125);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 8;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(19, 165);
            this.lblEdad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 9;
            this.lblEdad.Text = "Edad";
            // 
            // numEdad
            // 
            this.numEdad.Location = new System.Drawing.Point(98, 163);
            this.numEdad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.numEdad.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numEdad.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numEdad.Name = "numEdad";
            this.numEdad.Size = new System.Drawing.Size(47, 20);
            this.numEdad.TabIndex = 3;
            this.numEdad.Tag = "";
            this.toolTip1.SetToolTip(this.numEdad, "Edad del Alumno");
            this.numEdad.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numEdad_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(47, 198);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 28);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btnGuardar, "Guardar Alumno");
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(161, 198);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(74, 28);
            this.btnLimpiar.TabIndex = 5;
            this.btnLimpiar.Text = "Limpiar";
            this.toolTip1.SetToolTip(this.btnLimpiar, "Limpia Campos");
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(275, 198);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(74, 28);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.toolTip1.SetToolTip(this.btnConsultar, "Consulta Alumnos");
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(406, 249);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.numEdad);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.txtDomicilio);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCarrera);
            this.Controls.Add(this.cmbCarreras);
            this.Controls.Add(this.txtNoControl);
            this.Controls.Add(this.lblNoControl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agrega Alumno";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numEdad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNoControl;
        private System.Windows.Forms.TextBox txtNoControl;
        private System.Windows.Forms.ComboBox cmbCarreras;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.NumericUpDown numEdad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}


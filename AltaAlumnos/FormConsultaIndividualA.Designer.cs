namespace AltaAlumnos
{
    partial class FormConsultaIndividualA
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
            this.components = new System.ComponentModel.Container();
            this.lblDato = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carrera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDato
            // 
            this.lblDato.AutoSize = true;
            this.lblDato.Location = new System.Drawing.Point(24, 29);
            this.lblDato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDato.Name = "lblDato";
            this.lblDato.Size = new System.Drawing.Size(109, 13);
            this.lblDato.TabIndex = 0;
            this.lblDato.Text = "Nombre o No. Control";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(441, 16);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(462, 40);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.toolTip1.SetToolTip(this.btnBuscar, "Buscar Alumno");
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clave,
            this.nombre,
            this.carrera,
            this.domicilio,
            this.edad});
            this.dataGridView1.Location = new System.Drawing.Point(27, 90);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(876, 122);
            this.dataGridView1.TabIndex = 3;
            // 
            // clave
            // 
            this.clave.HeaderText = "Clave";
            this.clave.MinimumWidth = 6;
            this.clave.Name = "clave";
            this.clave.ReadOnly = true;
            this.clave.Width = 80;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 300;
            // 
            // carrera
            // 
            this.carrera.HeaderText = "Carrera";
            this.carrera.MinimumWidth = 6;
            this.carrera.Name = "carrera";
            this.carrera.ReadOnly = true;
            this.carrera.Width = 150;
            // 
            // domicilio
            // 
            this.domicilio.HeaderText = "Domicilio";
            this.domicilio.MinimumWidth = 6;
            this.domicilio.Name = "domicilio";
            this.domicilio.ReadOnly = true;
            this.domicilio.Width = 250;
            // 
            // edad
            // 
            this.edad.HeaderText = "Edad";
            this.edad.MinimumWidth = 6;
            this.edad.Name = "edad";
            this.edad.ReadOnly = true;
            this.edad.Width = 40;
            // 
            // txtDato
            // 
            this.txtDato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDato.Location = new System.Drawing.Point(150, 26);
            this.txtDato.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(251, 20);
            this.txtDato.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtDato, "Ingrese Número de control\r\no Nombre del Alumno");
            this.txtDato.Validated += new System.EventHandler(this.txtDato_Validated);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // FormConsultaIndividualA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(928, 221);
            this.Controls.Add(this.txtDato);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblDato);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FormConsultaIndividualA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Alumno";
            this.Load += new System.EventHandler(this.FormConsultaIndividualA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDato;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn carrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilio;
        private System.Windows.Forms.DataGridViewTextBoxColumn edad;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
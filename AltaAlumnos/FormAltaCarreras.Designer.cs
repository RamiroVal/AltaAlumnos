﻿namespace AltaAlumnos
{
    partial class FormAltaCarreras
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
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grbEstatus = new System.Windows.Forms.GroupBox();
            this.btInactiva = new System.Windows.Forms.RadioButton();
            this.rbtActiva = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grbEstatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(16, 37);
            this.lblClave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(43, 17);
            this.lblClave.TabIndex = 0;
            this.lblClave.Text = "Clave";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(16, 89);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(58, 17);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(104, 33);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(132, 22);
            this.txtClave.TabIndex = 2;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(104, 85);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(420, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // grbEstatus
            // 
            this.grbEstatus.Controls.Add(this.btInactiva);
            this.grbEstatus.Controls.Add(this.rbtActiva);
            this.grbEstatus.Location = new System.Drawing.Point(103, 128);
            this.grbEstatus.Margin = new System.Windows.Forms.Padding(4);
            this.grbEstatus.Name = "grbEstatus";
            this.grbEstatus.Padding = new System.Windows.Forms.Padding(4);
            this.grbEstatus.Size = new System.Drawing.Size(268, 86);
            this.grbEstatus.TabIndex = 4;
            this.grbEstatus.TabStop = false;
            this.grbEstatus.Text = "Estatus";
            // 
            // btInactiva
            // 
            this.btInactiva.AutoSize = true;
            this.btInactiva.Location = new System.Drawing.Point(152, 36);
            this.btInactiva.Margin = new System.Windows.Forms.Padding(4);
            this.btInactiva.Name = "btInactiva";
            this.btInactiva.Size = new System.Drawing.Size(77, 21);
            this.btInactiva.TabIndex = 1;
            this.btInactiva.TabStop = true;
            this.btInactiva.Text = "Inactiva";
            this.btInactiva.UseVisualStyleBackColor = true;
            // 
            // rbtActiva
            // 
            this.rbtActiva.AutoSize = true;
            this.rbtActiva.Checked = true;
            this.rbtActiva.Location = new System.Drawing.Point(41, 36);
            this.rbtActiva.Margin = new System.Windows.Forms.Padding(4);
            this.rbtActiva.Name = "rbtActiva";
            this.rbtActiva.Size = new System.Drawing.Size(67, 21);
            this.rbtActiva.TabIndex = 0;
            this.rbtActiva.TabStop = true;
            this.rbtActiva.Text = "Activa";
            this.rbtActiva.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(16, 257);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 41);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(200, 257);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(132, 41);
            this.btnLimpiar.TabIndex = 6;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(388, 257);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(132, 41);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(340, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // FormAltaCarreras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 309);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbEstatus);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblClave);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormAltaCarreras";
            this.Text = "FormAltaCarreras";
            this.grbEstatus.ResumeLayout(false);
            this.grbEstatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grbEstatus;
        private System.Windows.Forms.RadioButton btInactiva;
        private System.Windows.Forms.RadioButton rbtActiva;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
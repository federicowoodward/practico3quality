﻿namespace WindowsFormsApp1
{
    partial class frmCrearAlumnos
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
            this.FormCrearAlumno = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLimpiar = new System.Windows.Forms.Button();
            this.BtnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.Carrera = new System.Windows.Forms.TextBox();
            this.Edad = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.FormCrearAlumno.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormCrearAlumno
            // 
            this.FormCrearAlumno.Controls.Add(this.panel1);
            this.FormCrearAlumno.Controls.Add(this.label1);
            this.FormCrearAlumno.Location = new System.Drawing.Point(16, 16);
            this.FormCrearAlumno.Margin = new System.Windows.Forms.Padding(7);
            this.FormCrearAlumno.Name = "FormCrearAlumno";
            this.FormCrearAlumno.Size = new System.Drawing.Size(282, 392);
            this.FormCrearAlumno.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnLimpiar);
            this.panel1.Controls.Add(this.BtnCrear);
            this.panel1.Location = new System.Drawing.Point(0, 266);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 0, 50, 0);
            this.panel1.Size = new System.Drawing.Size(282, 40);
            this.panel1.TabIndex = 6;
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnLimpiar.Location = new System.Drawing.Point(50, 0);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(75, 40);
            this.BtnLimpiar.TabIndex = 6;
            this.BtnLimpiar.Text = "Limpiar";
            this.BtnLimpiar.UseVisualStyleBackColor = true;
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // BtnCrear
            // 
            this.BtnCrear.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCrear.Location = new System.Drawing.Point(157, 0);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 40);
            this.BtnCrear.TabIndex = 1;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.UseVisualStyleBackColor = true;
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese datos y cree nuevo alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Cursando",
            "Finalizado"});
            this.cmbEstado.Location = new System.Drawing.Point(34, 184);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(143, 21);
            this.cmbEstado.TabIndex = 5;
            this.cmbEstado.Text = "Estado";
            // 
            // Carrera
            // 
            this.Carrera.Location = new System.Drawing.Point(34, 133);
            this.Carrera.Name = "Carrera";
            this.Carrera.Size = new System.Drawing.Size(143, 20);
            this.Carrera.TabIndex = 3;
            // 
            // Edad
            // 
            this.Edad.Location = new System.Drawing.Point(34, 83);
            this.Edad.Name = "Edad";
            this.Edad.Size = new System.Drawing.Size(143, 20);
            this.Edad.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(34, 37);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(143, 20);
            this.Nombre.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Edad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Carrera:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Estado:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Edad);
            this.panel2.Controls.Add(this.cmbEstado);
            this.panel2.Controls.Add(this.Nombre);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Carrera);
            this.panel2.Location = new System.Drawing.Point(16, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(282, 210);
            this.panel2.TabIndex = 1;
            // 
            // frmCrearAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 424);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FormCrearAlumno);
            this.Name = "frmCrearAlumnos";
            this.Text = "CrearAlumnos";
            this.FormCrearAlumno.ResumeLayout(false);
            this.FormCrearAlumno.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FormCrearAlumno;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Carrera;
        private System.Windows.Forms.TextBox Edad;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button BtnCrear;
        public System.Windows.Forms.Button BtnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}
namespace WindowsFormsApp1
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.PanelPrincipal = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoDocentesSubMenu = new System.Windows.Forms.Panel();
            this.btnListarEmpleados = new System.Windows.Forms.Button();
            this.btnCrearEmpleado = new System.Windows.Forms.Button();
            this.NoDocentes = new System.Windows.Forms.Button();
            this.DocentesSubMenu = new System.Windows.Forms.Panel();
            this.btnListarDocentes = new System.Windows.Forms.Button();
            this.btnCrearDocente = new System.Windows.Forms.Button();
            this.btnMostrarDocentes = new System.Windows.Forms.Button();
            this.Docentes = new System.Windows.Forms.Button();
            this.AlumnosEgresados = new System.Windows.Forms.Button();
            this.AlumnosSubmenu = new System.Windows.Forms.Panel();
            this.BtnListarAlumnos = new System.Windows.Forms.Button();
            this.BtnCrearAlumno = new System.Windows.Forms.Button();
            this.Alumnos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.NoDocentesSubMenu.SuspendLayout();
            this.DocentesSubMenu.SuspendLayout();
            this.AlumnosSubmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelPrincipal
            // 
            this.PanelPrincipal.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.PanelPrincipal.Location = new System.Drawing.Point(198, 1);
            this.PanelPrincipal.Name = "PanelPrincipal";
            this.PanelPrincipal.Size = new System.Drawing.Size(726, 463);
            this.PanelPrincipal.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.NoDocentesSubMenu);
            this.panel1.Controls.Add(this.NoDocentes);
            this.panel1.Controls.Add(this.DocentesSubMenu);
            this.panel1.Controls.Add(this.Docentes);
            this.panel1.Controls.Add(this.AlumnosEgresados);
            this.panel1.Controls.Add(this.AlumnosSubmenu);
            this.panel1.Controls.Add(this.Alumnos);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 612);
            this.panel1.TabIndex = 2;
            // 
            // NoDocentesSubMenu
            // 
            this.NoDocentesSubMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NoDocentesSubMenu.Controls.Add(this.btnListarEmpleados);
            this.NoDocentesSubMenu.Controls.Add(this.btnCrearEmpleado);
            this.NoDocentesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoDocentesSubMenu.Location = new System.Drawing.Point(0, 484);
            this.NoDocentesSubMenu.Name = "NoDocentesSubMenu";
            this.NoDocentesSubMenu.Size = new System.Drawing.Size(200, 80);
            this.NoDocentesSubMenu.TabIndex = 7;
            // 
            // btnListarEmpleados
            // 
            this.btnListarEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarEmpleados.Location = new System.Drawing.Point(0, 40);
            this.btnListarEmpleados.Name = "btnListarEmpleados";
            this.btnListarEmpleados.Size = new System.Drawing.Size(200, 40);
            this.btnListarEmpleados.TabIndex = 1;
            this.btnListarEmpleados.Text = "Listar empleados";
            this.btnListarEmpleados.UseVisualStyleBackColor = true;
            this.btnListarEmpleados.Click += new System.EventHandler(this.btnListarEmpleados_Click);
            // 
            // btnCrearEmpleado
            // 
            this.btnCrearEmpleado.AllowDrop = true;
            this.btnCrearEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearEmpleado.Location = new System.Drawing.Point(0, 0);
            this.btnCrearEmpleado.Name = "btnCrearEmpleado";
            this.btnCrearEmpleado.Size = new System.Drawing.Size(200, 40);
            this.btnCrearEmpleado.TabIndex = 0;
            this.btnCrearEmpleado.Text = "Crear empleado";
            this.btnCrearEmpleado.UseVisualStyleBackColor = true;
            this.btnCrearEmpleado.Click += new System.EventHandler(this.btnCrearEmpleado_Click);
            // 
            // NoDocentes
            // 
            this.NoDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.NoDocentes.Location = new System.Drawing.Point(0, 439);
            this.NoDocentes.Name = "NoDocentes";
            this.NoDocentes.Size = new System.Drawing.Size(200, 45);
            this.NoDocentes.TabIndex = 6;
            this.NoDocentes.Text = "No docentes";
            this.NoDocentes.UseVisualStyleBackColor = true;
            this.NoDocentes.Click += new System.EventHandler(this.NoDocentes_Click);
            // 
            // DocentesSubMenu
            // 
            this.DocentesSubMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DocentesSubMenu.Controls.Add(this.btnListarDocentes);
            this.DocentesSubMenu.Controls.Add(this.btnCrearDocente);
            this.DocentesSubMenu.Controls.Add(this.btnMostrarDocentes);
            this.DocentesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.DocentesSubMenu.Location = new System.Drawing.Point(0, 320);
            this.DocentesSubMenu.Name = "DocentesSubMenu";
            this.DocentesSubMenu.Size = new System.Drawing.Size(200, 119);
            this.DocentesSubMenu.TabIndex = 5;
            // 
            // btnListarDocentes
            // 
            this.btnListarDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListarDocentes.Location = new System.Drawing.Point(0, 80);
            this.btnListarDocentes.Name = "btnListarDocentes";
            this.btnListarDocentes.Size = new System.Drawing.Size(200, 40);
            this.btnListarDocentes.TabIndex = 1;
            this.btnListarDocentes.Text = "Listar docentes";
            this.btnListarDocentes.UseVisualStyleBackColor = true;
            this.btnListarDocentes.Click += new System.EventHandler(this.btnListarDocentes_Click);
            // 
            // btnCrearDocente
            // 
            this.btnCrearDocente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCrearDocente.Location = new System.Drawing.Point(0, 40);
            this.btnCrearDocente.Name = "btnCrearDocente";
            this.btnCrearDocente.Size = new System.Drawing.Size(200, 40);
            this.btnCrearDocente.TabIndex = 0;
            this.btnCrearDocente.Text = "Crear docente";
            this.btnCrearDocente.UseVisualStyleBackColor = true;
            this.btnCrearDocente.Click += new System.EventHandler(this.btnCrearDocente_Click);
            // 
            // btnMostrarDocentes
            // 
            this.btnMostrarDocentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarDocentes.Location = new System.Drawing.Point(0, 0);
            this.btnMostrarDocentes.Name = "btnMostrarDocentes";
            this.btnMostrarDocentes.Size = new System.Drawing.Size(200, 40);
            this.btnMostrarDocentes.TabIndex = 2;
            this.btnMostrarDocentes.Text = "Mostrar Docentes";
            this.btnMostrarDocentes.Click += new System.EventHandler(this.btnMostrarDocentes_Click);
            // 
            // Docentes
            // 
            this.Docentes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Docentes.Location = new System.Drawing.Point(0, 275);
            this.Docentes.Name = "Docentes";
            this.Docentes.Size = new System.Drawing.Size(200, 45);
            this.Docentes.TabIndex = 4;
            this.Docentes.Text = "Docentes";
            this.Docentes.UseVisualStyleBackColor = true;
            this.Docentes.Click += new System.EventHandler(this.Docentes_Click);
            // 
            // AlumnosEgresados
            // 
            this.AlumnosEgresados.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlumnosEgresados.Location = new System.Drawing.Point(0, 230);
            this.AlumnosEgresados.Name = "AlumnosEgresados";
            this.AlumnosEgresados.Size = new System.Drawing.Size(200, 45);
            this.AlumnosEgresados.TabIndex = 3;
            this.AlumnosEgresados.Text = "Alumnos egresados";
            this.AlumnosEgresados.UseVisualStyleBackColor = true;
            this.AlumnosEgresados.Click += new System.EventHandler(this.AlumnosEgresados_Click);
            // 
            // AlumnosSubmenu
            // 
            this.AlumnosSubmenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AlumnosSubmenu.Controls.Add(this.BtnListarAlumnos);
            this.AlumnosSubmenu.Controls.Add(this.BtnCrearAlumno);
            this.AlumnosSubmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.AlumnosSubmenu.Location = new System.Drawing.Point(0, 150);
            this.AlumnosSubmenu.Name = "AlumnosSubmenu";
            this.AlumnosSubmenu.Size = new System.Drawing.Size(200, 80);
            this.AlumnosSubmenu.TabIndex = 2;
            // 
            // BtnListarAlumnos
            // 
            this.BtnListarAlumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnListarAlumnos.Location = new System.Drawing.Point(0, 40);
            this.BtnListarAlumnos.Name = "BtnListarAlumnos";
            this.BtnListarAlumnos.Size = new System.Drawing.Size(200, 40);
            this.BtnListarAlumnos.TabIndex = 1;
            this.BtnListarAlumnos.Text = "Listar alumnos";
            this.BtnListarAlumnos.UseVisualStyleBackColor = true;
            this.BtnListarAlumnos.Click += new System.EventHandler(this.BtnListarAlumnos_Click);
            // 
            // BtnCrearAlumno
            // 
            this.BtnCrearAlumno.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCrearAlumno.Location = new System.Drawing.Point(0, 0);
            this.BtnCrearAlumno.Name = "BtnCrearAlumno";
            this.BtnCrearAlumno.Size = new System.Drawing.Size(200, 40);
            this.BtnCrearAlumno.TabIndex = 0;
            this.BtnCrearAlumno.Text = "Crear alumno";
            this.BtnCrearAlumno.UseVisualStyleBackColor = true;
            this.BtnCrearAlumno.Click += new System.EventHandler(this.BtnCrearAlumno_Click);
            // 
            // Alumnos
            // 
            this.Alumnos.Dock = System.Windows.Forms.DockStyle.Top;
            this.Alumnos.Location = new System.Drawing.Point(0, 105);
            this.Alumnos.Name = "Alumnos";
            this.Alumnos.Size = new System.Drawing.Size(200, 45);
            this.Alumnos.TabIndex = 1;
            this.Alumnos.Text = "Alumnos";
            this.Alumnos.UseVisualStyleBackColor = true;
            this.Alumnos.Click += new System.EventHandler(this.Alumnos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(200, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PanelPrincipal);
            this.Name = "frmMenuPrincipal";
            this.Text = "frmMenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.NoDocentesSubMenu.ResumeLayout(false);
            this.DocentesSubMenu.ResumeLayout(false);
            this.AlumnosSubmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PanelPrincipal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel AlumnosSubmenu;
        private System.Windows.Forms.Button Alumnos;
        private System.Windows.Forms.Panel NoDocentesSubMenu;
        private System.Windows.Forms.Button NoDocentes;
        private System.Windows.Forms.Panel DocentesSubMenu;
        private System.Windows.Forms.Button Docentes;
        private System.Windows.Forms.Button AlumnosEgresados;
        private System.Windows.Forms.Button btnListarEmpleados;
        private System.Windows.Forms.Button btnCrearEmpleado;
        private System.Windows.Forms.Button btnListarDocentes;
        private System.Windows.Forms.Button btnCrearDocente;
        private System.Windows.Forms.Button BtnListarAlumnos;
        private System.Windows.Forms.Button BtnCrearAlumno;
        private System.Windows.Forms.Button btnMostrarDocentes;
    }
}
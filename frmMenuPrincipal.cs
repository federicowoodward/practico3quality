using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1s;

namespace WindowsFormsApp1
{
    public partial class frmMenuPrincipal : Form
    {
        internal List<ClassAlumno> listaAlumnos;
        internal List<ClassDocente> listaDocentes;
        internal List<ClassNoDocente> listNoDocentes;
        public frmMenuPrincipal()
        {
            InitializeComponent();
            listaAlumnos = new List<ClassAlumno>();
            listaDocentes = new List<ClassDocente>();
            listNoDocentes = new List<ClassNoDocente>();
            Setear();
        }
        private void Setear()
        {
            AlumnosSubmenu.Visible = false;
            DocentesSubMenu.Visible = false;
            NoDocentesSubMenu.Visible = false;
        }

        private void EsconderMenu()
        {
            if (AlumnosSubmenu.Visible == true)
                AlumnosSubmenu.Visible = false;
            if (DocentesSubMenu.Visible == true)
                DocentesSubMenu.Visible = false;
            if (NoDocentesSubMenu.Visible == true)
                NoDocentesSubMenu.Visible = false;
        }

        private void MostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void Alumnos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(AlumnosSubmenu);
        }

        private void BtnCrearAlumno_Click(object sender, EventArgs e)
        {
            RenderPanelPrincipal(new frmCrearAlumnos(listaAlumnos));
            EsconderMenu();
        }

        private void BtnListarAlumnos_Click(object sender, EventArgs e)
        {
            RenderPanelPrincipal(new frmListarAlumnos(listaAlumnos));
            EsconderMenu();
        }

        private void AlumnosEgresados_Click(object sender, EventArgs e)
        {
            RenderPanelPrincipal(new frmListarExAlumnos(listaAlumnos));
            EsconderMenu();
        }
        private void Docentes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(DocentesSubMenu);
        }

        private void btnCrearDocente_Click(object sender, EventArgs e)
        {
            RenderPanelPrincipal(new frmCrearDocentes(listaDocentes));
            EsconderMenu();
        }

        private void btnListarDocentes_Click(object sender, EventArgs e)
        {
            RenderPanelPrincipal(new frmListarDocentes(listaDocentes));
            EsconderMenu();
        }

        private void NoDocentes_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(NoDocentesSubMenu);
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            RenderPanelPrincipal(new frmCrearNoDocentes(listNoDocentes));
            EsconderMenu();
        }

        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            RenderPanelPrincipal(new frmListarNoDocentes(listNoDocentes));
            EsconderMenu();
        }

        private void btnMostrarDocentes_Click(object sender, EventArgs e)
        {
            RenderPanelPrincipal(new FrmMostrarDocentes());
            EsconderMenu();
        }
        
        private void RenderPanelPrincipal(Form form)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
                this.PanelPrincipal.Controls.RemoveAt(0);

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            this.PanelPrincipal.Controls.Add(form);
            this.PanelPrincipal.Tag = form;
            form.Show();
        }

    }
}

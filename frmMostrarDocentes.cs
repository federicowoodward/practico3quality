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
    public partial class FrmMostrarDocentes : Form
    {
        private CRUDdocentes crudDocentes;

        public FrmMostrarDocentes()
        {
            InitializeComponent();
            this.Load += new EventHandler(FrmMostrarDocentes_Load);
            crudDocentes = new CRUDdocentes();
        }

        private void FrmMostrarDocentes_Load(object sender, EventArgs e)
        {
            List<ClassDocente> crudResult = crudDocentes.LeerDocentes();
            MessageBox.Show(crudResult.ToString());
            dataGridView1.DataSource = crudResult;
        }
    }
}
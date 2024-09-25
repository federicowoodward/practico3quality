using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void AceptarBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "123")
            {
                this.DialogResult = DialogResult.OK;
                Hide();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta. Intenta de nuevo.");
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Hide();
        }
    }
}

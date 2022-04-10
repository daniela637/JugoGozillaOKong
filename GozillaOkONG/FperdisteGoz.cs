using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GozillaOkONG
{
    public partial class FperdisteGoz : Form
    {
        public FperdisteGoz()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que no quieres jugar más?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

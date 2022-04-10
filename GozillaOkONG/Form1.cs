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
    public partial class FInicio : Form
    {
        public FInicio()
        {
            InitializeComponent();
            this.SetDisplayRectLocation(0,0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOpcionA_Click(object sender, EventArgs e)
        {
            Form cli = new Fkong1();
            this.Hide();
            cli.ShowDialog();
            this.Close();
        }

        private void btnOpcionB_Click(object sender, EventArgs e)
        {
            Form cli = new Fcap1Gozilla();
            this.Hide();
            cli.ShowDialog();
            this.Close();
        }

        private void btnOpcionC_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que no quieres jugar más?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

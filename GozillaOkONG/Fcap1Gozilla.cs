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
    public partial class Fcap1Gozilla : Form
    {
        public Fcap1Gozilla()
        {
            InitializeComponent();
        }

        private void btnOpcionB_Click(object sender, EventArgs e)
        {
            Form cli = new FperdisteGoz();
            this.Hide();
            cli.ShowDialog();
            this.Close();
        }

        private void btnOpcionA_Click(object sender, EventArgs e)
        {
            Form cli = new Fcap2Goz();
            this.Hide();
            cli.ShowDialog();
            this.Close();
        }
    }
}

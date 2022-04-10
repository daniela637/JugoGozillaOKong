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
    public partial class Fcap2_Kong : Form
    {
        public Fcap2_Kong()
        {
            InitializeComponent();
        }

        private void btnOpcionB_Click(object sender, EventArgs e)
        {
            Form cli = new Perdiste();
            this.Hide();
            cli.ShowDialog();
            this.Close();
        }

        private void btnOpcionA_Click(object sender, EventArgs e)
        {
            Form cli = new Fcap3Kong();
            this.Hide();
            cli.ShowDialog();
            this.Close();
        }
    }
}

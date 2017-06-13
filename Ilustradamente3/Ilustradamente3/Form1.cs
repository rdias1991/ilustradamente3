using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ilustradamente3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deixa deixaentrar = new Deixa();
            deixaentrar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rotina rotinaentrar = new Rotina();
            rotinaentrar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Recompensa recompensaentrar = new Recompensa();
            recompensaentrar.Show();
        }
    }
}

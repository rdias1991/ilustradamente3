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
    public partial class Rotina : Form
    {
        public Rotina()
        {
            InitializeComponent();
        }
        public Rotina(string Valor)
        {
            InitializeComponent();
            textBox1.Text = Valor;
            


        }


        private void Rotina_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnMultiline_Click(object sender, EventArgs e)
        {
            validateTextbox1.Multilinea = !validateTextbox1.Multilinea;
            this.Text = "Multilinea: " +validateTextbox1.Multilinea;
        }

        private void btnTexto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Texto: " + validateTextbox1.Texto);
        }
    }
}

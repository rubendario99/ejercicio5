using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio5
{
    public partial class ValidateTextbox : UserControl
    {
        public ValidateTextbox()
        {
            InitializeComponent();
            textBox1.Location = new Point(10, 10);
            textBox1.Width = this.Width - 20;
            this.Size = new Size(this.Width, textBox1.Height + 20);
        }

        [Category("Texto")]
        [Description("Obtiene el texto del textbox interno")]
        public string Texto
        {
            set
            {
                textBox1.Text = value;
            }
            get
            {
                return textBox1.Text;
            }
        }
        [Category("Multilinea")]
        [Description("Obtiene la propiedad multilínea")]
        public bool Multilinea
        {
            set
            {
                textBox1.Multiline = value;
            }
            get
            {
                return textBox1.Multiline;
            }
        }
        public enum eTipo
        {
            Numerico, //Números enteros: sólo son válidos los dígitos y espacios en los extremos
            Textual   //No admitirá nada que no sea una serie de letras o espacios
        }
        private eTipo tipo;
        public eTipo Tipo
        {
            set
            {
                tipo = value;
            }
            get
            {
                return tipo;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            char[] compararChar = textBox1.Text.ToCharArray();
        }
    }
}

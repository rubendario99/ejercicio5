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
        private bool isCorrecto = true;
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
        private eTipo tipo = eTipo.Numerico;
        public eTipo Tipo
        {
            set
            {
                tipo = value;
                textBox1_TextChanged(this, EventArgs.Empty);
            }
            get
            {
                return tipo;
            }
        }

        public event System.EventHandler TextChangeInterno;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            TextChangeInterno?.Invoke(this, e);

            switch (Tipo)
            {
                case eTipo.Numerico:
                    isCorrecto = comprobarNumerico();
                    break;
                case eTipo.Textual:
                    isCorrecto = comprobarTextual();
                    break;
            }
            this.Refresh();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;

            if (isCorrecto)
            {
               graphics.DrawRectangle(new Pen(Color.Green,4), 5, 5, this.Width - 5, this.Height - 5);
                
            }
            if(!isCorrecto)
            {
                graphics.DrawRectangle(new Pen(Color.Red,4), 5, 5, this.Width - 5, this.Height - 5);
            }
        }
        private bool comprobarNumerico()
        {
            string texto = this.Texto.Trim();
            
            foreach (char caracter in texto)
            {
                if (caracter < '0' || caracter > '9')
                {
                    return false;
                }
            }
            return true;
        }
        private bool comprobarTextual()
        {
            string texto = this.Texto;

            foreach (char caracter in texto)
            {
                if (Char.IsNumber(caracter))
                {
                    return false;
                }
            }

            return true;
        }
    }
}


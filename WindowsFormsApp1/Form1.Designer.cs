namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMultiline = new System.Windows.Forms.Button();
            this.validateTextbox1 = new Ejercicio5.ValidateTextbox();
            this.btnTexto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMultiline
            // 
            this.btnMultiline.Location = new System.Drawing.Point(35, 48);
            this.btnMultiline.Name = "btnMultiline";
            this.btnMultiline.Size = new System.Drawing.Size(75, 23);
            this.btnMultiline.TabIndex = 1;
            this.btnMultiline.Text = "Multiline";
            this.btnMultiline.UseVisualStyleBackColor = true;
            this.btnMultiline.Click += new System.EventHandler(this.btnMultiline_Click);
            // 
            // validateTextbox1
            // 
            this.validateTextbox1.Location = new System.Drawing.Point(0, 0);
            this.validateTextbox1.Multilinea = false;
            this.validateTextbox1.Name = "validateTextbox1";
            this.validateTextbox1.Size = new System.Drawing.Size(150, 42);
            this.validateTextbox1.TabIndex = 0;
            this.validateTextbox1.Texto = "";
            this.validateTextbox1.Tipo = Ejercicio5.ValidateTextbox.eTipo.Numerico;
            // 
            // btnTexto
            // 
            this.btnTexto.Location = new System.Drawing.Point(35, 172);
            this.btnTexto.Name = "btnTexto";
            this.btnTexto.Size = new System.Drawing.Size(75, 23);
            this.btnTexto.TabIndex = 2;
            this.btnTexto.Text = "Texto";
            this.btnTexto.UseVisualStyleBackColor = true;
            this.btnTexto.Click += new System.EventHandler(this.btnTexto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTexto);
            this.Controls.Add(this.btnMultiline);
            this.Controls.Add(this.validateTextbox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio5.ValidateTextbox validateTextbox1;
        private System.Windows.Forms.Button btnMultiline;
        private System.Windows.Forms.Button btnTexto;
    }
}


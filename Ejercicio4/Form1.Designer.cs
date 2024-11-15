namespace Ejercicio4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.radioSuma = new System.Windows.Forms.RadioButton();
            this.radioResta = new System.Windows.Forms.RadioButton();
            this.radioMulti = new System.Windows.Forms.RadioButton();
            this.radioDiv = new System.Windows.Forms.RadioButton();
            this.lblSimb = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(258, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(430, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(379, 193);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // radioSuma
            // 
            this.radioSuma.AutoSize = true;
            this.radioSuma.Location = new System.Drawing.Point(315, 149);
            this.radioSuma.Name = "radioSuma";
            this.radioSuma.Size = new System.Drawing.Size(31, 17);
            this.radioSuma.TabIndex = 3;
            this.radioSuma.TabStop = true;
            this.radioSuma.Text = "+";
            this.radioSuma.UseVisualStyleBackColor = true;
            // 
            // radioResta
            // 
            this.radioResta.AutoSize = true;
            this.radioResta.Location = new System.Drawing.Point(379, 149);
            this.radioResta.Name = "radioResta";
            this.radioResta.Size = new System.Drawing.Size(28, 17);
            this.radioResta.TabIndex = 4;
            this.radioResta.TabStop = true;
            this.radioResta.Text = "-";
            this.radioResta.UseVisualStyleBackColor = true;
            // 
            // radioMulti
            // 
            this.radioMulti.AutoSize = true;
            this.radioMulti.Location = new System.Drawing.Point(443, 149);
            this.radioMulti.Name = "radioMulti";
            this.radioMulti.Size = new System.Drawing.Size(29, 17);
            this.radioMulti.TabIndex = 5;
            this.radioMulti.TabStop = true;
            this.radioMulti.Text = "*";
            this.radioMulti.UseVisualStyleBackColor = true;
            // 
            // radioDiv
            // 
            this.radioDiv.AutoSize = true;
            this.radioDiv.Location = new System.Drawing.Point(500, 149);
            this.radioDiv.Name = "radioDiv";
            this.radioDiv.Size = new System.Drawing.Size(30, 17);
            this.radioDiv.TabIndex = 6;
            this.radioDiv.TabStop = true;
            this.radioDiv.Text = "/";
            this.radioDiv.UseVisualStyleBackColor = true;
            // 
            // lblSimb
            // 
            this.lblSimb.AutoSize = true;
            this.lblSimb.Location = new System.Drawing.Point(397, 99);
            this.lblSimb.Name = "lblSimb";
            this.lblSimb.Size = new System.Drawing.Size(0, 13);
            this.lblSimb.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(568, 99);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSimb);
            this.Controls.Add(this.radioDiv);
            this.Controls.Add(this.radioMulti);
            this.Controls.Add(this.radioResta);
            this.Controls.Add(this.radioSuma);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton radioSuma;
        private System.Windows.Forms.RadioButton radioResta;
        private System.Windows.Forms.RadioButton radioMulti;
        private System.Windows.Forms.RadioButton radioDiv;
        private System.Windows.Forms.Label lblSimb;
        private System.Windows.Forms.Label lblResultado;
    }
}


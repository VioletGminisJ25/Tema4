namespace ejercicio5
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
            this.listRight = new System.Windows.Forms.ListBox();
            this.listLeft = new System.Windows.Forms.ListBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lblItems = new System.Windows.Forms.Label();
            this.lblIndex = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listRight
            // 
            this.listRight.FormattingEnabled = true;
            this.listRight.Location = new System.Drawing.Point(463, 92);
            this.listRight.Name = "listRight";
            this.listRight.Size = new System.Drawing.Size(169, 186);
            this.listRight.TabIndex = 0;
            // 
            // listLeft
            // 
            this.listLeft.FormattingEnabled = true;
            this.listLeft.Location = new System.Drawing.Point(152, 91);
            this.listLeft.Name = "listLeft";
            this.listLeft.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listLeft.Size = new System.Drawing.Size(157, 186);
            this.listLeft.TabIndex = 1;
            this.listLeft.SelectedIndexChanged += new System.EventHandler(this.listLeft_SelectedIndexChanged);
            // 
            // btnRight
            // 
            this.btnRight.Location = new System.Drawing.Point(345, 147);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 23);
            this.btnRight.TabIndex = 2;
            this.btnRight.Text = "Move > >";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Location = new System.Drawing.Point(345, 190);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 23);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.Text = "< <  Move";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(440, 290);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(224, 293);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(320, 293);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(100, 20);
            this.textBox.TabIndex = 6;
            // 
            // lblItems
            // 
            this.lblItems.AutoSize = true;
            this.lblItems.Location = new System.Drawing.Point(240, 65);
            this.lblItems.Name = "lblItems";
            this.lblItems.Size = new System.Drawing.Size(0, 13);
            this.lblItems.TabIndex = 7;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(100, 92);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(0, 13);
            this.lblIndex.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIndex);
            this.Controls.Add(this.lblItems);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.listLeft);
            this.Controls.Add(this.listRight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listRight;
        private System.Windows.Forms.ListBox listLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lblItems;
        private System.Windows.Forms.Label lblIndex;
    }
}


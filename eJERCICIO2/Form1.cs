using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
namespace eJERCICIO2
{
    public partial class Form1 : Form //TODO: Imagen valida, taborder, quitar mensajes error en reset
    {
        public Form1()
        {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
            foreach(Control control in this.Controls)
            {
                control.Cursor = Cursors.Hand;
                control.MouseEnter += mouseEnter;
                control.MouseLeave += mouseLeave;
            }
        }

        private void mouseLeave(object sender, EventArgs e)
        {
            if (sender is Button)
            {

                ((Control)sender).BackColor = Color.White;
            }
        }

        private void mouseEnter(object sender, EventArgs e)
        {
            if(sender is Button)
            {

                ((Control)sender).BackColor = Color.Red;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool error = true;
            lblError.Text = "";

            if (Int32.TryParse(textBox1.Text, out int text1))
            {
                if (text1 >= 0 && text1 <= 255)
                {
                    if (Int32.TryParse(textBox2.Text, out int text2))
                    {
                        if (text2 >= 0 && text2 <= 255)
                        {
                            if (Int32.TryParse(textBox3.Text, out int text3))
                            {
                                if (text3 >= 0 && text3 <= 255)
                                {
                                    this.BackColor = Color.FromArgb(text1, text2, text3);
                                    lblError.Text="";
                                    error = false;
                                }
                            }
                        }
                    }
                }
            }

            if (error) { 
                lblError.Text = "ERR: Los datos introducidos no son válidos (0-255)";
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }


        private void btnImage_Click(object sender, EventArgs e)
        {
            Console.WriteLine(txtImage.Text);
            try
            {
                lblImagen.Image = new Bitmap(txtImage.Text);
                lblImagen.Size = lblImagen.Image.Size;

            }catch (Exception ex) when (ex is FileNotFoundException || ex is ArgumentException)
            {
                lblError.Text = "La imagen no es válida";
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImage_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnImage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnColor;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls) {
                if (control is TextBox)
                {
                    control.Text = "";
                }
                lblImagen.Image = null;
                lblError.Text = "";
                this.BackColor = Color.White;


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}

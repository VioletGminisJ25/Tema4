using Ejercicio_4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class Form1 : Form
    {
        private String filePath;
        public Form1()
        {
            InitializeComponent();
            this.Text = "Visor de imagenes";
            checkBox1.ForeColor = Color.Black;
        }

        private void buttonImg_Click(object sender, EventArgs e)
        {
            filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Png (*.png)|*.png|Jpg (*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 3;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Form2 form2 = new Form2(openFileDialog.FileName);

                    if (checkBox1.Checked)
                    {
                        form2.ShowDialog();
                    }
                    else
                    {
                        form2.Show();
                    }
                }
            }
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.ForeColor = checkBox1.ForeColor == Color.Black ? Color.Red : Color.Black;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}

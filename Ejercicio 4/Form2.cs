using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_4
{
    public partial class Form2 : Form
    {
        String filePath;
        public Form2(String filePath)
        {
                InitializeComponent();
                this.filePath = filePath;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                pictureBox1.Image = new Bitmap($@"{filePath}");
                this.Size = pictureBox1.Image.Size;
                String[] path = filePath.Split('\\');
                this.Text = path[path.Length - 1];

            }
            catch (ArgumentException)
            {
                this.Close();
                MessageBox.Show("No es una archivo válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

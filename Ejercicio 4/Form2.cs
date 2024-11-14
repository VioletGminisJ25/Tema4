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
        public Form2(String filePath)
        {
            InitializeComponent();
            pictureBox1.Image=new Bitmap($@"{filePath}");
            String[] path = filePath.Split('\\');
            this.Text = path[path.Length-1];
        }
    }
}

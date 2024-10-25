#define KEY_EFFECT
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//TODO: ARREGAR FUNCTION BUTTONS Y PONER LAS DIRECTIVAS DEL COMPILADOR
namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        private string DEFAULT_TITLE = "Mouse Tester";
        public Form1()
        {
            Point initialPosition = new Point(191, 191);
            Point currentPosition = initialPosition;
            InitializeComponent();
            this.Text = DEFAULT_TITLE;
            Button[] buttons = new Button[20];
            for (int i = 0; i < 20; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = i + 1 + "";
                buttons[i].Location = currentPosition;
                buttons[i].MouseClick += (object sender, MouseEventArgs e) =>
                {
                    this.Text = ((Button)sender).Text;
                };
                currentPosition = new Point(currentPosition.X + buttons[i].Width, currentPosition.Y);
                if ((i + 1) % 5 == 0)
                {
                    currentPosition.Y = currentPosition.Y + buttons[i].Height + 10;
                    currentPosition = new Point(initialPosition.X, currentPosition.Y);

                }
                this.Controls.Add(buttons[i]);
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender is Button)
            {
                this.Text = $"X:{(e.X + e.Location.X)} Y:{(e.Y + e.Location.Y)}";
            }
            else
            {
                this.Text = $"X:{e.X} Y:{e.Y}";

            }

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;


            if (e.Button == MouseButtons.Left)
            {
                button1.BackColor = Color.Blue;
            }
            else if (e.Button == MouseButtons.Right)
            {
                button2.BackColor = Color.Red;
            }
            else
            {
                button1.BackColor = Color.Blue;
                button2.BackColor = Color.Red;

            }
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            this.Text = DEFAULT_TITLE;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e) 
        {
            this.Text = e.KeyCode == (Keys.Escape) ? DEFAULT_TITLE : (e.KeyValue + "");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mi Aplicación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}

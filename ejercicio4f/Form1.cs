using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ejercicio4f
{
    public partial class Form1 : Form
    {
        public delegate double Functions(double n1, double n2);
        Dictionary<String,Functions> list;
        Functions func;
        double n1;
        double n2;
        Timer timer;
        int seconds;
        int minutes;
        public Form1()
        {
            InitializeComponent();
            n1 = 0;
            n2 = 0;
            list = new Dictionary<String,Functions>();
            list.Add("+", (n1, n2) =>n1+n2);
            list.Add("-", (n1, n2) =>n1-n2);
            list.Add("*", (n1, n2) =>n1*n2);
            list.Add("/", (n1, n2) =>n1/n2);
            this.Text = "00:00";
            seconds = 0;
            minutes = 0;
            timer = new Timer();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += updateTimer;
            timer.Start();

        }

        private void updateTimer(object sender, EventArgs e)
        {
            if (seconds >= 59)
            {
                minutes++;
                seconds = 0;
            }
            seconds++;
            this.Text = $"{minutes,2:D2}:{seconds,2:D2}";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = ((RadioButton)sender).Text.ToString();
            func = list[((RadioButton)sender).Text.ToString()];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = func.Invoke(n1,n2).ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(((TextBox)sender).Text.ToString(), out double tmp))
            {
                if(((TextBox)sender) == textBox1)
                {
                    n1 = tmp;
                }
                else
                {
                    n2 = tmp;
                }
                ((TextBox)sender).BackColor = Color.White;
            }
            else
            {
                ((TextBox)sender).BackColor = Color.Red;
            }
        }
    }
}

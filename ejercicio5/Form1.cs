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

namespace ejercicio5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            actualizarLabel();
            lblIndex.Text = "Index: \n";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(textBox.Text.Trim() != "")
            {
                if (!listLeft.Items.Contains(textBox.Text)) {
                    listLeft.Items.Add(textBox.Text);
                }
            }
            actualizarLabel();

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listLeft.SelectedItems != null) {
                for(int i = listLeft.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listLeft.Items.RemoveAt(i);
                }
            }
            actualizarLabel();

        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            ArrayList elements = elements = new ArrayList();

            foreach (var item in listLeft.SelectedItems)
            {
                elements.Add(item);
            }

            foreach (var item in elements)
            {
                listRight.Items.Add(item);
                listLeft.Items.Remove(item);
            }
            actualizarLabel();

        }
        private void btnLeft_Click(object sender, EventArgs e)
        {
            ArrayList elements = elements = new ArrayList();

            foreach (var item in listRight.SelectedItems)
            {
                elements.Add(item);
            }

            foreach (var item in elements)
            {
                listLeft.Items.Add(item);
                listRight.Items.Remove(item);
            }
            actualizarLabel();

        }


        public void actualizarLabel()
        {
            lblItems.Text = "List Count: " + listLeft.Items.Count.ToString();
        }

        private void listLeft_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblIndex.Text = "Index: \n";
            foreach (var item in listLeft.SelectedItems)
            {
                lblIndex.Text += listLeft.Items.IndexOf(item) +"\n";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salir(object sender, EventArgs e)
        {
            Close();
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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Envia una string vacia para resetear la label
            msjError.Text = "";

            try
            {
                int r = Convert.ToInt32(textBox1.Text);
                int g = Convert.ToInt32(textBox2.Text);
                int b = Convert.ToInt32(textBox3.Text);

                this.BackColor = Color.FromArgb(r, g, b);
            }
            catch (FormatException )
            {
                msjError.Text = "Debes introducir un numero.";
            }
            catch (OverflowException)
            {
                msjError.Text = "Has introducido un numero demasiado largo.";
            }

        }
    }

}


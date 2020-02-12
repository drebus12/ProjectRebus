using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_1_GIT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dni = Convert.ToInt32(textBoxNumero.Text);
            char letra = funcionDNI(dni);
            textBoxLetra.Text = letra.ToString();
        }

        private char funcionDNI(int dni)
        {
            char letra = 'A';



            return letra;
        }
    }
}

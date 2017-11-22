using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoGitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string numero1, numero2,result;

            numero1 = txtNumero1.Text;
            numero2 = txtNumero2.Text;
            result = numero1 + numero2;
            textResult.Text = result.ToString();
        }
    }
}

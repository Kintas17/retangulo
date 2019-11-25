using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Retangulo
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

        retangulo cunha = new retangulo();
        private void Button1_Click(object sender, EventArgs e)
        {
            cunha.recebe = textBox1.Text;
            label1.Text = cunha.envia;
        }
    }
}

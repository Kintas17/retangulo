﻿using System;
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
            cunha.altura = textBox1.Text;
            cunha.largura = textBox2.Text;
            if (radioButton1.Checked) label1.Text = cunha.Area;
            else if (radioButton2.Checked) label1.Text = cunha.Perimetro;
            else if (radioButton3.Checked)label1.Text = cunha.Diagonal;
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}

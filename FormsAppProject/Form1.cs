﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace FormsAppProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            button.ForeColor = Color.DarkBlue;
            label1.Text = "текст";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Новый текст";
        }
    }
}

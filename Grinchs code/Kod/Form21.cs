﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Świąt_nie_będzie__chyba_
{
    public partial class Form21 : Form
    {
        public Form21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form22 form22 = new Form22();
            form22.Show();
            Hide();
        }

        private void Form21_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form24 : Form
    {
        public Form24()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form25 form25 = new Form25();
            form25.Show();
            Hide();
        }
    }
}

using System;
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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form17 form17 = new Form17();
            form17.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smutny Grinch wrócił do swojej jaskini, a tobie udało się ocalić święta przed zniszczeniem!");
            Form28 form28 = new Form28();
            form28.Show();
            Hide();
        }
    }
}

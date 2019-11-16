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
    public partial class Form23 : Form
    {
        public Form23()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Smutny Grinch wrócił do swojej jaskini, a tobie udało się ocalić święta przed zniszczeniem! Ale co będzie za rok?");
            Form28 form28 = new Form28();
            form28.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form24 form24 = new Form24();
            form24.Show();
            Hide();
        }
    }
}

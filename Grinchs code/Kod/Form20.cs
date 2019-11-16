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
    public partial class Form20 : Form
    {
        public Form20()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form21 form21 = new Form21();
            form21.Show();
            Hide();
        }
    }
}

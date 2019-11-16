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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BRAWO! UDAŁO CI SIĘ URATOWAĆ ŚWIĘTA!! UWU! ");
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Postanowiłeś przejść się do aresztu, i spędzić święta z Grinchem. Zaprzyjaźliście się, a on przestał nienawidzić świąt");
            Form27 form27 = new Form27();
            form27.Show();
            Hide();

           
        }
    }
}

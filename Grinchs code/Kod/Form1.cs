using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Świąt_nie_będzie__chyba_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form26 form26 = new Form26();
            form26.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Music();

        }

        private async void Music()
        {
            while (true)
            {
                NonBlockingBeep(493, 400);
                await Task.Delay(400);
                NonBlockingBeep(493, 400);
                await Task.Delay(400);
                NonBlockingBeep(740, 400);
                await Task.Delay(400);
                NonBlockingBeep(740, 400);
                await Task.Delay(400);
                NonBlockingBeep(659, 400);
                await Task.Delay(400);
                NonBlockingBeep(587, 400);
                await Task.Delay(400);
                NonBlockingBeep(554, 400);
                await Task.Delay(400);
                NonBlockingBeep(493, 400);
                await Task.Delay(400);
                NonBlockingBeep(440, 400);
                await Task.Delay(400);
                NonBlockingBeep(493, 400);
                await Task.Delay(400);
                NonBlockingBeep(554, 400);
                await Task.Delay(400);
                NonBlockingBeep(587, 400);
                await Task.Delay(400);
                NonBlockingBeep(659, 400);
                await Task.Delay(400);
                NonBlockingBeep(740, 675);
                await Task.Delay(675);
                NonBlockingBeep(123, 400);
                await Task.Delay(400);
                NonBlockingBeep(185, 400);
                await Task.Delay(400);
                NonBlockingBeep(185, 400);
                await Task.Delay(400);
                NonBlockingBeep(164, 400);
                await Task.Delay(400);
                NonBlockingBeep(146, 400);
                await Task.Delay(400);
                NonBlockingBeep(138, 400);
                await Task.Delay(400);
                NonBlockingBeep(123, 400);
                await Task.Delay(400);
                NonBlockingBeep(110, 400);
                await Task.Delay(400);
                NonBlockingBeep(123, 400);
                await Task.Delay(400);
                NonBlockingBeep(138, 400);
                await Task.Delay(400);
                NonBlockingBeep(146, 400);
                await Task.Delay(400);
                NonBlockingBeep(164, 400);
                await Task.Delay(400);
                NonBlockingBeep(185, 675);
                await Task.Delay(675);
            }
        }

        private void NonBlockingBeep(int hertz, int time)
        {
            new Thread(() => Console.Beep(hertz, time)).Start();
        }
    }
}

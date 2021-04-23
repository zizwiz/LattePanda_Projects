using System.Windows.Forms;
using LattePanda.Firmata;

namespace Test_Firmata
{
    public partial class Form1 : Form
    {

        Arduino arduino = new Arduino();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            SetSwitches();

            arduino.pinMode(7, Arduino.OUTPUT);
            arduino.pinMode(8, Arduino.OUTPUT);
            arduino.pinMode(9, Arduino.OUTPUT);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            arduino.Close();
        }

        private void btn_close_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void rdo_high_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rdo_high.Checked)
            {
                if (!tswch_D7.Checked)
                {
                    tswch_D7.Checked = true;
                }
                else 
                {
                    tswch_D7.Checked = false;
                }
            }
            else
            {
                if (tswch_D7.Checked)
                {
                    tswch_D7.Checked = false;
                }
                else
                {
                    tswch_D7.Checked = true;
                }
            }

            /*
            if (rdobtn_low.Checked)
            {
                if (!tswch_D7.Checked)
                {
                    tswch_D7.Checked = false;
                }
            }
            else
            {
                if (tswch_D7.Checked)
                {
                    tswch_D7.Checked = true;
                }
            }*/
        }
    }
}

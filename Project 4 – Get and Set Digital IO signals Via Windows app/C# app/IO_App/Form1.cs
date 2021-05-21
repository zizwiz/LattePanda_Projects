using System;
using System.Reflection;
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

            // Set Outputs
            arduino.pinMode(7, Arduino.OUTPUT); lbl_D7.Text = "O";
            arduino.pinMode(8, Arduino.OUTPUT); lbl_D8.Text = "O";
            arduino.pinMode(9, Arduino.OUTPUT); lbl_D9.Text = "O";
            arduino.pinMode(10, Arduino.OUTPUT); lbl_D10.Text = "O";

            // Set Inputs
            arduino.pinMode(11, Arduino.INPUT); lbl_D11.Text = "I"; tswch_D11.Enabled = false;
            arduino.pinMode(12, Arduino.INPUT); lbl_D12.Text = "I"; tswch_D12.Enabled = false;

            // Add event to listen for input pins
            arduino.digitalPinUpdated += Arduino_digitalPinUpdated;

            // write app version  number to GUI
            lbl_version.Text = "v" + Assembly.GetExecutingAssembly().GetName().Version;
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
              //  if (!tswch_D0.Checked) { tswch_D0.Checked = true; } else { tswch_D0.Checked = false; }
              //  if (!tswch_D1.Checked) { tswch_D1.Checked = true; } else { tswch_D1.Checked = false; }
              //  if (!tswch_D2.Checked) { tswch_D2.Checked = true; } else { tswch_D2.Checked = false; }
              //  if (!tswch_D3.Checked) { tswch_D3.Checked = true; } else { tswch_D3.Checked = false; }
              //  if (!tswch_D4.Checked) { tswch_D4.Checked = true; } else { tswch_D4.Checked = false; }
              //  if (!tswch_D5.Checked) { tswch_D5.Checked = true; } else { tswch_D5.Checked = false; }
              //  if (!tswch_D6.Checked) { tswch_D6.Checked = true; } else { tswch_D6.Checked = false; }
                if (!tswch_D7.Checked) { tswch_D7.Checked = true; } else { tswch_D7.Checked = false; }
              //  if (!tswch_D7.Checked) { tswch_D8.Checked = true; } else { tswch_D8.Checked = false; }
              //  if (!tswch_D8.Checked) { tswch_D9.Checked = true; } else { tswch_D9.Checked = false; }
              //  if (!tswch_D10.Checked) { tswch_D10.Checked = true; } else { tswch_D10.Checked = false; }
              //  if (!tswch_D11.Checked) { tswch_D11.Checked = true; } else { tswch_D11.Checked = false; }
              //  if (!tswch_D12.Checked) { tswch_D12.Checked = true; } else { tswch_D12.Checked = false; }
              //  if (!tswch_D13.Checked) { tswch_D13.Checked = true; } else { tswch_D13.Checked = false; }
            }
            else
            {
              //  if (!tswch_D0.Checked) { tswch_D0.Checked = false; } else { tswch_D0.Checked = true; }
              //  if (!tswch_D1.Checked) { tswch_D1.Checked = false; } else { tswch_D1.Checked = true; }
              //  if (!tswch_D2.Checked) { tswch_D2.Checked = false; } else { tswch_D2.Checked = true; }
              //  if (!tswch_D3.Checked) { tswch_D3.Checked = false; } else { tswch_D3.Checked = true; }
              //  if (!tswch_D4.Checked) { tswch_D4.Checked = false; } else { tswch_D4.Checked = true; }
              //  if (!tswch_D5.Checked) { tswch_D5.Checked = false; } else { tswch_D5.Checked = true; }
              //  if (!tswch_D6.Checked) { tswch_D6.Checked = false; } else { tswch_D6.Checked = true; }
                if (!tswch_D7.Checked) { tswch_D7.Checked = false; } else { tswch_D7.Checked = true; }
              //  if (!tswch_D7.Checked) { tswch_D8.Checked = false; } else { tswch_D8.Checked = true; }
              //  if (!tswch_D8.Checked) { tswch_D9.Checked = false; } else { tswch_D9.Checked = true; }
              //  if (!tswch_D10.Checked) { tswch_D10.Checked = false; } else { tswch_D10.Checked = true; }
              //  if (!tswch_D11.Checked) { tswch_D11.Checked = false; } else { tswch_D11.Checked = true; }
              //  if (!tswch_D12.Checked) { tswch_D12.Checked = false; } else { tswch_D12.Checked = true; }
              //  if (!tswch_D13.Checked) { tswch_D13.Checked = false; } else { tswch_D13.Checked = true; }
            }
        }

        //Event which is listening for input pins
        private void Arduino_digitalPinUpdated(byte pin, byte state)
        {
            Invoke(new Action(() =>
            {
                string ActivePin = pin.ToString();

                if (state.ToString() == "0")
                {
                    if (ActivePin == "11") { tswch_D11.Checked = false; }
                    else if (ActivePin == "12") { tswch_D12.Checked = false; }
                }
                else
                {
                    if (ActivePin == "11") { tswch_D11.Checked = true; }
                    else if (ActivePin == "12") { tswch_D12.Checked = true; }
                }

                lbl_pin.Text = pin.ToString();
                lbl_state.Text = state.ToString();
                lbl_read.Text = arduino.digitalRead(12).ToString();

            }));
        }
    }
}

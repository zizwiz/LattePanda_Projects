using System;
using System.Drawing;
using LattePanda.Firmata;

namespace Test_Firmata
{
    // someValue = condition ? newValue : someValue;
    public partial class Form1
    {
        private void tswch_D0_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D0.Text = "OFF";
            LED_D0.BackColor = Color.Red;
            if (rdo_high.Checked)
            {
                arduino.digitalWrite(0, Arduino.LOW);
            }
            else
            {
                arduino.digitalWrite(0, Arduino.HIGH);
            }

            if (tswch_D0.Checked)
            {
                lbl_state_D0.Text = "ON";
                LED_D0.BackColor = Color.LimeGreen;
                
                if (rdo_high.Checked)
                {
                    arduino.digitalWrite(0, Arduino.HIGH);
                }
                else
                {
                    arduino.digitalWrite(0, Arduino.LOW);
                }
            }
            GC.Collect();
        }

        private void tswch_D1_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D1.Text = "OFF";
            LED_D1.BackColor = Color.Red;
            

            if (tswch_D1.Checked)
            {
                lbl_state_D1.Text = "ON";
                LED_D1.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }

        private void tswch_D2_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D2.Text = "OFF";
            LED_D2.BackColor = Color.Red;

            if (tswch_D2.Checked)
            {
                lbl_state_D2.Text = "ON";
                LED_D2.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }

        private void tswch_D3_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D3.Text = "OFF";
            LED_D3.BackColor = Color.Red;

            if (tswch_D3.Checked)
            {
                lbl_state_D3.Text = "ON";
                LED_D3.BackColor = Color.LimeGreen;
            }

            GC.Collect();
        }

        private void tswch_D4_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D4.Text = "OFF";
            LED_D4.BackColor = Color.Red;

            if (tswch_D4.Checked)
            {
                lbl_state_D4.Text = "ON";
                LED_D4.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }

        private void tswch_D5_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D5.Text = "OFF";
            LED_D5.BackColor = Color.Red;

            if (tswch_D5.Checked)
            {
                lbl_state_D5.Text = "ON";
                LED_D5.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }

        private void tswch_D6_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D6.Text = "OFF";
            LED_D6.BackColor = Color.Red;

            if (tswch_D6.Checked)
            {
                lbl_state_D6.Text = "ON";
                LED_D6.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }

        private void tswch_D7_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D7.Text = "LO";
            LED_D7.BackColor = Color.Red;

           if (rdo_high.Checked)
            {
                arduino.digitalWrite(7, Arduino.LOW);
            }
            else
            {
                arduino.digitalWrite(7, Arduino.HIGH);
            }

           if (tswch_D7.Checked)
           {
               lbl_state_D7.Text = "HI";
               LED_D7.BackColor = Color.LimeGreen;

               if (rdo_high.Checked)
               {
                   arduino.digitalWrite(7, Arduino.HIGH);
               }
               else
               {
                   arduino.digitalWrite(7, Arduino.LOW);
               }
           }

           GC.Collect();
        }

        private void tswch_D8_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D8.Text = "OFF";
            LED_D8.BackColor = Color.Red;

            if (rdo_high.Checked)
            {
                arduino.digitalWrite(8, Arduino.LOW);
            }
            else
            {
                arduino.digitalWrite(8, Arduino.HIGH);
            }

            if (tswch_D8.Checked)
            {
                lbl_state_D8.Text = "ON";
                LED_D8.BackColor = Color.LimeGreen;

                if (rdo_high.Checked)
                {
                    arduino.digitalWrite(8, Arduino.HIGH);
                }
                else
                {
                    arduino.digitalWrite(8, Arduino.LOW);
                }
            }

            GC.Collect();
        }

        private void tswch_D9_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D9.Text = "OFF";
            LED_D9.BackColor = Color.Red;

            if (rdo_high.Checked)
            {
                arduino.digitalWrite(9, Arduino.LOW);
            }
            else
            {
                arduino.digitalWrite(9, Arduino.HIGH);
            }

            if (tswch_D9.Checked)
            {
                lbl_state_D9.Text = "ON";
                LED_D9.BackColor = Color.LimeGreen;

                if (rdo_high.Checked)
                {
                    arduino.digitalWrite(9, Arduino.HIGH);
                }
                else
                {
                    arduino.digitalWrite(9, Arduino.LOW);
                }
            }
            GC.Collect();
        }

        private void tswch_D10_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D10.Text = "OFF";
            LED_D10.BackColor = Color.Red;


            if (tswch_D10.Checked)
            {
                lbl_state_D10.Text = "ON";
                LED_D10.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }

        private void tswch_D11_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D11.Text = "OFF";
            LED_D11.BackColor = Color.Red;


            if (tswch_D11.Checked)
            {
                lbl_state_D11.Text = "ON";
                LED_D11.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }

        private void tswch_D12_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D12.Text = "OFF";
            LED_D12.BackColor = Color.Red;


            if (tswch_D12.Checked)
            {
                lbl_state_D12.Text = "ON";
                LED_D12.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }

        private void tswch_D13_CheckedChanged(object sender, EventArgs e)
        {
            lbl_state_D13.Text = "OFF";
            LED_D13.BackColor = Color.Red;


            if (tswch_D13.Checked)
            {
                lbl_state_D13.Text = "ON";
                LED_D13.BackColor = Color.LimeGreen;
            }
            GC.Collect();
        }
    }
}

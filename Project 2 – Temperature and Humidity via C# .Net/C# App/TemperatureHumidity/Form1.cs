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
using LattePanda.Firmata;

namespace TemperatureHumidity
{
    public partial class Form1 : Form
    {
        Arduino arduino = new Arduino();

        const int GetTemp = 0x47;
        const int getHumid = 0x49;

        bool flag = true;
        private Thread _readThread = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _readThread = new Thread(StartWork);
            _readThread.Start();
           // StartWork();

        }

        private void StartWork()
        {
            do
            {
                DoWork();
            } while (flag);

            _readThread.Abort();
        }

        private void DoWork()
        {
            string output = "";
            
            arduino.DHT(GetTemp);
            Thread.Sleep(2000);
            output = arduino.STRING_DHT + "°C   ";
            
            arduino.DHT(getHumid);
            Thread.Sleep(2000);
            output += arduino.STRING_DHT + "%\r";

            Invoke(new Action(() =>
                {
                    rchtxtbx_output.AppendText(DateTime.Now + "  " + output);
                    rchtxtbx_output.ScrollToCaret();
                }));

            output = "";
        }
             

        private void chkbx_flag_CheckedChanged(object sender, EventArgs e)
        {

            if (chkbx_flag.Checked == false)
            {
                flag = false;
            }
            else
            {
                flag = true;
                _readThread = new Thread(StartWork);
                _readThread.Start();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            rchtxtbx_output.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _readThread.Abort();
        }
    }
}

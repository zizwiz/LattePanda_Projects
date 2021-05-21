using System.Drawing;

namespace Test_Firmata
{
    public partial class Form1
    {




        public void SetSwitches()
        {
            ////////////////////////////////////////////////////////////////
            /// We paint each switch the way we want it
            /// ///////////////////////////////////////////////////////////
            ///
            /// tswch_D1.BackColor = System.Drawing.Color.Transparent;
            tswch_D0.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D0.OnText = "ON";
            tswch_D0.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D0.OnForeColor = Color.White;
            tswch_D0.OffText = "OFF";
            tswch_D0.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D0.OffForeColor = Color.White;
            lbl_state_D0.Text = "OFF";


            tswch_D1.BackColor = System.Drawing.Color.Transparent;
            tswch_D1.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D1.OnText = "HI";
            tswch_D1.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D1.OnForeColor = Color.White;
            tswch_D1.OffText = "LO";
            tswch_D1.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D1.OffForeColor = Color.White; 
            lbl_state_D1.Text = "LO";
            

            tswch_D2.BackColor = System.Drawing.Color.Transparent;
            tswch_D2.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D2.OnText = "HI";
            tswch_D2.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D2.OnForeColor = Color.White;
            tswch_D2.OffText = "LO";
            tswch_D2.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D2.OffForeColor = Color.White;
            lbl_state_D2.Text = "LO";


            tswch_D3.BackColor = System.Drawing.Color.Transparent;
            tswch_D3.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D3.OnText = "HI";
            tswch_D3.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D3.OnForeColor = Color.White;
            tswch_D3.OffText = "LO";
            tswch_D3.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D3.OffForeColor = Color.White;
            lbl_state_D3.Text = "LO";

            tswch_D4.BackColor = System.Drawing.Color.Transparent;
            tswch_D4.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D4.OnText = "HI";
            tswch_D4.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D4.OnForeColor = Color.White;
            tswch_D4.OffText = "LO";
            tswch_D4.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D4.OffForeColor = Color.White;
            lbl_state_D4.Text = "LO";

            tswch_D5.BackColor = System.Drawing.Color.Transparent;
            tswch_D5.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D5.OnText = "HI";
            tswch_D5.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D5.OnForeColor = Color.White;
            tswch_D5.OffText = "LO";
            tswch_D5.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D5.OffForeColor = Color.White;
            lbl_state_D5.Text = "LO";

            tswch_D6.BackColor = System.Drawing.Color.Transparent;
            tswch_D6.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D6.OnText = "HI";
            tswch_D6.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D6.OnForeColor = Color.White;
            tswch_D6.OffText = "LO";
            tswch_D6.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D6.OffForeColor = Color.White;
            lbl_state_D6.Text = "LO";

            tswch_D7.BackColor = System.Drawing.Color.Transparent;
            tswch_D7.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D7.OnText = "HI";
            tswch_D7.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D7.OnForeColor = Color.White;
            tswch_D7.OffText = "LO";
            tswch_D7.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D7.OffForeColor = Color.White;
            lbl_state_D7.Text = "LO";

            tswch_D8.BackColor = System.Drawing.Color.Transparent;
            tswch_D8.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D8.OnText = "HI";
            tswch_D8.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D8.OnForeColor = Color.White;
            tswch_D8.OffText = "LO";
            tswch_D8.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D8.OffForeColor = Color.White;
            lbl_state_D8.Text = "LO";


            tswch_D9.BackColor = System.Drawing.Color.Transparent;
            tswch_D9.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D9.OnText = "HI";
            tswch_D9.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D9.OnForeColor = Color.White;
            tswch_D9.OffText = "LO";
            tswch_D9.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D9.OffForeColor = Color.White;
            lbl_state_D9.Text = "LO";

            tswch_D10.BackColor = System.Drawing.Color.Transparent;
            tswch_D10.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D10.OnText = "HI";
            tswch_D10.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D10.OnForeColor = Color.White;
            tswch_D10.OffText = "LO";
            tswch_D10.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D10.OffForeColor = Color.White;
            lbl_state_D10.Text = "LO";


            tswch_D11.BackColor = System.Drawing.Color.Transparent;
            tswch_D11.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D11.OnText = "HI";
            tswch_D11.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D11.OnForeColor = Color.White;
            tswch_D11.OffText = "LO";
            tswch_D11.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D11.OffForeColor = Color.White;
            lbl_state_D11.Text = "LO";


            tswch_D12.BackColor = System.Drawing.Color.Transparent;
            tswch_D12.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D12.OnText = "HI";
            tswch_D12.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D12.OnForeColor = Color.White;
            tswch_D12.OffText = "LO";
            tswch_D12.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D12.OffForeColor = Color.White;
            lbl_state_D12.Text = "LO";

            tswch_D13.BackColor = System.Drawing.Color.Transparent;
            tswch_D13.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
            tswch_D13.OnText = "HI";
            tswch_D13.OnFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D13.OnForeColor = Color.White;
            tswch_D13.OffText = "LO";
            tswch_D13.OffFont = new Font(tabControl_1.Font.FontFamily, 9, FontStyle.Bold);
            tswch_D13.OffForeColor = Color.White;
            lbl_state_D13.Text = "LO";
        }


    }
}

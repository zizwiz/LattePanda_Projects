
namespace TemperatureHumidity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.rchtxtbx_output = new System.Windows.Forms.RichTextBox();
            this.chkbx_flag = new System.Windows.Forms.CheckBox();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rchtxtbx_output
            // 
            this.rchtxtbx_output.Location = new System.Drawing.Point(77, 110);
            this.rchtxtbx_output.Name = "rchtxtbx_output";
            this.rchtxtbx_output.Size = new System.Drawing.Size(659, 316);
            this.rchtxtbx_output.TabIndex = 3;
            this.rchtxtbx_output.Text = "";
            // 
            // chkbx_flag
            // 
            this.chkbx_flag.AutoSize = true;
            this.chkbx_flag.Checked = true;
            this.chkbx_flag.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_flag.Location = new System.Drawing.Point(611, 35);
            this.chkbx_flag.Name = "chkbx_flag";
            this.chkbx_flag.Size = new System.Drawing.Size(46, 17);
            this.chkbx_flag.TabIndex = 4;
            this.chkbx_flag.Text = "Run";
            this.chkbx_flag.UseVisualStyleBackColor = true;
            this.chkbx_flag.CheckedChanged += new System.EventHandler(this.chkbx_flag_CheckedChanged);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(77, 23);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(90, 39);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(331, 23);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(90, 39);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.chkbx_flag);
            this.Controls.Add(this.rchtxtbx_output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Temperature and Humidity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rchtxtbx_output;
        private System.Windows.Forms.CheckBox chkbx_flag;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Clear;
    }
}


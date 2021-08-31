
namespace NineTime
{
    partial class NTC_TIMER
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
            this.components = new System.ComponentModel.Container();
            this.ellipseControl1 = new NineTime.EllipseControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Hour_TextBox = new System.Windows.Forms.TextBox();
            this.Minute_TextBox = new System.Windows.Forms.TextBox();
            this.Sec_TextBox = new System.Windows.Forms.TextBox();
            this.Start_Stop_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.Set_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 30;
            this.ellipseControl1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Hour_TextBox
            // 
            this.Hour_TextBox.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Hour_TextBox.Location = new System.Drawing.Point(26, 50);
            this.Hour_TextBox.Name = "Hour_TextBox";
            this.Hour_TextBox.Size = new System.Drawing.Size(46, 50);
            this.Hour_TextBox.TabIndex = 0;
            // 
            // Minute_TextBox
            // 
            this.Minute_TextBox.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Minute_TextBox.Location = new System.Drawing.Point(118, 50);
            this.Minute_TextBox.Name = "Minute_TextBox";
            this.Minute_TextBox.Size = new System.Drawing.Size(46, 50);
            this.Minute_TextBox.TabIndex = 1;
            // 
            // Sec_TextBox
            // 
            this.Sec_TextBox.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Sec_TextBox.Location = new System.Drawing.Point(210, 50);
            this.Sec_TextBox.Name = "Sec_TextBox";
            this.Sec_TextBox.Size = new System.Drawing.Size(46, 50);
            this.Sec_TextBox.TabIndex = 2;
            // 
            // Start_Stop_Button
            // 
            this.Start_Stop_Button.Location = new System.Drawing.Point(36, 168);
            this.Start_Stop_Button.Name = "Start_Stop_Button";
            this.Start_Stop_Button.Size = new System.Drawing.Size(75, 92);
            this.Start_Stop_Button.TabIndex = 3;
            this.Start_Stop_Button.Text = "button1";
            this.Start_Stop_Button.UseVisualStyleBackColor = true;
            this.Start_Stop_Button.Click += new System.EventHandler(this.Start_Stop_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(117, 168);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 92);
            this.Reset_Button.TabIndex = 4;
            this.Reset_Button.Text = "button2";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // Set_Button
            // 
            this.Set_Button.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.Set_Button.Location = new System.Drawing.Point(198, 168);
            this.Set_Button.Name = "Set_Button";
            this.Set_Button.Size = new System.Drawing.Size(75, 92);
            this.Set_Button.TabIndex = 5;
            this.Set_Button.Text = "button3";
            this.Set_Button.UseVisualStyleBackColor = true;
            this.Set_Button.Click += new System.EventHandler(this.Set_Button_Click);
            // 
            // NTC_TIMER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(318, 272);
            this.Controls.Add(this.Set_Button);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Start_Stop_Button);
            this.Controls.Add(this.Sec_TextBox);
            this.Controls.Add(this.Minute_TextBox);
            this.Controls.Add(this.Hour_TextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NTC_TIMER";
            this.Text = "NTC_TIMER";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NTC_TIMER_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EllipseControl ellipseControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Set_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Start_Stop_Button;
        private System.Windows.Forms.TextBox Sec_TextBox;
        private System.Windows.Forms.TextBox Minute_TextBox;
        private System.Windows.Forms.TextBox Hour_TextBox;
    }
}
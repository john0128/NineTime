
namespace NineTime
{
    partial class NTchoClock
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
            this.rdBtn_calender = new NineTime.Rounded_Button();
            this.rdBtn_timer = new NineTime.Rounded_Button();
            this.rdBtn_stopwatch = new NineTime.Rounded_Button();
            this.ellipseControl1 = new NineTime.EllipseControl();
            this.SuspendLayout();
            // 
            // rdBtn_calender
            // 
            this.rdBtn_calender.Image = global::NineTime.Properties.Resources.calender;
            this.rdBtn_calender.Location = new System.Drawing.Point(92, 156);
            this.rdBtn_calender.Name = "rdBtn_calender";
            this.rdBtn_calender.Size = new System.Drawing.Size(150, 150);
            this.rdBtn_calender.TabIndex = 2;
            this.rdBtn_calender.Text = " ";
            this.rdBtn_calender.UseVisualStyleBackColor = true;
            this.rdBtn_calender.Click += new System.EventHandler(this.rdBtn_calender_Click);
            // 
            // rdBtn_timer
            // 
            this.rdBtn_timer.Image = global::NineTime.Properties.Resources.timer;
            this.rdBtn_timer.Location = new System.Drawing.Point(172, 12);
            this.rdBtn_timer.Name = "rdBtn_timer";
            this.rdBtn_timer.Size = new System.Drawing.Size(150, 150);
            this.rdBtn_timer.TabIndex = 1;
            this.rdBtn_timer.Text = " ";
            this.rdBtn_timer.UseVisualStyleBackColor = true;
            this.rdBtn_timer.Click += new System.EventHandler(this.rdBtn_timer_Click);
            // 
            // rdBtn_stopwatch
            // 
            this.rdBtn_stopwatch.Image = global::NineTime.Properties.Resources.stopwatch1;
            this.rdBtn_stopwatch.Location = new System.Drawing.Point(12, 12);
            this.rdBtn_stopwatch.Name = "rdBtn_stopwatch";
            this.rdBtn_stopwatch.Size = new System.Drawing.Size(150, 150);
            this.rdBtn_stopwatch.TabIndex = 0;
            this.rdBtn_stopwatch.UseVisualStyleBackColor = true;
            this.rdBtn_stopwatch.Click += new System.EventHandler(this.rdBtn_stopwatch_Click);
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 30;
            this.ellipseControl1.TargetControl = this;
            // 
            // NTchoClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.rdBtn_calender);
            this.Controls.Add(this.rdBtn_timer);
            this.Controls.Add(this.rdBtn_stopwatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NTchoClock";
            this.Text = "NTchoClock";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NTchoClock_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private EllipseControl ellipseControl1;
        private Rounded_Button rdBtn_calender;
        private Rounded_Button rdBtn_timer;
        private Rounded_Button rdBtn_stopwatch;
    }
}
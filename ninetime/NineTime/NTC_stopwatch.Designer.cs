
namespace NineTime
{
    partial class NTC_stopwatch
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
            this.w = new NineTime.EllipseControl();
            this.ui_b_Hour = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ui_b_Minute = new System.Windows.Forms.Label();
            this.ui_b_Second = new System.Windows.Forms.Label();
            this.uiBtn_Start = new NineTime.Rounded_Button();
            this.uiBtn_Stop = new NineTime.Rounded_Button();
            this.uiBtn_Reset = new NineTime.Rounded_Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.CornerRadius = 30;
            this.w.TargetControl = this;
            // 
            // ui_b_Hour
            // 
            this.ui_b_Hour.AutoSize = true;
            this.ui_b_Hour.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_b_Hour.Location = new System.Drawing.Point(36, 62);
            this.ui_b_Hour.Name = "ui_b_Hour";
            this.ui_b_Hour.Size = new System.Drawing.Size(61, 37);
            this.ui_b_Hour.TabIndex = 0;
            this.ui_b_Hour.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(100, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(192, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = ":";
            // 
            // ui_b_Minute
            // 
            this.ui_b_Minute.AutoSize = true;
            this.ui_b_Minute.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_b_Minute.Location = new System.Drawing.Point(134, 62);
            this.ui_b_Minute.Name = "ui_b_Minute";
            this.ui_b_Minute.Size = new System.Drawing.Size(61, 37);
            this.ui_b_Minute.TabIndex = 3;
            this.ui_b_Minute.Text = "00";
            // 
            // ui_b_Second
            // 
            this.ui_b_Second.AutoSize = true;
            this.ui_b_Second.Font = new System.Drawing.Font("굴림", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ui_b_Second.Location = new System.Drawing.Point(228, 62);
            this.ui_b_Second.Name = "ui_b_Second";
            this.ui_b_Second.Size = new System.Drawing.Size(61, 37);
            this.ui_b_Second.TabIndex = 4;
            this.ui_b_Second.Text = "00";
            // 
            // uiBtn_Start
            // 
            this.uiBtn_Start.Location = new System.Drawing.Point(31, 154);
            this.uiBtn_Start.Name = "uiBtn_Start";
            this.uiBtn_Start.Size = new System.Drawing.Size(75, 58);
            this.uiBtn_Start.TabIndex = 5;
            this.uiBtn_Start.Text = "Start";
            this.uiBtn_Start.UseVisualStyleBackColor = true;
            this.uiBtn_Start.Click += new System.EventHandler(this.uiBtn_Start_Click);
            // 
            // uiBtn_Stop
            // 
            this.uiBtn_Stop.Location = new System.Drawing.Point(112, 154);
            this.uiBtn_Stop.Name = "uiBtn_Stop";
            this.uiBtn_Stop.Size = new System.Drawing.Size(75, 58);
            this.uiBtn_Stop.TabIndex = 6;
            this.uiBtn_Stop.Text = "Stop";
            this.uiBtn_Stop.UseVisualStyleBackColor = true;
            this.uiBtn_Stop.Click += new System.EventHandler(this.uiBtn_Stop_Click);
            // 
            // uiBtn_Reset
            // 
            this.uiBtn_Reset.Location = new System.Drawing.Point(193, 154);
            this.uiBtn_Reset.Name = "uiBtn_Reset";
            this.uiBtn_Reset.Size = new System.Drawing.Size(75, 58);
            this.uiBtn_Reset.TabIndex = 7;
            this.uiBtn_Reset.Text = "Reset";
            this.uiBtn_Reset.UseVisualStyleBackColor = true;
            this.uiBtn_Reset.Click += new System.EventHandler(this.uiBtn_Reset_Click);
            // 
            // NTC_stopwatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.uiBtn_Reset);
            this.Controls.Add(this.uiBtn_Stop);
            this.Controls.Add(this.uiBtn_Start);
            this.Controls.Add(this.ui_b_Second);
            this.Controls.Add(this.ui_b_Minute);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ui_b_Hour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NTC_stopwatch";
            this.Text = "NTC_stopwatch";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NTC_stopwatch_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EllipseControl w;
        private Rounded_Button uiBtn_Reset;
        private Rounded_Button uiBtn_Stop;
        private Rounded_Button uiBtn_Start;
        private System.Windows.Forms.Label ui_b_Second;
        private System.Windows.Forms.Label ui_b_Minute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ui_b_Hour;
        private System.Windows.Forms.Timer timer1;
    }
}
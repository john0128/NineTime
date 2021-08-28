
namespace NineTime
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rounded_Button5 = new NineTime.Rounded_Button();
            this.rounded_Button4 = new NineTime.Rounded_Button();
            this.rounded_Button3 = new NineTime.Rounded_Button();
            this.rounded_Button2 = new NineTime.Rounded_Button();
            this.rounded_Button1 = new NineTime.Rounded_Button();
            this.ellipseControl1 = new NineTime.EllipseControl();
            this.dragForm1 = new NineTime.DragForm();
            this.dragForm2 = new NineTime.DragForm();
            this.dragForm3 = new NineTime.DragForm();
            this.dragForm4 = new NineTime.DragForm();
            this.dragForm5 = new NineTime.DragForm();
            this.dragForm6 = new NineTime.DragForm();
            this.dragForm7 = new NineTime.DragForm();
            this.dragForm8 = new NineTime.DragForm();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굵은안상수체", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(13, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = global::NineTime.Properties.Resources.sk99q;
            this.pictureBox1.Location = new System.Drawing.Point(-37, -31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rounded_Button5
            // 
            this.rounded_Button5.Location = new System.Drawing.Point(20, 207);
            this.rounded_Button5.Name = "rounded_Button5";
            this.rounded_Button5.Size = new System.Drawing.Size(100, 100);
            this.rounded_Button5.TabIndex = 6;
            this.rounded_Button5.Text = " ";
            this.rounded_Button5.UseVisualStyleBackColor = true;
            // 
            // rounded_Button4
            // 
            this.rounded_Button4.Location = new System.Drawing.Point(126, 207);
            this.rounded_Button4.Name = "rounded_Button4";
            this.rounded_Button4.Size = new System.Drawing.Size(100, 100);
            this.rounded_Button4.TabIndex = 5;
            this.rounded_Button4.Text = " ";
            this.rounded_Button4.UseVisualStyleBackColor = true;
            // 
            // rounded_Button3
            // 
            this.rounded_Button3.Image = global::NineTime.Properties.Resources._4083783_audio_melody_music_sound_icon;
            this.rounded_Button3.Location = new System.Drawing.Point(232, 207);
            this.rounded_Button3.Name = "rounded_Button3";
            this.rounded_Button3.Size = new System.Drawing.Size(100, 100);
            this.rounded_Button3.TabIndex = 4;
            this.rounded_Button3.Text = " ";
            this.rounded_Button3.UseVisualStyleBackColor = true;
            // 
            // rounded_Button2
            // 
            this.rounded_Button2.Image = global::NineTime.Properties.Resources._1622827_clock_oclock_time_timing_watch_icon;
            this.rounded_Button2.Location = new System.Drawing.Point(232, 104);
            this.rounded_Button2.Name = "rounded_Button2";
            this.rounded_Button2.Size = new System.Drawing.Size(100, 100);
            this.rounded_Button2.TabIndex = 3;
            this.rounded_Button2.Text = " ";
            this.rounded_Button2.UseVisualStyleBackColor = true;
            // 
            // rounded_Button1
            // 
            this.rounded_Button1.Image = global::NineTime.Properties.Resources._728979_info_communication_data_help_information_icon;
            this.rounded_Button1.Location = new System.Drawing.Point(232, 1);
            this.rounded_Button1.Name = "rounded_Button1";
            this.rounded_Button1.Size = new System.Drawing.Size(100, 100);
            this.rounded_Button1.TabIndex = 2;
            this.rounded_Button1.Text = " ";
            this.rounded_Button1.UseVisualStyleBackColor = true;
            // 
            // ellipseControl1
            // 
            this.ellipseControl1.CornerRadius = 30;
            this.ellipseControl1.TargetControl = this;
            // 
            // dragForm1
            // 
            this.dragForm1.SelectControl = this;
            // 
            // dragForm2
            // 
            this.dragForm2.SelectControl = this.label1;
            // 
            // dragForm3
            // 
            this.dragForm3.SelectControl = this.pictureBox1;
            // 
            // dragForm4
            // 
            this.dragForm4.SelectControl = this.rounded_Button1;
            // 
            // dragForm5
            // 
            this.dragForm5.SelectControl = this.rounded_Button5;
            // 
            // dragForm6
            // 
            this.dragForm6.SelectControl = this.rounded_Button2;
            // 
            // dragForm7
            // 
            this.dragForm7.SelectControl = this.rounded_Button3;
            // 
            // dragForm8
            // 
            this.dragForm8.SelectControl = this.rounded_Button4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(334, 311);
            this.Controls.Add(this.rounded_Button5);
            this.Controls.Add(this.rounded_Button4);
            this.Controls.Add(this.rounded_Button3);
            this.Controls.Add(this.rounded_Button2);
            this.Controls.Add(this.rounded_Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "NineTime";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private EllipseControl ellipseControl1;
        private DragForm dragForm1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private Rounded_Button rounded_Button3;
        private Rounded_Button rounded_Button2;
        private Rounded_Button rounded_Button1;
        private Rounded_Button rounded_Button5;
        private Rounded_Button rounded_Button4;
        private DragForm dragForm2;
        private DragForm dragForm3;
        private DragForm dragForm4;
        private DragForm dragForm5;
        private DragForm dragForm6;
        private DragForm dragForm7;
        private DragForm dragForm8;
    }
}


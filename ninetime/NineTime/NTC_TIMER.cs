using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Runtime.InteropServices;

namespace NineTime
{
    public partial class NTC_TIMER : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        bool flag = false;
        int time = 600;
        int set_time = 600;
        public NTC_TIMER()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hour_TextBox.Text = (time / 3600).ToString();
            Minute_TextBox.Text = ((time % 3600) / 60).ToString();
            Sec_TextBox.Text = (time % 60).ToString();
            if (time == 0)
            {
                timer1.Stop();
                Start_Stop_Button.Text = "Start";
                flag = false;
                time = set_time;
            }
            time--;
        }

        private void Start_Stop_Button_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                timer1.Start();
                flag = true;
                Start_Stop_Button.Text = "Stop";
            }
            else
            {
                timer1.Stop();
                flag = false;
                Start_Stop_Button.Text = "Start";
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            Hour_TextBox.Text = (set_time / 3600).ToString();
            Minute_TextBox.Text = ((set_time % 3600) / 60).ToString();
            Sec_TextBox.Text = (set_time % 60).ToString();
            time = set_time;
        }

        private void Set_Button_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, k = 0;
            try
            {
                if (!int.TryParse(Hour_TextBox.Text, out i) || !int.TryParse(Minute_TextBox.Text, out j) || !int.TryParse(Sec_TextBox.Text, out k))
                {
                    MessageBox.Show("숫자만 입력해 주세요", "Warning !", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    if (Convert.ToInt32(Hour_TextBox.Text) < 0 || Convert.ToInt32(Minute_TextBox.Text) < 0 || Convert.ToInt32(Sec_TextBox.Text) < 0)
                    {
                        MessageBox.Show("음수는 입력하지 말아주세요", "Warning !", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        set_time = Convert.ToInt32(Hour_TextBox.Text) * 3600 + Convert.ToInt32(Minute_TextBox.Text) * 60 + Convert.ToInt32(Sec_TextBox.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("\n예기치않은 오류입니다\n다시시도해주세요" + ex.ToString(), "Exception Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void NTC_TIMER_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }
    }
}

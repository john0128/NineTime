using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.ComponentModel;
using System.Windows.Forms;

namespace NineTime
{
    class DragForm
    {
        private Control handleControl;

        public Control SelectControl
        {
            get { return this.handleControl; }
            set
            {
                this.handleControl = value;
                this.handleControl.MouseDown += new MouseEventHandler(this.DragForm_MouseDown);
            }
        }
        [DllImport("user32.DLL")]
        public static extern int SendMessage(IntPtr a, int msg, int wParam, int param);
        [DllImport("user32.DLL")]
        public static extern bool ReleaseCapture();

        private void DragForm_MouseDown(object sender, MouseEventArgs e)
        {
            bool flag = e.Button == MouseButtons.Left; //좌클:Left 우클:Right 휠클:Middle
            if (flag)
            {
                DragForm.ReleaseCapture();
                DragForm.SendMessage(this.SelectControl.FindForm().Handle, 161, 2, 0);
            }
        }
    }
}

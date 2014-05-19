using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication1
{
    public partial class F_Sign : Form
    {
        /// <summary>
        /// 渐变窗体
        /// </summary>
        public F_Sign()
        {
            InitializeComponent();
        }
        public F_Sign(int sign)
        { 
            InitializeComponent();
            this.Opacity = 0.9;
            if(sign==0)
            {
                lbsign.Text = "Failed!";
            }
            else if (sign == 1)
            {
                lbsign.Text = "Success!";
            }
            else if (sign == 2)
            {
                lbsign.Text = "Wrong number!";
            }
            else if (sign == 3)
            {
                lbsign.Text = "No chose!";
            }
        }
        private void Form_CopySign_Load(object sender, EventArgs e)
        {
            this.timer1.Enabled = true;//激活时间控件
            this.Opacity = 1;//窗体透明度为1，即完全不透明
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.5)
            {
                this.Opacity = this.Opacity - 0.08;
            }
            else
            {
                Close();
            }
            //意思就是当窗体的透明度大于0.5时透明度以0.08的速度递减；否则就关闭窗体
        }
    }
}

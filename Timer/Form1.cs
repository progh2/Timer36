using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Microsoft.VisualBasic;

namespace Timer
{

    public partial class Form1 : Form
    {
        int CountOrgNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (IntCheck())
            {
                CountOrgNum = Convert.ToInt32(this.txtNum.Text);
                txtNum.ReadOnly = true;
                Timer.Enabled = true;
            }
        }

        private bool IntCheck()
        {
            if (Information.IsNumeric(txtNum.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show("숫자를 입력해 주세요", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if(CountOrgNum < 1)
            {
                this.Timer.Enabled = false;
                this.txtNum.ReadOnly = false;
                this.txtNum.Text = "";
                MessageBox.Show("펑!", "알림",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CountOrgNum--;
                this.txtCountDown.Text = Convert.ToString(CountOrgNum);
            }
        }
    }
}

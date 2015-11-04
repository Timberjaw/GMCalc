using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GMCalc
{
    public partial class NumberDialog : Form
    {
        public string TxtTitle
        {
            get
            {
                return this.Text;
            }
            set
            {
                this.Text = value;
            }
        }

        public string TxtInput
        {
            get
            {
                return this.txtNumber.Text;
            }
            set
            {
                this.txtNumber.Text = value;
            }
        }

        public NumberDialog()
        {
            InitializeComponent();
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNumber_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }
    }
}

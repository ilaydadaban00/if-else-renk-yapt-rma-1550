using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_yapımıı2_1550
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbYesil_CheckedChanged(object sender, EventArgs e)
        {
            
            if (cbYesil.Checked)
            {
                this.BackColor = Color.Green;
            }
        }

        private void cbkirmizi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbkirmizi.Checked)
            {
                this.BackColor= Color.Red;
            }
        }

        private void cbMavi_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMavi.Checked)
            this.BackColor = Color.Blue;
        }

        private void cbSari_CheckedChanged(object sender, EventArgs e)
        {
            if(cbSari.Checked)
            this.BackColor = Color.Yellow;
        }

        private void cbMor_CheckedChanged(object sender, EventArgs e)
        {
            if(cbMor.Checked)
            this.BackColor = Color.Purple;
        }
    }
}

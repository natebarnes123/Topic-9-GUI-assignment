using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9_GUI_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            btnGood.Enabled = true;

            if (imgGood.Visible)
            {
                imgGood.Visible = false;
            }
            else
            {
                imgGood.Visible = true;
            }
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            btnBad.Enabled = true; 

            if (imgBad.Visible)
            {
                imgBad.Visible = false;
            }
            else
            {
                imgBad.Visible = true;
            }
        }

        private void imgGood_Click(object sender, EventArgs e)
        {

        }
    }
}

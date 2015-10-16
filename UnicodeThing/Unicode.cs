/*
 * Created by: Michael Weedmark
 * Created on: 16-10-2015
 * Created for: ICS3U
 * Daily Assignment – Unit 3-11
 * This program displays Unicode
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeThing
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string letter;

            for (int number = 65; number <= 90; number++)
            {
                letter = Char.ConvertFromUtf32(number);

                this.lstList.Items.Add(number + "-" + letter);
            }
        }
    }
}

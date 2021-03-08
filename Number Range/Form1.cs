using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_Range
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValuesButton_Click(object sender, EventArgs e)
        {
            int start = Convert.ToInt32(startTextBox.Text);
            int end = Convert.ToInt32(endTextBox.Text);
            

            while ( start <= end )
            {

                outputLabel.Text += $"{start}";
                start++;
            }
        }
    }
}

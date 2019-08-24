using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeandPunchline
{
    public partial class frmJokeandPunchLine : Form
    {
        public frmJokeandPunchLine()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            jplabel.Text = "Why do programmers always mix up Halloween and Christmas?"; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jplabel.Text = "Because Oct 31 equals Dec 25."; 
        }
    }
}

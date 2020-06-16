using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scaut
{
    public partial class select : Form
    {
        public select()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 nef = new Form1();
            Hide();
            nef.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clubs nef = new clubs();
            Hide();
            nef.Show();
        }
    }
}

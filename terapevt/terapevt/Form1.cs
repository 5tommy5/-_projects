using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace terapevt
{
    public partial class authorization : Form
    {
        public authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admin formadmin = new admin();
            formadmin.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctor formdoc = new doctor();
            formdoc.Show();
            Hide();
        }
    }
}

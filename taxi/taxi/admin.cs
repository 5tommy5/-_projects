using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taxi
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT marka, region FROM vodiy", db1.getConnection());

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(reader[0].ToString());
                listBox2.Items.Add(reader[1].ToString());
            }
            db1.closeConnection();
        }
    }
}

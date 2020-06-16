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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM clients WHERE login = @p_l AND password = @p_s", db.getConnection());
            command.Parameters.Add("@p_l", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@p_s", MySqlDbType.VarChar).Value = password.Text;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                auto_zakaz newzakaz = new auto_zakaz(Int32.Parse(reader[0].ToString()));
                db.closeConnection();
                Hide();
                newzakaz.Show();
            }
            else
            {
                MessageBox.Show("Неверно введенные данные!");
                db.closeConnection();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            reg newreg = new reg();
            //Hide();
            newreg.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            voditel newvod = new voditel();
            //Hide();
            newvod.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            admin newform = new admin();
            Hide();
            newform.Show();
        }
    }
}

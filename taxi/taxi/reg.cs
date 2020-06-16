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
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO clients (`name`, `login`, `password`) VALUES (@name, @login, @password);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегестрировались!");
                db.closeConnection();
                Hide();

            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Возникла ошибка!");
            }
        }
    }
}

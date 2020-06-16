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

namespace cinema
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM film", db1.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                film_box.Items.Add(reader[0]);

            }
            db1.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM bilet where `name` = @name and `phone` = @phone", db1.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = film_box.SelectedItem.ToString();
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox1.Text;
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                MessageBox.Show("Билет присутствует!");
            else
                MessageBox.Show("Билет отсутствует!");
            db1.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO film (`name`, `rezh`, `price`) values (@name, @rezh, @price) ", db1.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@rezh", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = Int32.Parse(textBox4.Text);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Фильм добавлен!");

            }
            film_box.Items.Clear();
            DB db2 = new DB();
            db2.openConnection();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand("SELECT name FROM film", db2.getConnection());
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                film_box.Items.Add(reader2[0]);

            }
            db2.closeConnection();
        }
    }
}

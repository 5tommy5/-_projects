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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            data_picker.MaxSelectionCount = 1;
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
            film_box.SelectedIndexChanged += new EventHandler(film_box_SelectedIndexChanged);
        }

        private void b_1_1_Click(object sender, EventArgs e)
        {
           
        }

        public void film_box_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            position.Items.Clear();
            price.Visible = false;
            ComboBox film_box = (ComboBox)sender;
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT price FROM film where `name` = @name", db1.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = film_box.SelectedItem.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                price.Text = reader[0].ToString();
                price.Visible = true;
            }
            db1.closeConnection();
            update();

        }
        public void update()
        {
            position.Items.Clear();
            position.Text = "";
            string[] all = { "1.1", "1.2", "1.3", "1.4", "1.5", "1.6", "2.1", "2.2", "2.3", "2.4", "2.5", "2.6", "3.1", "3.2", "3.3", "3.4", "3.5", "3.6" };
            string[] except = new string[18];
            DB db2 = new DB();
            db2.openConnection();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT position FROM bilet where `name` = @name and `data` = @data", db2.getConnection());
            command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = film_box.SelectedItem.ToString();
            command1.Parameters.Add("@data", MySqlDbType.Date).Value = data_picker.SelectionRange.Start;
            MySqlDataReader reader1 = command1.ExecuteReader();
            int i = 0;
            while (reader1.Read())
            {
                except[i] = reader1[0].ToString();
                i += 1;
            }
            db2.closeConnection();
            var result = all.Except(except);
            foreach (string s in result)
            {
                position.Items.Add(s);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO bilet (`name`, `data`, `phone`, `position`) values (@name, @data, @phone, @position) ", db1.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = film_box.SelectedItem.ToString();
            command.Parameters.Add("@data", MySqlDbType.Date).Value = data_picker.SelectionRange.Start;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@position", MySqlDbType.VarChar).Value = position.SelectedItem.ToString();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Билет куплен!");

            }
            db1.closeConnection();
            update();
        }
    }
}

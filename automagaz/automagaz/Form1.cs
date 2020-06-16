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

namespace automagaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT marka FROM auto WHERE `is_sealed` = 0", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            db.closeConnection();
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
            model.SelectedIndexChanged += new EventHandler(model_selectedindexchanged);
            year.SelectedIndexChanged += new EventHandler(year_selectedindexchanged);
            updating();

        }
        private void comboBox1_SelectedIndexChanged(object sender,System.EventArgs e)
        {
            model.Items.Clear();
            model.Text = "";
            year.Items.Clear();
            year.Text = "";
            ComboBox comboBox = (ComboBox)sender;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT model FROM auto WHERE `is_sealed` = 0 and `marka` = @marka", db.getConnection());
            command.Parameters.Add("@marka", MySqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                model.Items.Add(reader[0]);
            }
            db.closeConnection();
            updating();
        }
        public void updating()
        {
            marka_box.Items.Clear();
            model_box.Items.Clear();
            own_name.Items.Clear();
            own_surname.Items.Clear();
            prices.Items.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT model, marka, vlad_name, vlad_surname, price FROM auto WHERE `is_sealed` = 1", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                model_box.Items.Add(reader[0].ToString());
                marka_box.Items.Add(reader[1].ToString());
                own_name.Items.Add(reader[2].ToString());
                own_surname.Items.Add(reader[3].ToString());
                prices.Items.Add(reader[4].ToString());
            }
            db.closeConnection();
        }
        private void model_selectedindexchanged(object sender, System.EventArgs e)
        {
            year.Items.Clear();
            year.Text = "";
            ComboBox comboBox = (ComboBox)sender;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT year FROM auto WHERE `is_sealed` = 0 and `marka` = @marka and `model` = @model", db.getConnection());
            command.Parameters.Add("@model", MySqlDbType.VarChar).Value = model.SelectedItem.ToString();
            command.Parameters.Add("@marka", MySqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                year.Items.Add(reader[0]);
            }
            db.closeConnection();
            updating();
        }
        private void year_selectedindexchanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT price FROM auto WHERE `model` = @model AND `marka` = @marka AND `year` = @year", db.getConnection());
            command.Parameters.Add("@model", MySqlDbType.VarChar).Value = model.SelectedItem.ToString();
            command.Parameters.Add("@marka", MySqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            command.Parameters.Add("@year", MySqlDbType.Int32).Value = Int32.Parse(year.SelectedItem.ToString());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                price.Text = reader[0].ToString();
                price.Visible = true;
            }
            db.closeConnection();
            updating();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `auto` SET `is_sealed` = '1', `vlad_name` = @name, `vlad_surname` = @surname WHERE `marka` = @marka AND `model` = @model AND `year` = @year;", db.getConnection());
            command.Parameters.Add("@model", MySqlDbType.VarChar).Value = model.SelectedItem.ToString();
            command.Parameters.Add("@marka", MySqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            command.Parameters.Add("@year", MySqlDbType.Int32).Value = Int32.Parse(year.SelectedItem.ToString());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Документы о продаже уже подготавливаются!");
            else
                MessageBox.Show("Возникла ошибка");
            db.closeConnection();
            model.Items.Clear();
            model.Text = "";
            year.Items.Clear();
            year.Text = "";
            comboBox1.Text = "";
            updating();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updating();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `auto` (`marka`, `model`, `year`,  `price`) VALUES (@marka, @model, @year, @price);", db.getConnection());
            command.Parameters.Add("@model", MySqlDbType.VarChar).Value = model_box1.Text;
            command.Parameters.Add("@marka", MySqlDbType.VarChar).Value = marka_box1.Text;
            command.Parameters.Add("@year", MySqlDbType.Int32).Value = Int32.Parse(year_box1.Text);
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = Int32.Parse(price_box1.Text);
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Автомобиль добавлен в базу данных!");
            else
                MessageBox.Show("Возникла ошибка");
            db.closeConnection();
            updating();
        }
    }
}

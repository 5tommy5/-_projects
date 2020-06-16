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
    public partial class voditel : Form
    {
        public voditel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO vodiy (`name`, `login`, `password`, `marka`, `year`, `model`, `number`) VALUES (@name, @login, @password, @marka, @year, @model, @number);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@marka", MySqlDbType.VarChar).Value = marka.Text;
            command.Parameters.Add("@year", MySqlDbType.Int32).Value = Int32.Parse(year.Text);
            command.Parameters.Add("@model", MySqlDbType.VarChar).Value = model.Text;
            command.Parameters.Add("@number", MySqlDbType.Int32).Value = Int32.Parse(nomera.Text);
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Вы успешно зарегестрировались!");
                db.closeConnection();
                Form1 newform = new Form1();
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

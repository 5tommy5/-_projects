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

namespace scaut
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO footballer (`name`, `surname`, `height`, `weight`, `position`, `nation`, `club`, `years`) VALUES (@name, @surname, @height, @weight, @position, @nation, @club, @years);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@height", MySqlDbType.Int32).Value = Int32.Parse(height.Text);
            command.Parameters.Add("@weight", MySqlDbType.Int32).Value = Int32.Parse(weight.Text);
            command.Parameters.Add("@position", MySqlDbType.VarChar).Value = position.Text;
            command.Parameters.Add("@nation", MySqlDbType.VarChar).Value = nation.Text;
            command.Parameters.Add("@club", MySqlDbType.VarChar).Value = club.Text;
            command.Parameters.Add("@years", MySqlDbType.Int32).Value = Int32.Parse(years.Text);

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Готово!");
                db.closeConnection();
                //Hide();
                name.Text = "";
                surname.Text = "";

                height.Text = "";

                weight.Text = "";

                position.Text = "";
            
                nation.Text = "";

                club.Text = "";

                years.Text = "";


            }
        }
    }
}

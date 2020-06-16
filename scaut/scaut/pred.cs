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
    public partial class pred : Form
    {
        public string club_name;
        public pred(string club)
        {
            this.club_name = club;
            InitializeComponent();
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT surname FROM otpr where `club_to` = @club_to", db1.getConnection());
            command.Parameters.Add("@club_to", MySqlDbType.VarChar).Value = this.club_name;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                name_box.Items.Add(reader[0]);
            }
            db1.closeConnection();
        }


        public void clear()
        {
            name.Items.Clear();
            surname.Items.Clear();
            years.Items.Clear();
            nation.Items.Clear();
            position.Items.Clear();
            height.Items.Clear();
            weight.Items.Clear();
        }
        public void update()
        {
            List<footballer> footballers = new List<footballer>(21);
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM otpr where `club_to` = @club and `surname` = @surname", db1.getConnection());
            command.Parameters.Add("@club", MySqlDbType.VarChar).Value = this.club_name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = name_box.Text;
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                footballers.Add(new footballer(reader[1].ToString(), reader[2].ToString(), Int32.Parse(reader[3].ToString()), Int32.Parse(reader[4].ToString()), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), Int32.Parse(reader[8].ToString())));
            }
            db1.closeConnection();
            foreach (footballer f in footballers)
            {
                name.Items.Add(f.name);
                surname.Items.Add(f.surname);
                years.Items.Add(f.years.ToString());
                nation.Items.Add(f.nation);
                position.Items.Add(f.position);
                height.Items.Add(f.height.ToString());
                weight.Items.Add(f.weight.ToString());
            }

        }

        private void show_footballer_Click(object sender, EventArgs e)
        {
            clear();
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `footballer` SET `club` = @club_to WHERE `surname` = @surname and `name` = @name", db1.getConnection());
            command.Parameters.Add("@club_to", MySqlDbType.VarChar).Value = this.club_name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Items[0].ToString();
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Items[0].ToString();
            if (command.ExecuteNonQuery() == 1)
            {
                //MessageBox.Show("");
                db1.closeConnection();

            }
            else
                db1.closeConnection();
            //MessageBox.Show(surname.Items[0].ToString());
            DB db2 = new DB();
            db2.openConnection();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("DELETE FROM `otpr` WHERE `surname` = @surname and `name` = @name and `club_to` = @club_to" , db2.getConnection());
            command1.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Items[0].ToString();
            command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Items[0].ToString();
            command1.Parameters.Add("@club_to", MySqlDbType.VarChar).Value = this.club_name;
            if (command1.ExecuteNonQuery() == 1)
            {
                //MessageBox.Show("");
                db2.closeConnection();

            }
            else
                db2.closeConnection();
            clear();
            update();
        }
    }
}

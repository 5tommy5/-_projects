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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select distinct position, nation from footballer", db1.getConnection());
            command.Parameters.Add("@che", MySqlDbType.VarChar).Value = "";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                position_box.Items.Add(reader[0].ToString());
                nation_box.Items.Add(reader[1].ToString());
            }
            db1.closeConnection();
            DB db2 = new DB();
            db2.openConnection();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand("select name from club", db2.getConnection());
            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
                club_box.Items.Add(reader2[0].ToString());

            db1.closeConnection();
        }
        public void clear()
        {
            name.Items.Clear();
            surname.Items.Clear();
            height.Items.Clear();
            weight.Items.Clear();
            club.Items.Clear();
        }
        public List<footballer> footballers1 = new List<footballer>(21);
        public void update()
        {

            footballers1.Clear();
            string[] parames = new string[5];
            for (int i = 0; i < 5; i++)
                parames[i] = "";
            if (!String.IsNullOrEmpty(height_box.Text.ToString()))
                parames[0] = "`height`> @low_h and `height`< @upper_h";
            else
                parames[0] = "`height` IS NOT NULL";
            if (!String.IsNullOrEmpty(weight_box.Text.ToString()))
                parames[1] = "`weight`>@low_w and `weight` < @upper_w";
            else
                parames[1] = "`weight` IS NOT NULL";
            if (years_box.Text.ToString() != "")
                parames[2] = "`years` = @years";
            else
                parames[2] = "`years` IS NOT NULL";
            if (position_box.SelectedIndex > -1)
                parames[3] = "`position` = @position";
            else
                parames[3] = "`position` IS NOT NULL";
            if (nation_box.SelectedIndex > -1)
                parames[4] = "`nation`= @nation";
            else
                parames[4] = "`nation` IS NOT NULL";
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand(String.Format("SELECT * FROM `footballer` where {0}  and {1} and {2} and {3} and {4}", parames[0], parames[1], parames[2], parames[3], parames[4]), db1.getConnection());
            if (parames[0] == "`height`> @low_h and `height`< @upper_h")
            {
                command.Parameters.Add("@low_h", MySqlDbType.Int32).Value = Int32.Parse(height_box.Text);

                command.Parameters.Add("@upper_h", MySqlDbType.Int32).Value = Int32.Parse(height_box1.Text.ToString());
            }
            if (parames[1] == "`weight`>@low_w and `weight` < @upper_w")
            {
                command.Parameters.Add("@low_w", MySqlDbType.Int32).Value = Int32.Parse(weight_box.Text.ToString());

                command.Parameters.Add("@upper_w", MySqlDbType.Int32).Value = Int32.Parse(weight_box1.Text.ToString());
            }
            if (parames[2] == "`years` = @years")
                command.Parameters.Add("@years", MySqlDbType.Int32).Value = Int32.Parse(years_box.Text.ToString());
            if (parames[3] == "`position` = @position")
                command.Parameters.Add("@position", MySqlDbType.VarChar).Value = position_box.Text.ToString();
            if (parames[4] == "`nation`= @nation")
                command.Parameters.Add("@nation", MySqlDbType.VarChar).Value = nation_box.Text.ToString();


            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                footballers1.Add(new footballer(reader[1].ToString(), reader[2].ToString(), Int32.Parse(reader[3].ToString()), Int32.Parse(reader[4].ToString()), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), Int32.Parse(reader[8].ToString())));
            }
            db1.closeConnection();
            foreach (footballer f in footballers1)
            {
                name.Items.Add(f.name);
                surname.Items.Add(f.surname);
                height.Items.Add(f.height.ToString());
                weight.Items.Add(f.weight.ToString());
                club.Items.Add(f.club.ToString());
            }
            sur_box.Items.Clear();

            foreach (var s in surname.Items)
                sur_box.Items.Add(s);

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            update();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            footballer x1 = footballers1.Find(x => x.surname.Contains(sur_box.SelectedItem.ToString()));
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO otpr (`name`, `surname`, `height`, `weight`, `position`, `nation`, `club`, `years`, `club_to`) VALUES (@name, @surname, @height, @weight, @position, @nation, @club, @years, @to_club);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = x1.name;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = x1.surname;
            command.Parameters.Add("@height", MySqlDbType.Int32).Value = x1.height;
            command.Parameters.Add("@weight", MySqlDbType.Int32).Value = x1.weight;
            command.Parameters.Add("@position", MySqlDbType.VarChar).Value = x1.position;
            command.Parameters.Add("@nation", MySqlDbType.VarChar).Value = x1.nation;
            command.Parameters.Add("@club", MySqlDbType.VarChar).Value = x1.club;
            command.Parameters.Add("@years", MySqlDbType.Int32).Value = x1.years;
            command.Parameters.Add("@to_club", MySqlDbType.VarChar).Value = club_box.SelectedItem.ToString();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заявка отправлена!");
                db.closeConnection();
                //Hide();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            add nef = new scaut.add();
            nef.Show();

        }
    }
}

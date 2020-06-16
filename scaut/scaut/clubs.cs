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
    public partial class clubs : Form
    {
        public clubs()
        {
            InitializeComponent();
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM club", db1.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                club_box.Items.Add(reader[0]);
            }
            db1.closeConnection();
        }

        private void search_Click(object sender, EventArgs e)
        {
            clear();
            update();

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
            MySqlCommand command = new MySqlCommand("SELECT * FROM footballer where `club` = @club", db1.getConnection());
            command.Parameters.Add("@club", MySqlDbType.VarChar).Value = club_box.SelectedItem.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                footballers.Add(new footballer(reader[1].ToString(), reader[2].ToString(), Int32.Parse(reader[3].ToString()), Int32.Parse(reader[4].ToString()), reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), Int32.Parse(reader[8].ToString())));
            }
            db1.closeConnection();
            foreach(footballer f in footballers)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string clubius = club_box.SelectedItem.ToString();
            pred form = new scaut.pred(clubius);
            form.Show();
        }
    }
}

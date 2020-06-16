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
    public partial class auto_zakaz : Form
    {
        public int id_clienta;
        public Dictionary<string, int> voditeli = new Dictionary<string, int>();
        public auto_zakaz(int id_clienta)
        {
            this.id_clienta = id_clienta;
            InitializeComponent();
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name FROM regions", db1.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                from_box.Items.Add(reader[0]);
                to_box.Items.Add(reader[0]);
            }
            db1.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            car_box.Items.Clear();
            car_box.Text = "";
            voditeli.Clear();
           


            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT marka, ID_voditel FROM vodiy where `region` = @region", db1.getConnection());
            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = from_box.SelectedItem.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                car_box.Items.Add(reader[0]);
                voditeli.Add(reader[0].ToString(), Int32.Parse(reader[1].ToString()));
            }
            db1.closeConnection();


            int price_tax = 30;
            string far;
            if (to_box.SelectedItem.ToString() == "Оболонь")
                far = "far_from_obolon";
            else if (to_box.SelectedItem.ToString() == "Святошин")
                far = "far_from_sviatoshin";
            else if (to_box.SelectedItem.ToString() == "Соломянский")
                far = "far_from_soloma";
            else if (to_box.SelectedItem.ToString() == "Печерский")
                far = "far_from_pechersk";
            else if (to_box.SelectedItem.ToString() == "Дарница")
                far = "	far_from_darnica";
            else if (to_box.SelectedItem.ToString() == "Шевченковский")
                far = "far_from_shevchenka";
            else
                far = "far_from_center";


            DB db2 = new DB();
            db2.openConnection();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand(String.Format("SELECT {0} FROM regions where `name` = @name", far), db2.getConnection());
            command1.Parameters.Add("@name", MySqlDbType.VarChar).Value = from_box.SelectedItem.ToString();
            MySqlDataReader reader1 = command1.ExecuteReader();
            if(reader1.Read())
               price_tax+= Int32.Parse(reader1[0].ToString());
            price_tax = price_tax * 2;
            db2.closeConnection();
            price.Visible = true;
            price.Text = price_tax.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO rides (`from_where`, `to_where`, `marka`, `price`, `id_clienta`) VALUES (@from, @to, @marka, @price, @id);", db.getConnection());
            command.Parameters.Add("@from", MySqlDbType.VarChar).Value = from_box.SelectedItem.ToString();
            command.Parameters.Add("@to", MySqlDbType.VarChar).Value = to_box.SelectedItem.ToString();
            command.Parameters.Add("@marka", MySqlDbType.VarChar).Value = car_box.SelectedItem.ToString();
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = Int32.Parse(price.Text);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id_clienta;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Водитель скоро будет!");
                db.closeConnection();
                DB db1 = new DB();
                db1.openConnection();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("UPDATE `vodiy` SET `region` = @new_reg WHERE `ID_voditel` = @id;", db1.getConnection());
                command1.Parameters.Add("@id", MySqlDbType.Int32).Value = voditeli[car_box.SelectedItem.ToString()];
                command1.Parameters.Add("@new_reg", MySqlDbType.VarChar).Value = to_box.SelectedItem.ToString();
                if (command1.ExecuteNonQuery() != 1)
                    MessageBox.Show("Что то пошло не так(");
                db1.closeConnection();
            }
            else
            {
                db.closeConnection();
                MessageBox.Show("Возникла ошибка!");
            }
        }
    }
}

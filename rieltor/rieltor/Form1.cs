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

namespace rieltor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DB db = new rieltor.DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("select distinct city from apartment", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                city_box.Items.Add(reader[0].ToString());
                //region_box.Items.Add(reader[1]);
            }
            city_box.SelectedIndexChanged += new EventHandler(city_selectedindexchanged);
            db.closeConnection();
            san_box.Items.Add("1");
            san_box.Items.Add("2");
            san_box.Items.Add("3");
            bed_box.Items.Add("1");
            bed_box.Items.Add("2");
            bed_box.Items.Add("3");
            bed_box.Items.Add("4");
            bed_box.Items.Add("5");
        }
        private void city_selectedindexchanged(object sender, System.EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            region_box.Items.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT DISTINCT region FROM apartment WHERE `city` = @city", db.getConnection());
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city_box.SelectedItem.ToString();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                region_box.Items.Add(reader[0]);
            }
            db.closeConnection();
        }
        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new rieltor.DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `apartment` (`city`, `region`, `square`, `san`, `bed`, `center`, `metro`, `name`, `surname`, `phone`, `price`) VALUES (@city, @region, @square, @san, @bed, @center, @metro, @name, @surname, @phone, @price);", db.getConnection());
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city.Text;
            command.Parameters.Add("@region", MySqlDbType.VarChar).Value = region.Text;
            command.Parameters.Add("@square", MySqlDbType.Int32).Value = Int32.Parse(square.Text);
            command.Parameters.Add("@san", MySqlDbType.Int32).Value = Int32.Parse(san.Text);
            command.Parameters.Add("@bed", MySqlDbType.Int32).Value = Int32.Parse(bed.Text);
            command.Parameters.Add("@center", MySqlDbType.Int32).Value = Int32.Parse(center.Text);
            command.Parameters.Add("@metro", MySqlDbType.Int32).Value = Int32.Parse(metro.Text);
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone.Text;
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = Int32.Parse(price.Text);



            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Добавлено в базу!");
            }

         }
        public List<ogolosh> ogolosheniya = new List<ogolosh>(5);
        private void button2_Click(object sender, EventArgs e)
        {
            ogolosheniya.Clear();
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            string[] parames = new string[7];
            for (int i = 0; i < 7; i++)
                parames[i] = "";
            if (!String.IsNullOrEmpty(square_box.Text))
                parames[0] = "`square`> @square";
            else
                parames[0] = "`square` IS NOT NULL";
            if (san_box.SelectedIndex > -1)
                parames[1] = "`san`>@san";
            else
                parames[1] = "`san` IS NOT NULL";
            if (bed_box.SelectedIndex > -1)
                parames[2] = "`bed` > @bed";
            else
                parames[2] = "`bed` IS NOT NULL";
            if (city_box.SelectedIndex > -1)
                parames[3] = "`city` = @city";
            else
                parames[3] = "`city` IS NOT NULL";
            if (region_box.SelectedIndex > -1)
                parames[4] = "`region`= @region";
            else
                parames[4] = "`region` IS NOT NULL";
            if (!String.IsNullOrEmpty(center_box.Text))
                parames[5] = "`center`< @center";
            else
                parames[5] = "`center` IS NOT NULL";
            if (!String.IsNullOrEmpty(square_box.Text))
                parames[6] = "`metro`< @metro";
            else
                parames[6] = "`metro` IS NOT NULL";
            MySqlCommand command = new MySqlCommand("SELECT * FROM `apartment` WHERE `square`>= @square and `city` = @city and `region`= @region and `bed` >= @bed and `san`>=@san and `center`< @center and `metro`< @metro", db.getConnection());
                command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city_box.SelectedItem.ToString();
       
                command.Parameters.Add("@region", MySqlDbType.VarChar).Value = region_box.SelectedItem.ToString();

                command.Parameters.Add("@bed", MySqlDbType.Int32).Value = Int32.Parse(bed_box.SelectedItem.ToString());

                command.Parameters.Add("@san", MySqlDbType.Int32).Value = Int32.Parse(san_box.SelectedItem.ToString());

                command.Parameters.Add("@square", MySqlDbType.Int32).Value = Int32.Parse(square_box.Text);

                command.Parameters.Add("@center", MySqlDbType.Int32).Value = Int32.Parse(center_box.Text);

                command.Parameters.Add("@metro", MySqlDbType.Int32).Value = Int32.Parse(metro_box.Text);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ogolosheniya.Add(new ogolosh(reader[1].ToString(), reader[2].ToString(), Int32.Parse(reader[3].ToString()), Int32.Parse(reader[4].ToString()), Int32.Parse(reader[5].ToString()), Int32.Parse(reader[6].ToString()), Int32.Parse(reader[7].ToString()),  reader[8].ToString(), reader[9].ToString(), reader[10].ToString(), Int32.Parse(reader[11].ToString())));
            }
            db.closeConnection();
            result nf = new result(ogolosheniya);
            nf.Show();

        }
    }
}

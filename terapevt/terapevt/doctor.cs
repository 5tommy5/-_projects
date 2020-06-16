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

namespace terapevt
{
    public partial class doctor : Form
    {
        public doctor()
        {
            InitializeComponent();
            date_pick.MaxSelectionCount = 1;

            db db1 = new db();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT surname FROM doctors", db1.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0]);
            }
            db1.closeConnection();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db2 = new db();
            db2.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT phone, comment FROM priyom where `doctor_surname` = @doc and `date` = @date", db2.getConnection());
            command.Parameters.Add("@doc", MySqlDbType.VarChar).Value = comboBox1.SelectedItem.ToString();
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
            MySqlDataReader reader = command.ExecuteReader();
            String[] phones = new String[5];
            String[] comment = new String[5];
            String[] names = new String[5];
            int counter = 0;
            while(reader.Read())
            {
                phones[counter] = reader[0].ToString();
                comment[counter] = reader[1].ToString();
                counter += 1;
            }

            db2.closeConnection();
            db db3 = new db();
            db3.openConnection();
            MySqlCommand command1 = new MySqlCommand("SELECT `surname` from pacient where `phone` = @phone1 OR `phone` = @phone2 OR `phone` = @phone3 OR `phone` = @phone4 OR `phone` = @phone5", db3.getConnection());
            command1.Parameters.Add("@phone1", MySqlDbType.VarChar).Value = phones[0];
            command1.Parameters.Add("@phone2", MySqlDbType.VarChar).Value = phones[1];
            command1.Parameters.Add("@phone3", MySqlDbType.VarChar).Value = phones[2];
            command1.Parameters.Add("@phone4", MySqlDbType.VarChar).Value = phones[3];
            command1.Parameters.Add("@phone5", MySqlDbType.VarChar).Value = phones[4];
            MySqlDataReader reader1 = command1.ExecuteReader();
            int counter1 = 0;
            while (reader1.Read())
            {
                names[counter1] = reader1[0].ToString();
                counter1 += 1;
            }
            if (counter1 == 1)
            {
                name1.Text = names[0];
                name1.Visible = true;
                comment1.Text = comment[0];
                comment1.Visible = true;
            }
            else if (counter1 == 2)
            {
                name1.Text = names[0];
                name1.Visible = true;
                name2.Text = names[1];
                name2.Visible = true;
                comment1.Text = comment[0];
                comment1.Visible = true;
                comment2.Text = comment[1];
                comment2.Visible = true;
            }
            else if (counter1 == 3)
            {
                name1.Text = names[0];
                name1.Visible = true;
                name2.Text = names[1];
                name2.Visible = true;
                name3.Text = names[2];
                name3.Visible = true;
                comment1.Text = comment[0];
                comment1.Visible = true;
                comment2.Text = comment[1];
                comment2.Visible = true;
                comment3.Text = comment[2];
                comment3.Visible = true;
            }
            else if (counter1 == 4)
            {
                name1.Text = names[0];
                name1.Visible = true;
                name2.Text = names[1];
                name2.Visible = true;
                name3.Text = names[2];
                name3.Visible = true;
                name4.Text = names[3];
                name4.Visible = true;
                comment1.Text = comment[0];
                comment1.Visible = true;
                comment2.Text = comment[1];
                comment2.Visible = true;
                comment3.Text = comment[2];
                comment3.Visible = true;
                comment4.Text = comment[3];
                comment4.Visible = true;
            }
            else if (counter1 == 5)
            {
                name1.Text = names[0];
                name1.Visible = true;
                name2.Text = names[1];
                name2.Visible = true;
                name3.Text = names[2];
                name3.Visible = true;
                name4.Text = names[3];
                name4.Visible = true;
                name5.Text = names[4];
                name5.Visible = true;
                comment1.Text = comment[0];
                comment1.Visible = true;
                comment2.Text = comment[1];
                comment2.Visible = true;
                comment3.Text = comment[2];
                comment3.Visible = true;
                comment4.Text = comment[3];
                comment4.Visible = true;
                comment5.Text = comment[4];
                comment5.Visible = true;
            }
            db3.closeConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

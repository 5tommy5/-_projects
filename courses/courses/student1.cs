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

namespace courses
{
    public partial class student1 : Form
    {
        public student1()
        {
            InitializeComponent();
            date_pick.MaxSelectionCount = 1;

            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT surname FROM instructor", db1.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                instructor_box.Items.Add(reader[0]);
            }
            db1.closeConnection();
            time_box.Items.Add("10:30");
            time_box.Items.Add("11:45");
            time_box.Items.Add("13:00");
            time_box.Items.Add("14:15");
            time_box.Items.Add("15:30");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tt;
            tt = "first";
            int coop = 0;
            if (time_box.SelectedItem.ToString() == "10:30")
            {
                tt = "first";
                coop = 2;
            }
            else if (time_box.SelectedItem.ToString() == "11:45")
            {
                tt = "second";
                coop = 3;
            }
            else if (time_box.SelectedItem.ToString() == "13:00")
            {
                tt = "third";
                coop = 4;
            }
            else if (time_box.SelectedItem.ToString() == "14:15")
            {
                tt = "fourth";
                coop = 5;
            }
            else if (time_box.SelectedItem.ToString() == "15:30")
            {
                tt = "fifth";
                coop = 6;
            }

            DB db0 = new DB();
            db0.openConnection();
            MySqlDataAdapter adapter0 = new MySqlDataAdapter();
            MySqlCommand command0 = new MySqlCommand("select * from lessons where `instructor_surname` = @inst AND `date` = @date AND `time` = @time", db0.getConnection());
            command0.Parameters.Add("@inst", MySqlDbType.VarChar).Value = instructor_box.SelectedItem.ToString();
            command0.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
            command0.Parameters.Add("@time", MySqlDbType.VarChar).Value = time_box.Text;
            MySqlDataReader reader0 = command0.ExecuteReader();
            if (reader0.Read())
            {
                MessageBox.Show("This time is busy!");
                db0.closeConnection();
            }
            else
            {
                db0.closeConnection();
                DB db1 = new DB();
                db1.openConnection();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command1 = new MySqlCommand("select * from student where `phone` = @phone", db1.getConnection());
                command1.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox3.Text;
                MySqlDataReader reader1 = command1.ExecuteReader();
                if (reader1.Read())
                {
                    db1.closeConnection();
                    DB db = new DB();
                    db.openConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("INSERT INTO LESSONS (`instructor_surname`, `date`, `phone`, `time`) values (@inst, @date, @phone, @time) ", db.getConnection());
                    command.Parameters.Add("@inst", MySqlDbType.VarChar).Value = instructor_box.SelectedItem.ToString();
                    command.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
                    command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox3.Text;
                    command.Parameters.Add("@time", MySqlDbType.VarChar).Value = time_box.Text;
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Запись принята!");

                    }
                    db.closeConnection();
                }
                else
                {
                    db1.closeConnection();
                    MessageBox.Show("ERROR, NO SUCH STUDENT IN THE BASE!");
                }

            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("select * from student where `phone` = @phone", db1.getConnection());
            command1.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone_box.Text;
            MySqlDataReader reader1 = command1.ExecuteReader();
            if (reader1.Read())
            {
                MessageBox.Show("There is such phone in base!");
                db1.closeConnection();
            }

            else
            {


                DB db = new DB();
                db.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO student (`name`, `surname`, `phone`, `student_group`) values (@name, @surname, @phone, @group) ", db.getConnection());
                command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_box.Text;
                command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname_box.Text;
                command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone_box.Text;
                command.Parameters.Add("@group", MySqlDbType.VarChar).Value = group_box.Text;
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Registration succsecful!");

                }
                db.closeConnection();

            }
        }
    }
}

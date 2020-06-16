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
    public partial class instructor1 : Form
    {
        public instructor1()
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            first.Text = "";

            phone1.Text = "";
            phone2.Text = "";
            phone3.Text = "";
            phone4.Text = "";
            phone5.Text = "";
            group1.Text = "";



            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT  phone FROM lessons where `instructor_surname` = @inst and `date` = @date and `time` = '10:30'", db1.getConnection());
            command.Parameters.Add("@inst", MySqlDbType.VarChar).Value = instructor_box.SelectedItem.ToString();
            command.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
            MySqlDataReader reader = command.ExecuteReader();
            if(reader.Read())
            {
                phone1.Text = reader[0].ToString();
                phone1.Visible = true;
            }
            db1.closeConnection();


            //

            DB db2 = new DB();
            db2.openConnection();
            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlCommand command2 = new MySqlCommand("SELECT  phone FROM lessons where `instructor_surname` = @inst and `date` = @date and `time` = '11:45'", db2.getConnection());
            command2.Parameters.Add("@inst", MySqlDbType.VarChar).Value = instructor_box.SelectedItem.ToString();
            command2.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
            MySqlDataReader reader2 = command2.ExecuteReader();
            if (reader2.Read())
            {
                phone2.Text = reader2[0].ToString();
                phone2.Visible = true;
            }
            db2.closeConnection();

            //

            DB db3 = new DB();
            db3.openConnection();
            MySqlDataAdapter adapter3 = new MySqlDataAdapter();
            MySqlCommand command3 = new MySqlCommand("SELECT  phone FROM lessons where `instructor_surname` = @inst and `date` = @date and `time` = '13:00'", db3.getConnection());
            command3.Parameters.Add("@inst", MySqlDbType.VarChar).Value = instructor_box.SelectedItem.ToString();
            command3.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
            MySqlDataReader reader3 = command3.ExecuteReader();
            if (reader3.Read())
            {
                phone3.Text = reader3[0].ToString();
                phone3.Visible = true;
            }
            db3.closeConnection();

            //

            DB db4 = new DB();
            db4.openConnection();
            MySqlDataAdapter adapter4 = new MySqlDataAdapter();
            MySqlCommand command4 = new MySqlCommand("SELECT  phone FROM lessons where `instructor_surname` = @inst and `date` = @date and `time` = '14:15'", db4.getConnection());
            command4.Parameters.Add("@inst", MySqlDbType.VarChar).Value = instructor_box.SelectedItem.ToString();
            command4.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
            MySqlDataReader reader4 = command4.ExecuteReader();
            if (reader4.Read())
            {
                phone4.Text = reader4[0].ToString();
                phone4.Visible = true;
            }
            db4.closeConnection();

            //

            DB db5 = new DB();
            db5.openConnection();
            MySqlDataAdapter adapter5 = new MySqlDataAdapter();
            MySqlCommand command5 = new MySqlCommand("SELECT  phone FROM lessons where `instructor_surname` = @inst and `date` = @date and `time` = '15:30'", db5.getConnection());
            command5.Parameters.Add("@inst", MySqlDbType.VarChar).Value = instructor_box.SelectedItem.ToString();
            command5.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
            MySqlDataReader reader5 = command5.ExecuteReader();
            if (reader5.Read())
            {
                phone5.Text = reader5[0].ToString();
                phone5.Visible = true;
            }
            db5.closeConnection();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db5 = new DB();
            db5.openConnection();
            MySqlDataAdapter adapter5 = new MySqlDataAdapter();
            MySqlCommand command5 = new MySqlCommand("SELECT  surname, student_group FROM student where `phone` = @phone", db5.getConnection());
            command5.Parameters.Add("@phone", MySqlDbType.VarChar).Value = textBox1.Text;
            MySqlDataReader reader5 = command5.ExecuteReader();
            if (reader5.Read())
            {
                first.Text = reader5[0].ToString();
                group1.Text = reader5[1].ToString();
                first.Visible = true;
                group1.Visible = true;
            }
            db5.closeConnection();
        }
    }
}

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
    public partial class admin : Form
    {
        public admin()
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
                doctor_box.Items.Add(reader[0]);
            }
            db1.closeConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db db2 = new db();
            db2.openConnection();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT NAME, SURNAME FROM PACIENT WHERE PHONE = @PHONE;", db2.getConnection());
            command1.Parameters.Add("@PHONE", MySqlDbType.VarChar).Value = phone_box1.Text;
            MySqlDataReader reader = command1.ExecuteReader();
            String pacient_name;
            String pacient_surname;
            if (reader.Read())
            {

                pacient_name = reader[0].ToString();
                pacient_surname = reader[1].ToString();
                db2.closeConnection();

                // До этого момента мы проверили ли есть такой человек в базе, сейчас будем проверять ли у этого доктора на эту дату есть места
                // Максимум мест для доктора на один день - 5
                db db3 = new db();
                db3.openConnection();
                MySqlDataAdapter adapter2 = new MySqlDataAdapter();
                MySqlCommand command2 = new MySqlCommand("SELECT * FROM priyom WHERE `doctor_surname` = @doctor_surname AND `date` = @date", db3.getConnection());
                command2.Parameters.Add("@doctor_surname", MySqlDbType.VarChar).Value = doctor_box.SelectedItem.ToString();
                command2.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
                MySqlDataReader reader3 = command2.ExecuteReader();
                int counter = 0;
                while (reader3.Read())
                    counter += 1;
                if (counter >= 5)
                {
                    MessageBox.Show("К сожалению в этот день доктор занят!");
                    db3.closeConnection();
                }
                else
                {
                    db3.closeConnection();
                    db db1 = new db();
                    db1.openConnection();
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    MySqlCommand command = new MySqlCommand("INSERT INTO priyom (`phone`, `doctor_surname`, `date`, `comment`) VALUES (@phone, @doctor_surname, @date, @comment);", db1.getConnection());
                    command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone_box1.Text;
                    command.Parameters.Add("@doctor_surname", MySqlDbType.VarChar).Value = doctor_box.SelectedItem.ToString();
                    command.Parameters.Add("@date", MySqlDbType.Date).Value = date_pick.SelectionRange.Start;
                    command.Parameters.Add("@comment", MySqlDbType.VarChar).Value = comment.Text;
                    if (command.ExecuteNonQuery() == 1)
                        MessageBox.Show(String.Format("{0} {1} успешно записан на прием", pacient_name, pacient_surname));
                    else
                        MessageBox.Show("Возникла ошибка");
                    db1.closeConnection();
                    comment.Text = "";
                }

            }
            else
            {
                MessageBox.Show("Такого пациента нету в базе!");
                db2.closeConnection();
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            db db1 = new db();
            db1.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO pacient (`name`, `surname`, `phone`) VALUES (@name, @surname, @phone);", db1.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name_box.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = Surname_box.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone_box2.Text;

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show(String.Format("{0} {1} успешно добавлен в базу!", name_box.Text, Surname_box.Text));
            else
                MessageBox.Show("Возникла ошибка");
            db1.closeConnection();
        }
    }
}

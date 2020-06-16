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

namespace Stomotalogia
{
    public partial class Owner : Form
    {
        public Owner(string ownerid)
        {
            InitializeComponent();
            string id = ownerid;
        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("UPDATE `personal` SET `work_days` = @days WHERE `personal`.`login` = @login", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_change.Text;
            command.Parameters.Add("@days", MySqlDbType.VarChar).Value = new_change.Text;
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("График успешно изменен!");
            }
            else
                MessageBox.Show("Ошибка");
            db.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("INSERT INTO `personal` (`ID`, `name`, `surname`, `login`, `password`, `position`, `work_time_start`, `work_time_end`, `work_days`) VALUES(NULL, @name, @surname, @login, @password, @pos, @st_time, @end_time, @days)", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_new.Text;
            command.Parameters.Add("@days", MySqlDbType.VarChar).Value = work_days.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;
            command.Parameters.Add("@pos", MySqlDbType.VarChar).Value = position.Text;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@st_time", MySqlDbType.VarChar).Value = start_day.Text;
            command.Parameters.Add("@end_time", MySqlDbType.VarChar).Value = end_day.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Вы успешно наняли работника!");
            else
                MessageBox.Show("Ошибка!");
            db.closeConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM `personal` WHERE `personal`.`login` = @login", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login_delete.Text;
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Вы успешно уволили работника!  за что???");
            else
                MessageBox.Show("Ошибка!");
            db.closeConnection();
        }
    }
}

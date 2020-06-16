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
    public partial class Admin : Form
    {
        public Admin(string adminid)
        {
            InitializeComponent();
            string id = adminid;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            errorlabel.Visible = false;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT name, surname, id FROM patient WHERE phone = @phone", db.getConnection());
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone.Text;
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                patname.Text = reader[0].ToString();
                patsur.Text = reader[1].ToString();
                patid.Text = reader[2].ToString();
                patname.Visible = true;
                patsur.Visible = true;
                patid.Visible = true;
                db.closeConnection();
            }
            else
            {
                errorlabel.Visible = true;
                patname.Visible = false;
                patsur.Visible = false;
                patid.Visible = false;
                db.closeConnection();

            }



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void newus_Click(object sender, EventArgs e)
        {
            sucsses.Visible = false;
            errornewpatient.Visible = false;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO patient (`ID`, `name`, `surname`, `phone`) VALUES (NULL, @name, @surname, @phone);", db.getConnection());
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = namebox.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surbox.Text;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phonebox.Text;
            if(String.IsNullOrEmpty(namebox.Text) || String.IsNullOrEmpty(surbox.Text) || String.IsNullOrEmpty(phonebox.Text) || namebox.TextLength> 25 || surbox.TextLength>25 || phonebox.TextLength != 10)
                errornewpatient.Visible = true;
            else if (command.ExecuteNonQuery() == 1)
                sucsses.Visible = true;
            else
                errornewpatient.Visible = true;
            db.closeConnection();

        }

        private void errornewpatient_Click(object sender, EventArgs e)
        {
            if (errornewpatient.Visible)
                errornewpatient.Visible = false;
        }

        private void sucsses_Click(object sender, EventArgs e)
        {
            if (sucsses.Visible)
                sucsses.Visible = false;
        }

        private void errorlabel_Click(object sender, EventArgs e)
        {
            if (errorlabel.Visible)
                errorlabel.Visible = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            success_talon.Visible = false;
            error_talon.Visible = false;
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MessageBox.Show(date_box.Value.DayOfWeek.ToString());
            string day = "1";
            if (date_box.Value.DayOfWeek.ToString() == "Monday")
                day = "1";
            else if (date_box.Value.DayOfWeek.ToString() == "Tuesday")
                day = "2";
            else if (date_box.Value.DayOfWeek.ToString() == "Wednesday")
                day = "3";
            else if (date_box.Value.DayOfWeek.ToString() == "Thursday")
                day = "4";
            else if (date_box.Value.DayOfWeek.ToString() == "Friday")
                day = "5";
            else if (date_box.Value.DayOfWeek.ToString() == "Saturday")
                day = "6";
            else if (date_box.Value.DayOfWeek.ToString() == "Sunday")
                day = "7";
            MessageBox.Show(day);
            string sqlcmd = String.Format("select ID from personal where `position` = 'doc' and `work_time_start`<=@time and `work_time_end`>=@time and `work_days` LIKE \"%{0}%\"", day);
            MySqlCommand cmd = new MySqlCommand(sqlcmd, db.getConnection());


            cmd.Parameters.Add("@time", MySqlDbType.Int16).Value = time_box.Text;
            //cmd.Parameters.Add("@time2", MySqlDbType.Int16).Value = Int16.Parse(time_box.Text);
            cmd.Parameters.Add("@day", MySqlDbType.VarChar).Value = day;
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                doc_id_box.Text = read[0].ToString();
                db.closeConnection();
            }
            //db.openConnection();
            //до этого мы узнавали какой доктор принимает в этот день в такое время
            //теперь мы проверяем ли не забит у него график
            int na_zapas = Int16.Parse(time_box.Text);
            int minutes_upper = Int16.Parse(time_box.Text);
            int minutes_down = Int16.Parse(time_box.Text);
            if (Int16.Parse(time_box.Text) % 100 >= 30)
            {
                int kek = Int16.Parse(time_box.Text) % 100 - 30;

                minutes_down = minutes_down - 30;
                minutes_upper = minutes_down + 100 - minutes_down % 10 + (10 - minutes_down % 10);
            }
            else
            {
                int kek = Int16.Parse(time_box.Text) % 100 + 30;
                minutes_down = minutes_down - 100 - kek;
                minutes_upper = minutes_upper + 30;
                minutes_down = minutes_upper - 100 - minutes_upper % 10 + (10 - minutes_upper % 10);
            }


            db.openConnection();

            MySqlDataAdapter adapter2 = new MySqlDataAdapter();
            MySqlCommand cmd1 = new MySqlCommand("select `seans_time` from talon where `doctor_id` = @doc_id and `seaans_date` = @date and `seans_time` BETWEEN @down and @upper ORDER BY `seans_time` ASC ", db.getConnection());
            cmd1.Parameters.Add("@doc_id", MySqlDbType.Int16).Value = Int32.Parse(doc_id_box.Text);
            cmd1.Parameters.Add("@down", MySqlDbType.Int16).Value = minutes_down;
            cmd1.Parameters.Add("@upper", MySqlDbType.Int16).Value = minutes_upper;
            cmd1.Parameters.Add("@date", MySqlDbType.DateTime).Value = date_box.Value.Date;
            MySqlDataReader reader = cmd1.ExecuteReader();

            if (reader.Read())
            {

                if (Int16.Parse(reader[0].ToString()) % 100 >= 30)
                {
                    minutes_down = Int16.Parse(reader[0].ToString()) % 100 - 30;
                    minutes_upper = minutes_down + 100 - minutes_down % 10 + (10 - minutes_down % 10);
                    if (reader.Read())
                    {
                        minutes_upper = Int16.Parse(reader[0].ToString()) % 100 + 30;
                        minutes_down = minutes_upper - 100 - minutes_upper % 10 + (10 - minutes_upper % 10);

                    }
                }
                
                else
                {
                    minutes_upper = Int16.Parse(reader[0].ToString()) % 100 + 30;
                    minutes_down = minutes_upper - 100 - minutes_upper % 10 + (10 - minutes_upper % 10);

                }
                no_time.Visible = true;
                db.closeConnection();
                db.openConnection();
                MySqlDataAdapter adapter3 = new MySqlDataAdapter();
                MySqlCommand cmd2 = new MySqlCommand("select `seans_time` from talon where `doctor_id` = @doc_id1 and `seaans_date` = @date1 and `seans_time` BETWEEN @down1 and @upper1 ", db.getConnection());
                cmd1.Parameters.Add("@doc_id1", MySqlDbType.Int16).Value = Int32.Parse(doc_id_box.Text);
                cmd1.Parameters.Add("@down1", MySqlDbType.Int16).Value = minutes_down;
                cmd1.Parameters.Add("@upper1", MySqlDbType.Int16).Value = minutes_upper;
                cmd1.Parameters.Add("@date1", MySqlDbType.DateTime).Value = date_box.Value.Date;
                MySqlDataReader reader1 = cmd1.ExecuteReader();

                if (reader1.Read())
                {

                    MessageBox.Show("В этот день подходящее для вас время забито, попробуйте другой день!");

                    db.closeConnection();
                }

                else
                {

                    db.closeConnection();
                }



            }

            else
            {
                db.closeConnection();
                db.openConnection();
                MySqlDataAdapter adapter1 = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("INSERT INTO talon (`doctor_id`, `patient_id`, `seaans_date`, `seans_time`) VALUES (@doc_id, @pat_id, @date, @time)", db.getConnection());
                if (String.IsNullOrEmpty(doc_id_box.Text) || String.IsNullOrEmpty(pat_id_box.Text) || String.IsNullOrEmpty(date_box.Text))
                {
                    error_talon.Visible = true;
                }
                else
                {
                    command.Parameters.Add("@doc_id", MySqlDbType.Int16).Value = Int32.Parse(doc_id_box.Text);
                    command.Parameters.Add("@pat_id", MySqlDbType.Int16).Value = Int32.Parse(pat_id_box.Text);
                    command.Parameters.Add("@date", MySqlDbType.DateTime).Value = date_box.Value.Date;
                    command.Parameters.Add("@time", MySqlDbType.VarChar).Value = time_box.Text;
                    if (command.ExecuteNonQuery() == 1)
                        success_talon.Visible = true;
                    else
                        error_talon.Visible = true;
                }
                db.closeConnection();
            }
        }

        private void success_talon_Click(object sender, EventArgs e)
        {
            if (success_talon.Visible)
                success_talon.Visible = false;
        }

        private void error_talon_Click(object sender, EventArgs e)
        {
            if (error_talon.Visible)
                error_talon.Visible = false;
        }

        private void no_time_Click(object sender, EventArgs e)
        {
            if (no_time.Visible)
                no_time.Visible = false;
        }
    }
}

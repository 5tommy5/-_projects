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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        int exit_counter = 2;
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String login_Personal = LoginField.Text;
            String pass = PassField.Text;

            DB db = new DB();
            db.openConnection();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM personal WHERE login = @p_l AND password = @p_s", db.getConnection());
            command.Parameters.Add("@p_l", MySqlDbType.VarChar).Value = login_Personal;
            command.Parameters.Add("@p_s", MySqlDbType.VarChar).Value = pass;
            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MySqlCommand cmd = new MySqlCommand("select position from personal where login = @p_l", db.getConnection());
                cmd.Parameters.Add("@p_l", MySqlDbType.VarChar).Value = login_Personal;
                string position = cmd.ExecuteScalar().ToString();
                MessageBox.Show(position);
                MySqlCommand cmd1 = new MySqlCommand("select id from personal where login = @p_l", db.getConnection());
                cmd1.Parameters.Add("@p_l", MySqlDbType.VarChar).Value = login_Personal;
                string id = cmd1.ExecuteScalar().ToString();
                if (position == "own")
                {
                    Owner form2 = new Owner(id);
                    form2.Show();
                    Hide();
                    db.closeConnection();
                }
                /*else if(position == "doc")
                {
                    Doctor form2 = new Doctor(id);
                    form2.Show();
                    Hide();
                    db.closeConnection();
                }*/
                else if (position == "adm")
                {
                    Admin form2 = new Admin(id);
                    form2.Show();
                    Hide();
                    db.closeConnection();
                }

                exit_counter = 3;

            }

            else
            {
                MessageBox.Show(String.Format("Данные неверные! Осталось {0} попыток", exit_counter));
                exit_counter = exit_counter - 1;

                if (exit_counter < 0)
                {
                    db.closeConnection();
                    Close();
                }
            }




        }
    }
}

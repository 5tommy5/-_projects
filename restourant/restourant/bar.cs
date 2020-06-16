using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restourant
{
    public partial class bar : Form
    {
        Dictionary<int, string> z_dic = new Dictionary<int, string>();
        public bar()
        {

            InitializeComponent();
            var myThread = new Thread(update);

            TimerCallback tm = new TimerCallback(update);
            // создаем таймер

            System.Threading.Timer timer = new System.Threading.Timer(tm, null, 0, 5000);
            num_box.SelectedIndexChanged += new EventHandler(this.num_box_SelectedIndexChanged);
        }
        private void num_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            zakaz_box.Clear();
            if (num_box.SelectedIndex != -1)
                ready.Enabled = true;
            string s = z_dic[Int32.Parse(num_box.SelectedItem.ToString())];
            int found = s.IndexOf(": ");
            zakaz_box.Text = s.Substring(found + 2);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void update(object ob)
        {

            Thread.Sleep(600);

            Action action2 = () => num_box.Items.Clear();
            if (InvokeRequired)
                Invoke(action2);
            //zakaz_box.Clear();
            z_dic.Clear();
            DB db = new restourant.DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT ID, z_text FROM zakaz where `ready` = 0 and `z_type` = 'Бар'", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            Action action = () => num_box.Items.Add(reader[0]);
            while (reader.Read())
            {

                if (InvokeRequired)
                {
                    Invoke(action);
                    z_dic.Add(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                }
                else
                {
                    action();
                    z_dic.Add(Int32.Parse(reader[0].ToString()), reader[1].ToString());
                }

            }
            db.closeConnection();
        }

        /*private void ready_Click(object sender, EventArgs e)
        {
            /* int price = 0;
             DB db1 = new DB();
             db1.openConnection();
             MySqlDataAdapter adapter1 = new MySqlDataAdapter();
             MySqlCommand command1 = new MySqlCommand("SELECT price FROM zakaz WHERE `ID` = @id", db1.getConnection());
             command1.Parameters.Add("@id", MySqlDbType.Int32).Value = Int32.Parse(num_list.SelectedItem.ToString());
             MySqlDataReader reader = command1.ExecuteReader();
             if (reader.Read())
                 price = Int32.Parse(reader[0].ToString());
             db1.closeConnection();//
            DB db = new restourant.DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `zakaz` SET `ready` = '1' WHERE `ID` = @id;", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Int32.Parse(num_box.SelectedItem.ToString());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Сообщение отослано официанту!");
            }
            db.closeConnection();
            zakaz_box.Clear();
            ready.Enabled = false;
        }*/

        private void ready_Click_1(object sender, EventArgs e)
        {
            if (num_box.SelectedIndex != -1)
            {
                DB db = new restourant.DB();
                db.openConnection();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("UPDATE `zakaz` SET `ready` = '1' WHERE `ID` = @id;", db.getConnection());
                command.Parameters.Add("@id", MySqlDbType.Int32).Value = Int32.Parse(num_box.SelectedItem.ToString());
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Сообщение отослано официанту!");
                }
                db.closeConnection();
                zakaz_box.Clear();
                ready.Enabled = false;
            }
        }
    }
}
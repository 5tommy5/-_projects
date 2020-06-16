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
    public partial class offic : Form
    {
        static System.Windows.Forms.Timer myTimer = new System.Windows.Forms.Timer();

        public offic()
        {

            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 11000;
            myTimer.Start();
            var myThread = new Thread(update);
            myThread.Start(); //метод выполняется в другом потоке
            InitializeComponent();
            type_box.Items.Add("Кухня");
            type_box.Items.Add("Бар");
            table_box.Items.Add("1");
            table_box.Items.Add("2");
            table_box.Items.Add("3");
            table_box.Items.Add("4");
            table_box.Items.Add("5");
            table_box.Items.Add("6");
            table_box.Items.Add("7");
            table_box.Items.Add("8");
            table_box.Items.Add("9");
            table_box.Items.Add("10");

            TimerCallback tm = new TimerCallback(update);
            // создаем таймер

            System.Threading.Timer timer = new System.Threading.Timer(tm, null, 0, 10000);
        }
        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            myTimer.Stop();
            Thread.Sleep(500);
            Action action = () => num_list.Visible = true;
            Action action1 = () => table_list.Visible = true;
            Action action2 = () => loading.Visible = false;


            if (InvokeRequired)
            {
                Invoke(action);
                Invoke(action1);
                Invoke(action2);

            }
            else
            {
                action();
                action1();
                action2();
            }
        }
        public void update(object ob)
        {

            Thread.Sleep(600);


            DB db = new restourant.DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT ID, z_table FROM zakaz where `ready` = 1", db.getConnection());
            MySqlDataReader reader = command.ExecuteReader();
            Action action = () => num_list.Items.Add(reader[0]);
            Action action1 = () => table_list.Items.Add(reader[1].ToString());
            Action action2 = () => table_list.Items.Clear();
            Action action3 = () => num_list.Items.Clear();
            if (InvokeRequired)
            {
                Invoke(action2);
                Invoke(action3);
            }
            else
            {
                action2();
                action3();
            }
            while (reader.Read())
            {
                if (InvokeRequired)
                {
                    Invoke(action);
                    Invoke(action1);
                }
                else
                {
                    action();
                    action1();
                }
                    
            }
            db.closeConnection();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pay_Click(object sender, EventArgs e)
        {
            int price = 0;
            DB db1 = new DB();
            db1.openConnection();
            MySqlDataAdapter adapter1 = new MySqlDataAdapter();
            MySqlCommand command1 = new MySqlCommand("SELECT price FROM zakaz WHERE `ID` = @id", db1.getConnection());
            command1.Parameters.Add("@id", MySqlDbType.Int32).Value = Int32.Parse(num_list.SelectedItem.ToString());
            MySqlDataReader reader = command1.ExecuteReader();
            if (reader.Read())
                price = Int32.Parse(reader[0].ToString());
            db1.closeConnection();
            DB db = new restourant.DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("DELETE FROM zakaz WHERE `ID` = @id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = Int32.Parse(num_list.SelectedItem.ToString());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show(String.Format("Оплатите {0} грн",price));
            }
            db.closeConnection();
            zakaz_box.Clear();
        }

        private void add_Click(object sender, EventArgs e)
        {
            DB db = new restourant.DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO zakaz (`z_type`, `z_table`, `z_text`,  `price`, `ready`) VALUES (@type, @table, @text, @price, 0);", db.getConnection());
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type_box.SelectedItem.ToString();
            command.Parameters.Add("@table", MySqlDbType.Int32).Value = table_box.SelectedItem.ToString();
            command.Parameters.Add("@text", MySqlDbType.VarChar).Value = zakaz_box.ToString();
            command.Parameters.Add("@price", MySqlDbType.Int32).Value = Int32.Parse(price.Text.ToString());
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Заказ отправлен!");
            }
            db.closeConnection();
        }
    }
}

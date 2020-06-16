using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rieltor
{
    public struct ogolosh
    {
        public string city;
        public string region;
        public int square;
        public int san;
        public int bed;
        public int center;
        public int metro;
        public string name;
        public string surname;
        public string phone;
        public int price;
        public ogolosh(string c, string r, int s, int san, int bed, int cen, int metro, string name, string surname, string phone, int price)
        {
            this.city = c;
            this.region = r;
            this.square = s;
            this.san = san;
            this.bed = bed;
            this.center = cen;
            this.metro = metro;
            this.name = name;
            this.surname = surname;
            this.phone = phone;
            this.price = price;
        }
    }
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

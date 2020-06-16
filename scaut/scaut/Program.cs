using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scaut
{
    public struct footballer
    {
        public string name;
        public string surname;
        public int height;
        public int weight;
        public string position;
        public string nation;
        public string club;
        public int years;
        public footballer(string name, string surname, int height, int weight, string position, string nation, string club, int years)
        {
            this.name = name;
            this.surname = surname;
            this.height = height;
            this.weight = weight;
            this.position = position;
            this.nation = nation;
            this.club = club;
            this.years = years;
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
            Application.Run(new select());
        }

    }
}

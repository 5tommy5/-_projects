using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rieltor
{
    public partial class result : Form
    {
        public result(List<ogolosh> o)
        {
            InitializeComponent();
            foreach(ogolosh i in o)
            {
                city.Items.Add(i.city);
                region.Items.Add(i.region);
                square.Items.Add(i.square);
                bad.Items.Add(i.bed);
                san.Items.Add(i.san);
                center.Items.Add(i.center);
                metro.Items.Add(i.metro);
                name.Items.Add(i.name);
                surname.Items.Add(i.surname);
                phone.Items.Add(i.phone);
                price.Items.Add(i.price);
            }
        }
    }
}

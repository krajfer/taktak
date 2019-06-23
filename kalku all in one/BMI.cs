using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalku_all_in_one
{
    public partial class BMI : UserControl
    {
        public BMI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //połaczenie się z stroną która Oblicza BMI
            webBrowser1.Navigate("http://oblicz-bmi.pl/");

        }
    }
}

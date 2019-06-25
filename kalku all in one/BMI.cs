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
        ///połaczenie się z stroną która Oblicza BMI
        private void button1_Click(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate("http://oblicz-bmi.pl/");

        }

        private void BMI_Load(object sender, EventArgs e)
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalku_all_in_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        ///ukrywanie wszystkich kontrolek podczas włączenia programu
        private void Form1_Load(object sender, EventArgs e)
        { 
           
            kalkulator1.Hide();
            jednostki__i_miary1.Hide();
            konwenter1.Hide();
            temperatura1.Hide();
            bmi1.Hide();
        }

   

        private void kalkulatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void konwenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void jednostkiIMiaryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        ///ukrywanie wszystkich innych kontrolek oraz wyswietlanie aktualnie potrzebnej
        private void kalkulatorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
            jednostki__i_miary1.Hide();
            konwenter1.Hide();
            temperatura1.Hide();
            bmi1.Hide();

            kalkulator1.Show();
            kalkulator1.BringToFront();
        }
        ///ukrywanie wszystkich innych kontrolek oraz wyswietlanie aktualnie potrzebnej
        private void konwenterToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
        
            kalkulator1.Hide();
            jednostki__i_miary1.Hide();
            temperatura1.Hide();
            bmi1.Hide();

            konwenter1.Show();
            konwenter1.BringToFront();
        }
        ///ukrywanie wszystkich innych kontrolek oraz wyswietlanie aktualnie potrzebnej
        private void jednostkiIMiaryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            kalkulator1.Hide();
            konwenter1.Hide();
            temperatura1.Hide();
            bmi1.Hide();

            jednostki__i_miary1.Show();
            jednostki__i_miary1.BringToFront();
        }

        private void kalkulator1_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// zamyka aplikacje
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void wyjscieToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            this.Close();
        }
        ///ukrywanie wszystkich innych kontrolek oraz wyswietlanie aktualnie potrzebnej
        private void termometrToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            kalkulator1.Hide();
            konwenter1.Hide();
            jednostki__i_miary1.Hide();
            bmi1.Hide();


            temperatura1.Show();
            temperatura1.BringToFront();
        }
        ///informacje o autorze
        private void autorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Autor: Bartlomiej Puzio", "informacje o Autorze");
        }
        ///ukrywanie wszystkich innych kontrolek oraz wyswietlanie aktualnie potrzebnej
        private void bMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kalkulator1.Hide();
            jednostki__i_miary1.Hide();
            konwenter1.Hide();
            temperatura1.Hide();

            bmi1.Show();
            bmi1.BringToFront();
        }
    }
}

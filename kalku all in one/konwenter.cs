﻿using System;
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
    public partial class konwenter : UserControl
    {
        public konwenter()
        {
            InitializeComponent();
        }
        ///połaczenie się z stroną http://www.convertmymoney.com/ która posiada aktualne kursy walut
        private void button1_Click(object sender, EventArgs e)
        {
           
            webBrowser1.Navigate("http://www.convertmymoney.com/");
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void konwenter_Load(object sender, EventArgs e)
        {
            
        }
    }
}

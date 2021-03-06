﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GraMatematycznyDeszcz
{   
    /// <summary>
    /// Klasa okna zapisu gry
    /// </summary>
    public partial class Form2 : Form
    {
        /// <summary>
        /// Konstruktor końcowej formy (okienka zapisu)
        /// </summary>
        public Form2()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gamer = textBox1.Text + " " + GameForm.finalGameScore + " " + DateTime.Now.ToString();
            File.AppendAllText("wyniki.txt", gamer + Environment.NewLine);
            this.Close();
            this.Dispose();
        }
    }
}

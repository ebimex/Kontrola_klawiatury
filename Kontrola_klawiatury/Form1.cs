using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kontrola_klawiatury
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            textBox1.Text = e.KeyCode.ToString();                            // pokazuj naciśnięte klawaisze na kalwiaturze żeby widzieć ich nazwę

            if (e.KeyValue == (char)Keys.P) MessageBox.Show("Wciśnięto P");
            if (e.KeyValue == (char)Keys.Escape) MessageBox.Show("Wciśnięto ESC");
            if (e.KeyValue == (char)Keys.F4) MessageBox.Show("Wciśnięto F4");

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Ime = textBox1.Text;
            string ImeOca = textBox2.Text;
            string Prezime = textBox3.Text;
            string Index = textBox4.Text;
            string Program = comboBox1.SelectedItem.ToString();
            DateTime Datum = dateTimePicker1.Value;
    
                if (radioButton1.Checked)
                 textBox5.AppendText(" Muski pol ");
            if (radioButton2.Checked)
                textBox5.AppendText(" Zenski pol ");

            textBox5.AppendText( " " + Ime + " " + ImeOca + " " + Prezime + " " + Index + " " + Program + " " + Datum.ToShortDateString());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
    }
}

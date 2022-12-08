using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individual_Assignment_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pet pet = new Pet(
                textBox1.Text, comboBox1.Text, numericUpDown1.Value);
            MessageBox.Show(
                $"Created Pet class\nName: {pet.Name}\nType: {pet.Type}\nAge: {pet.Age}");
        }
    }
}

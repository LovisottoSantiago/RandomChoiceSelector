using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace RandomChoiceSelector {
    public partial class Form1 : Form {

        private ArrayList strings;
        public Form1() {
            InitializeComponent();
            strings = new ArrayList();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
        }

        private void button1_Click_1(object sender, EventArgs e) {

            if (!string.IsNullOrWhiteSpace(option_1.Text)) {
                strings.Add(option_1.Text);
            }
            if (!string.IsNullOrWhiteSpace(option_2.Text)) {
                strings.Add(option_2.Text);
            }
            if (!string.IsNullOrWhiteSpace(option_3.Text)) {
                strings.Add(option_3.Text);
            }
            if (!string.IsNullOrWhiteSpace(option_4.Text)) {
                strings.Add(option_4.Text);
            }

            if (strings.Count == 0) {
                finalResult.Text = "No ingresaste ningun valor.";
            }
            else if (strings.Count == 1) {
                finalResult.Text = "Ingresaste 1 valor solo.";
            }
            else {
                string result = randomChoice(strings);
                finalResult.Text = "La opción elegida es: " + result + ".";            
            } 
        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private String randomChoice(ArrayList array) {
            Random randomSelector = new Random();
            int result = randomSelector.Next(0, array.Count);
            return (string)array[result];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}

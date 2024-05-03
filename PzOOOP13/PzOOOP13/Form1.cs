using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PzOOOP13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
     
         }
        

        private void UpdateCalories()
        {
            if (double.TryParse(textBox1.Text, out double totalCalories) &&
                double.TryParse(textBox3.Text, out double numServings))
            {
                double servingWeight = double.TryParse(textBox4.Text, out double parsedServingWeight) ? parsedServingWeight : 0.0;

                double caloriesPerServing = totalCalories / numServings;

                string resultText = $"Кількість калорій на порцію: {caloriesPerServing}\n";
                resultText += $"Загальна маса товару: {servingWeight * numServings}";

                label5.Text = resultText;
            }
        }
   
        private void extBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateCalories();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            UpdateCalories();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            UpdateCalories();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            UpdateCalories();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            UpdateCalories();
        }
    }
}

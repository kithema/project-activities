using System;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace pp43
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double temperature = Convert.ToDouble(textBox1.Text);
                double result;

                if (radioButton1.Checked)
                {
                    result = CelsiusToFahrenheit(temperature);
                    result = Math.Round(result, 2);
                    label3.Text = temperature + "°C = " + result + "°F";
                }
                else if (radioButton2.Checked)
                {
                    result = FahrenheitToCelsius(temperature);
                    result = Math.Round(result, 2);
                    label3.Text = temperature + "°F = " + result + "°C";
                }
                else
                {
                    label3.Text = "Выберите направление конвертации.";
                }
            }
            catch
            {
                label3.Text = "Введите корректное число.";
            }
        }
    }
}
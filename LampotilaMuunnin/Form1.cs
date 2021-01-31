using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// @author Samul1
/// version 31.01.2021
/// 
/// <summary>
/// Program will convert temperature.
/// Celcius - Fahrenheit - Kelvin
/// </summary>
namespace LampotilaMuunnin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // create a text array for your comboBoxes
            string[] a = { "Celcius", "Fahrenheit", "Kelvin" }; 
            string[] b = { "Fahrenheit", "Celcius", "Kelvin" };
            // adds text from arrays to the comboBoxes
            comboBox1.DataSource = a;
            comboBox2.DataSource = b;
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double startingTemp, resultTemp;
            // sta
            startingTemp = double.Parse(textBox1.Text);
            // Converting Celcius to Fahrenheit
            if (comboBox1.Text == "Celcius" && comboBox2.Text == "Fahrenheit")
            {
                resultTemp = ((startingTemp * 1.8) + 32);
                txtBoxAnswer.Text = resultTemp.ToString("0.0" + " °F");
            }
            // Converting Kelvin to Fahrenheit
            if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Fahrenheit")
            {
                resultTemp = ((startingTemp * 1.8) - 459.67);
                txtBoxAnswer.Text = resultTemp.ToString("0.0" + " °F");
            }
            // Converting Fahrenheit to Celcius
            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Celcius")
            {
                resultTemp = ((startingTemp - 32) / 1.8);
                txtBoxAnswer.Text = resultTemp.ToString("0.0" + " °C");
            }
            // Converting Kelvin to Celcius
            if (comboBox1.Text == "Kelvin" && comboBox2.Text == "Celcius")
            {
                resultTemp = (startingTemp - 273.15);
                txtBoxAnswer.Text = resultTemp.ToString("0.0" + " °C");
            }
            // Converting Celcius to Kelvin
            if (comboBox1.Text == "Celcius" && comboBox2.Text == "Kelvin")
            {
                resultTemp = (startingTemp + 273.15);
                txtBoxAnswer.Text = resultTemp.ToString("0.0" + " K");
            }
            // Converting Fahrenheit to Kelvin
            if (comboBox1.Text == "Fahrenheit" && comboBox2.Text == "Kelvin")
            {
                resultTemp = ((startingTemp + 459.67) / 1.8);
                txtBoxAnswer.Text = resultTemp.ToString("0.0" + " K");
            }
        }
    }
}

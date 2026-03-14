using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// celcius -> fahrenheit
// celcius -> reamur
// celcius -> kelvin 

// fahrenheit -> celcius
// fahrenheit -> reamur
// fahrenheit -> kelvin



namespace Modul3_103022400032
{
    public partial class Form1 : Form
    {
        private double nilaiAkhir = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("masukkan angka yang valid");
            } else if (comboBox1.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("masukkan satuan terlebih dahulu");
            }


            if (comboBox1.Text.ToLower() == "celcius")
            {
                if (comboBox2.Text.ToLower() == "reamur")
                {
                    //setValue(celciusToReamur(Convert.ToDouble(textBox1.Text));
                } else if (comboBox2.Text.ToLower() == "fahrenheit")
                {

                } else if (comboBox2.Text.ToLower() == "kelvin")
                {

                }

            } else if (comboBox1.Text.ToLower() == "reamur")
            {
                if (comboBox2.Text.ToLower() == "celcius")
                {

                }
                else if (comboBox2.Text.ToLower() == "fahrenheit")
                {

                }
                else if (comboBox2.Text.ToLower() == "kelvin")
                {

                }

            } else if (comboBox1.Text.ToLower() == "fahrenheit")
            {
                if (comboBox2.Text.ToLower() == "reamur")
                {

                }
                else if (comboBox2.Text.ToLower() == "celcius")
                {

                }
                else if (comboBox2.Text.ToLower() == "kelvin")
                {

                }

            } else if (comboBox1.Text.ToLower() == "kelvin")
            {
                if (comboBox2.Text.ToLower() == "reamur")
                {

                }
                else if (comboBox2.Text.ToLower() == "fahrenheit")
                {

                }
                else if (comboBox2.Text.ToLower() == "celcius")
                {

                }

            }
        }

        private void setValue(double value)
        {
            nilaiAkhir = value;
            textBox2.Text = nilaiAkhir.ToString();
        }

        private double celciusToReamur(double input)
        {
            return 4.0 / 5.0 * input;
        }

        private double celciusToFahrenheit(double input)
        {
            return 9.0 / 5.0 * input + 32;
        }

        private double celciusToKelvin(double input)
        {
            return input + 273;
        }
        private double reamurToCelcius(double input)
        {
            return 5.0 / 4 / 0 * input;
        }

        private double reamurToFahrenheit(double input)
        {
            return 9.0 / 4.0 * input + 32;
        }
        private double reamurToKelvin(double input)
        {
            return 5.0 / 4.0 * input + 273;
        }
        private double fahrenheitToCelcius(double input)
        {
            return 5.0 / 9.0 * (input - 32);
        }

        private double fahrenheitToReamur(double input)
        {
            return 4.0 / 9.0 * (input - 32);
        }

        private double fahrenheitToKelvin(double input)
        {
            return fahrenheitToCelcius(input) + 273;
        }

        private double kelvinToCelcius(double input)
        {
            return input - 273;
        }

        private double kelvinToReamur(double input)
        {
            return 4.0 / 5.0 * (input - 273);
        }

        private double kelvinToFahrenheit(double input)
        {
            return (9.0 / 5.0 * (input - 273)) + 32;
        }
    }
}

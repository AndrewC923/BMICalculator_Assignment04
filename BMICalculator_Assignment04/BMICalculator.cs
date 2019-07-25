using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Name: Andrew Cheung
 Number: 300604147
 Date Last Modified: 2019-07-25
 Program Description: This program is used to calculate a person's body mass index based on their given height and weight.
 Revision History: Version 2*/
namespace BMICalculator_Assignment04
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }


        private void BMIRatingText_TextChanged(object sender, EventArgs e)
        {

        }

        private void MetricRadio_CheckedChanged(object sender, EventArgs e)
        {
            HeightInput.Text = "M";
            WeightInput.Text = "Kg";
        }

        private void ImperialRadio_CheckedChanged(object sender, EventArgs e)
        {
            HeightInput.Text = "In";
            WeightInput.Text = "Lbs";
        }

        private void BMICalculator_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            HeightInput.Text = "";
            WeightInput.Text = "";
            BMIRatingText.Text = "";
            ResultText.Text = "";
            MetricRadio.Checked = false;
            ImperialRadio.Checked = true;
            HeightInput.Text = "In";
            WeightInput.Text = "Lbs";
            ResultText.BackColor = System.Drawing.Color.DarkGray;
            BMIRatingText.BackColor = System.Drawing.Color.DarkGray;
        }

        private void HeightInput_Enter(object sender, EventArgs e)
        {
            HeightInput.Text = "";
        }

        private void WeightInput_Enter(object sender, EventArgs e)
        {
            WeightInput.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnCalculate_click(object sender, EventArgs e)
        {
            double _weight;
            double _height;
            double _result = 0;


            if (Double.TryParse(WeightInput.Text, out _weight) && Double.TryParse(HeightInput.Text, out _height))
            {
                if (ImperialRadio.Checked)
                {
                    _weight = _weight * 703;
                    _result = _weight / (_height * _height);
                }
                else if (MetricRadio.Checked)
                {

                    _result = _weight / (_height * _height);
                }
                BMIRatingText.Text = $"{Math.Round(_result, 2)}";
                BMIRatingText.BackColor = System.Drawing.Color.White;

                if (double.Parse(BMIRatingText.Text) < 18.5)
                {
                    ResultText.Text = "Underweight - Less than 18.5";
                    ResultText.BackColor = System.Drawing.Color.Orange;
                }
                else if (double.Parse(BMIRatingText.Text) >= 18.5 && double.Parse(BMIRatingText.Text) <= 24.9)
                {
                    ResultText.Text = "Normal - Between 18.5 and 24.9";
                    ResultText.BackColor = System.Drawing.Color.Green;
                }
                else if (double.Parse(BMIRatingText.Text) >= 25 && double.Parse(BMIRatingText.Text) <= 29.9)
                {
                    ResultText.Text = "Overweight - Between 25 and 29.9";
                    ResultText.BackColor = System.Drawing.Color.Orange;
                }
                else if (double.Parse(BMIRatingText.Text) >= 30)
                {
                    ResultText.Text = "Obese - 30 or greater";
                    ResultText.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Error: Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

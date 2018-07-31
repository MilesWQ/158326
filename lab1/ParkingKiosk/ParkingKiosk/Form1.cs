using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ParkingKiosk
{
    public partial class Form1 : Form
    {
        private ParkingType _parkingType;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (customerRadioBtn.Checked)
            {
                regulation.Text = "Customer Parking\nPay $2 for each hour\nMaximum Limit = 24 hours";
            }
            if (staffRadioBtn.Checked)
            {
                regulation.Text = "Staff Parking\nPay $2 for first ten hours\nPay $2 for each hour in excess of 10 hours\nMaximun limit = 24 hours";
            }
            Selector.Enabled = false;
            inputHours.Enabled = true;
            CalculationButton.Enabled = true;
        }

        private void CalculationButton_Click(object sender, EventArgs e)
        {
            string valid_input_pattern = @"^\d{1,5}?[.]*?\d??$";
            if (!Regex.IsMatch(inputHours.Text, valid_input_pattern))
            {
                MessageBox.Show("Invalid input.","Oops");
                return;
            }
            try
            {
                if (customerRadioBtn.Checked)
                {
                    _parkingType = new ParkingType(Decimal.Parse(inputHours.Text));
                }
                if (staffRadioBtn.Checked)
                {
                    _parkingType = new ParkingType(Decimal.Parse(inputHours.Text));
                }
                result.Text = "$" + _parkingType.FindParkingChargeAmount().ToString();
            }
            catch(ParkingException ex)
            {
                MessageBox.Show(ex.Message,"Exceeding 24 hours");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            inputHours.Text = "";
            errorMessages.Text = "";
            regulation.Text = "";
            result.Text = "";
            CalculationButton.Enabled = false;
            inputHours.Enabled = false;
            Selector.Enabled = true;
        }
        
    }
}

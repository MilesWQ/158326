using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingKiosk2
{
    public partial class Form1 : Form
    {
        private IKiosk kiosk;
        private ParkType parkType;
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (generalRadioBtn.Checked)
            {
                parkType = ParkType.General;
            }
            if (staffRadiobtn.Checked)
            {
                parkType = ParkType.Staff;
            }
            if (studentRadioBtn.Checked)
            {
                parkType = ParkType.Student;
            }
            string pattern = @"^\d{1,5}?\.*?\d??$";
            if (!Regex.IsMatch(InputHours.Text, pattern))
            {
                MessageBox.Show("Invalid input", "oops");
                InputHours.Text = "";
            }
            else
            {
                switch (parkType)
                {
                    case ParkType.General:
                        kiosk = new GenKioskWrap(Decimal.Parse(InputHours.Text));
                        break;
                    case ParkType.Staff:
                        kiosk = new StaffKioskWrap(Decimal.Parse(InputHours.Text));
                        break;
                    case ParkType.Student:
                        kiosk = new StudKioskWrap(Decimal.Parse(InputHours.Text));
                        break;
                }
                Charge.Text = kiosk.FindParkingAmount().ToString();
            }
        }
    }
}

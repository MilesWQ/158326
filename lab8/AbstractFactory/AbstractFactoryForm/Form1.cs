using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbstractFactoryLibrary;

namespace AbstractFactoryForm
{
    public partial class Form1 : Form
    {
        private Cafe _cafe;
        private List<string> _flavour;
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayList()
        {
            _flavour = new List<string>
            {
                "Cappuccino",
                "Flat White"
            };
            for (int i = 0; i < 2; ++i)
            {
                typeList.Items.Insert(i, _flavour[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayList();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (radioBtnNZ.Checked)
            {
                _cafe = new NZCafe();
            }
            if (radioBtnOZ.Checked)
            {
                _cafe = new OZCafe();
            }
            Coffee coffee = _cafe.OrderCoffee(typeList.GetItemText(typeList.SelectedItem));
            lblOrder.Text = coffee.ShowDetails();
        }
    }
}

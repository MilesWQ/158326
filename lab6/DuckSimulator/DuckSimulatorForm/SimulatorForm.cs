using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DuckSimulatorLibrary;
namespace DuckSimulatorForm
{
    public partial class SimulatorForm : Form
    {
        private EDuck _duckType;
        private Duck _duck;
        public SimulatorForm()
        {
            InitializeComponent();
        }

        private void CheckDuckType()
        {
            if (radioMallard.Checked) { _duckType = EDuck.Mallard; }
            if (radioRedHead.Checked) { _duckType = EDuck.RedHeadDuck; }
            if (radioDecoyDuck.Checked) { _duckType = EDuck.DecoyDuck; }
            if (radioRubberDuck.Checked) { _duckType = EDuck.RubberDuck; }
            switch (_duckType)
            {
                case EDuck.Mallard:
                    _duck = new MallardDuck();
                    break;
                case EDuck.DecoyDuck:
                    _duck = new DecoyDuck();
                    break;
                case EDuck.RubberDuck:
                    _duck = new RubberDuck();
                    break;
                case EDuck.RedHeadDuck:
                    _duck = new RedHeadDuck();
                    break;
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblMessage.Text = _duck.Display();
        }

        private void btnFly_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblMessage.Text = _duck.PerformFly();
        }

        private void btnQuack_Click(object sender, EventArgs e)
        {
            CheckDuckType();
            lblMessage.Text = _duck.PerformQuack();
        }
    }
}

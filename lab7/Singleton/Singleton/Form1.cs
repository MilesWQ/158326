using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStationLibrary;

namespace Singleton
{
    public partial class Form1 : Form
    {
        private VTNZ _vtnz;
        private List<IServiceType> _serviceList;
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplayVTNZDetail()
        {
            _vtnz = VTNZ.GetInstance("VTNZ North Harbour", "3-5 Saturn Place, Albany", "666666", "Mon-Fri 7:30am-5pm");
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
 
        }
    }
}

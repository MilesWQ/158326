using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial3
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
            _vtnz = new VTNZ("VTNZ North Harbour", "3-5 Saturn Place, Albany", "666666", "Mon-Fri 7:30am-5pm");
            lblHeader.Text = _vtnz.ShowStationDetail();
        }

        private void DisplayService()
        {
            _serviceList = new List<IServiceType>
            {
                new CarInspectionType("WoF inspection", 50M),
                new CarInspectionType("Modified vehicle check-up", 200M),
                new CarInspectionType("Pre-purchase inspection",150M),
                new CarInspectionType("Certificate of Fitness",210M)
            };
            int listLength = _serviceList.Count;
            for(int i=0;i< listLength; ++i) { 
                listInspections.Items.Insert(i, _serviceList[i].ServiceName + " " + _serviceList[i].Price);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayVTNZDetail();
            DisplayService();
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            if(listInspections.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                IServiceType selectedService = new CarInspectionType();
                switch (listInspections.SelectedIndex)
                {
                    case 0:
                        selectedService = _serviceList[0];
                        break;
                    case 1:
                        selectedService = _serviceList[1];
                        break;
                    case 2:
                        selectedService = _serviceList[2];
                        break;
                    case 3:
                        selectedService = _serviceList[3];
                        break;
                }
                _vtnz.RequestService(selectedService);
                lblRequestDetails.Text += "Inspection Type " + _vtnz.ShowServiceDetail();
                lblNumberOfRequest.Text = VTNZ.TotalRequest.ToString();
                lblTotalPrice.Text = VTNZ.TotalPrice.ToString();
            }
            
        }
    }
}

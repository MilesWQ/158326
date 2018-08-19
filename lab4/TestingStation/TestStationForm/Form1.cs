using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using TestStationLibrary;

namespace TestStationForm
{
    public partial class Form1 : Form
    {
        private SQLiteConnection dbConnection;
        private SQLiteCommand sqlCommand;
        private SQLiteDataReader reader;
        private VTNZStation vtnz;
        private IService selectedService;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayStationDetails();
            lblMessage.Text = "Select the inspection type:";
        }

        private void DisplayStationDetails()
        {
            vtnz = new VTNZStation("VTNZ North Harbour", "3-5 Saturn Place, Albany", "666666", "Mon-Fri 7:30am-5pm");
            lblStationInfo.Text = vtnz.ShowStationDetails();
        }

        private void btnCreateDb_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists("MyserviceDatabase.sqlite")){
                MessageBox.Show("Just began to creat DB");
                SQLiteConnection.CreateFile("MyserviceDatabase.sqlite");
                dbConnection = new SQLiteConnection("Data Source=MyServiceDatebase.sqlite;Version=3;");
                dbConnection.Open();
                string sql_Service = "create table Service (S_Name varchar(20), S_Price decimal)";
                SQLiteCommand commandService = new SQLiteCommand(sql_Service, dbConnection);
                commandService.ExecuteNonQuery();
                commandService.Dispose();
                fillServiceTable();
                dbConnection.Close();
            }
        }

        private void fillServiceTable()
        {
            string[] sqls = new string[] {
                "insert into Service (S_Name, S_Price) values ('Wof inspection', 50.00)",
                "insert into Service (S_Name, S_Price) values ('Modified vehicle check-up', 200.00)",
                "insert into Service (S_Name, S_Price) values ('Pre-purchase inspection', 150.00)",
                "insert into Service (S_Name, S_Price) values ('Vehicle registration', 210.00)",
            };
            foreach (var sql in sqls)
            {
                sqlCommand = new SQLiteCommand(sql, dbConnection);
                sqlCommand.ExecuteNonQuery();
            }
        }

        private void btnLoadDb_Click(object sender, EventArgs e)
        {
            dbConnection = new SQLiteConnection("Data Source=MyServiceDatebase.sqlite;Version=3;");
            dbConnection.Open();
            string query = "select * from Service order by S_Price desc";
            sqlCommand = new SQLiteCommand(query, dbConnection);
            reader = sqlCommand.ExecuteReader();
            SQLiteDataAdapter sql_data_adapter = new SQLiteDataAdapter(query, dbConnection);
            SQLiteCommandBuilder sql_command_builder = new SQLiteCommandBuilder(sql_data_adapter);
            DataSet data_set = new DataSet();
            sql_data_adapter.Fill(data_set);
            dataGridView1.DataSource = data_set.Tables[0].DefaultView;
        }

        private void btnRequest_Click(object sender, EventArgs e)
        {
            selectedService = new CarInspectionItem();
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select the inspection type you want", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string serviceName = Convert.ToString(dataGridView1.SelectedRows[0].Cells[0].Value);
                decimal servicePrice = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[1].Value);
                selectedService = new CarInspectionItem(serviceName,servicePrice);
                vtnz.RequestService(selectedService);
                lblSelectedDetails.Text += vtnz.ShowServiceDetails();
                lblTotalPrice.Text = VTNZStation.TotalPrice.ToString();
                lblTotalNumber.Text = VTNZStation.TotalCount.ToString();
            }
        }
    }
}

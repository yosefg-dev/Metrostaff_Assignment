using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;
/*using System.Data.Common;
using System.Timers;
using System.Web;*/
using metrostaff.Controllers;
/*using MySql.Data.MySqlClient;
using System.Data;
using System.Configuration;
using System.Security.Policy;*/


namespace metrostaff
{
    public partial class Form1 : Form
    {
/*        MySqlConnection conn = new MySqlConnection
            (ConfigurationManager.ConnectionStrings
            ["Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=D:\\METROSTAFF\\METROSTAFF\\DBMACHINERECORD.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"].ConnectionString);
*/
        ArrayList axisArray = new ArrayList();
        double xConverted = 0, yConverted = 0, zConverted =0;
        public Form1()
        {            
            // this initialization is a default initialization of the UI after i design the look and feel
            InitializeComponent();
            //global declaration of the three axis to the inital value 0
            initialize_Axis(0.00, 0.00, 0.00);
            //the logic is on this methode
            updateDataScreen();

        }

        public void initialize_Axis(double xax, double yax, double zax)
        {
            txtXAxis.Text = xax.ToString();
            txtYAxis.Text = yax.ToString();
            txtZAxis.Text = zax.ToString();
        }

        public async void updateDataScreen()
        {
            /*
             *declaration of the variables with initial values
             *random number generation within the range and display on the screen 
             *do the above iteration undefinite times
             */

            int timeDelay = 1000;
            manupulation MoveAxis = new manupulation();
            do
            {
                double largAxis = MoveAxis.getLargestAxis(xConverted, yConverted, zConverted);
                if (largAxis == 0)
                    largAxis = 100;
                double xDouble = MoveAxis.GetRandomAxis(largAxis);
                double yDouble = MoveAxis.GetRandomAxis(largAxis);
                double zDouble = MoveAxis.GetRandomAxis(largAxis);

                 xConverted = MoveAxis.ConvertedAxisToDouble(txtXAxis.Text);
                 yConverted = MoveAxis.ConvertedAxisToDouble(txtYAxis.Text);
                 zConverted = MoveAxis.ConvertedAxisToDouble(txtZAxis.Text);

                axisArray.Add(xConverted);
                axisArray.Add(yConverted);
                axisArray.Add(zConverted);


                for (int i = (int)xDouble; i < largAxis; i += (int)xConverted)
                {
                    xConverted += xDouble;
                    yConverted += yDouble;
                    zConverted += zDouble;
                    /*conn.Open();*/
                   /* MySqlCommand cmd = new MySqlCommand(
                        "INSERT INTO MachineRecord " +
                        "([xAxis],[yAxis],[zAxis],[createdAt]) " +
                        "VALUES('" + xConverted + "','" + yConverted 
                        +"','"+ zConverted + "',SYSDATETIME())");
                     cmd.ExecuteNonQuery();*/
                    await Task.Delay(timeDelay);
                    txtXAxis.Text = xConverted.ToString();
                    txtYAxis.Text = yConverted.ToString();
                    txtZAxis.Text = zConverted.ToString();
                    axisArray.Add(xConverted);
                    axisArray.Add(yConverted);
                    axisArray.Add(zConverted);
                }

                initialize_Axis(xConverted,yConverted,zConverted);
            } while (true);
            
        }
        
    private void btnGetData_Click(object sender, EventArgs e)
        {
            string jsonResult = JsonConvert.SerializeObject(axisArray);
            MessageBox.Show(jsonResult);
        }

        private void btnGetInstance_Click(object sender, EventArgs e)
        {
            double xAxis, yAxis, zAxis ;
            
            Double.TryParse(txtXAxis.Text, out xAxis);
            Double.TryParse(txtYAxis.Text, out yAxis);
            Double.TryParse(txtZAxis.Text, out zAxis);
            MessageBox.Show("" + xAxis + " " + yAxis + " " + zAxis);

        }
        private void btnCalculator_Click(object sender, EventArgs e)
        {
            DialogResult result = new Calculator().ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new Calculator().ShowDialog();
        }

        private void machineSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = new Form1().ShowDialog();
        }
    }
}
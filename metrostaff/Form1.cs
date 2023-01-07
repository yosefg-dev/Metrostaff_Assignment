using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections;
using System.Data.Common;
using System.Timers;
using System.Web;

namespace metrostaff
{
    public partial class Form1 : Form
    {
        int length = 100;
        int timeDelay = 2000;
        ArrayList axisArray = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            initialize_Axis();
            updateDataScreen();

        }

        public void initialize_Axis()
        {
            txtXAxis.Text = "0.0";
            txtYAxis.Text = "0.0";
            txtZAxis.Text = "0.0";
        }
        public async void updateDataScreen()
        {
            double xAxis, yAxis, zAxis;
            //string result;
            do
            {
                Random x = new Random();
                Random y = new Random();
                Random z = new Random();

                double xDouble = x.NextDouble() * length;
                double yDouble = y.NextDouble() * length;
                double zDouble = z.NextDouble() * length;

                Double.TryParse(txtXAxis.Text, out xAxis);
                Double.TryParse(txtYAxis.Text, out yAxis);
                Double.TryParse(txtZAxis.Text, out zAxis);
                axisArray.Add(xAxis);
                axisArray.Add(yAxis);
                axisArray.Add(zAxis);


                for (int i = (int)xDouble; i < length; i += (int)xAxis)
                {
                    xAxis += xDouble;
                    yAxis += yDouble;
                    zAxis += zDouble;
                    await Task.Delay(timeDelay);
                    txtXAxis.Text = xAxis.ToString();
                    txtYAxis.Text = yAxis.ToString();
                    txtZAxis.Text = zAxis.ToString();
                    axisArray.Add(xAxis);
                    axisArray.Add(yAxis);
                    axisArray.Add(zAxis);
                }
                txtXAxis.Text = "0.00";
                txtYAxis.Text = "0.00";
                txtZAxis.Text = "0.00";             
         
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
    }
}
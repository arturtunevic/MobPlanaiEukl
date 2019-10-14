using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobPlanaiEuklidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Init();
        }


        public void Init()
        {
            Reader reader = new Reader();
            reader.ReadFile();
            Plans plans = reader.PassPlans();
            PlansDebugView.DataSource = plans.GetAllPlans();

        }

        private void FindPlanBtn_Click(object sender, EventArgs e)
        {
            Find();
        }

        public void Find()
        {
            List<double> results = new List<double>();
            double minutes = Convert.ToDouble(MinSkBox.Text);
            double sms = Convert.ToDouble(SmsBox.Text);
            double netGb = Convert.ToDouble(NetGbBox.Text);
            double price = Convert.ToDouble(PriceBox.Text);

            double val1;
            double val2;
            double val3;
            double val4;

            for(int i = 0;i<14;i++)
            {
                val1 = Convert.ToDouble(PlansDebugView.Rows[i].Cells[2].Value.ToString());
                val2 = Convert.ToDouble(PlansDebugView.Rows[i].Cells[3].Value.ToString());
                val3 = Convert.ToDouble(PlansDebugView.Rows[i].Cells[4].Value.ToString());
                val4 = Convert.ToDouble(PlansDebugView.Rows[i].Cells[5].Value.ToString());
                results.Add(Math.Sqrt(Math.Pow(minutes - val1, 2) + Math.Pow(sms - val2, 2) + Math.Pow(netGb - val3, 2) + Math.Pow(price - val4, 2)));
                listBox1.Items.Add(Math.Sqrt(Math.Pow(minutes - val1, 2) + Math.Pow(sms - val2, 2) + Math.Pow(netGb - val3, 2) + Math.Pow(price - val4, 2)));
            }

            double lowestVal = results.Min();
            int indx = listBox1.Items.IndexOf(lowestVal);
            indx = indx + 1;
            PlanSuggestion.Text = "Plano ID " + indx;

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobPlanaiEuklidas
{
    public class Reader
    {
        const string fPln = "planai.txt";
        const string fProv = "providers.txt";
        private Plans plns;

        public void ReadFile()
        {
            string[] plansLines = File.ReadAllLines(fProv);
            string[] planLines = File.ReadAllLines(fPln);

            List<Plans> plans = new List<Plans>();
            foreach (string str in plansLines)
            {
                string[] tmp = str.Split(';');
                Plans pln = new Plans(Convert.ToInt32(tmp[0]), tmp[1]);
                plans.Add(pln);
            }
            plns = new Plans(0,null);


            foreach (string str in planLines)
            {
                string[] tmp = str.Split(';');
                Plan plan = new Plan(Convert.ToInt32(tmp[0]), tmp[2], Convert.ToInt32(tmp[3]), Convert.ToInt32(tmp[4]), Convert.ToInt32(tmp[5]), Convert.ToDouble(tmp[6]));

                int catID = Convert.ToInt32(tmp[1]);
                foreach (Plans pln in plans)
                    if (pln.GetID() == catID)
                    {
                        plns.AddPlan(plan);
                    }
            }
        }

        public Plans PassPlans()
        {
            return plns;
        }
    }
}

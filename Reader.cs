using System;
using System.Collections.Generic;
using System.IO:
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobPlanaiEuklidas
{
    public class Reader
    {
        const string file = "planai.txt";

        public void ReadFile()
        {
            string[] plansLines = File.ReadAllLines(file);
            string[] planLines = File.ReadAllLines(file);

            List<Plans> plans = new List<Plans>();
            foreach (string str in plansLines)
            {
                string[] tmp = str.Split(';');
                Plans pln = new Plans(Convert.ToInt32(tmp[0]), tmp[1]);
                plans.Add(pln);
            }


            foreach (string str in automobiliaiLines)
            {
                string[] tmp = str.Split(';');
                Automobilis auto = new Automobilis(Convert.ToInt32(tmp[1]), tmp[2], Convert.ToInt32(tmp[3]), Convert.ToInt32(tmp[4]), Convert.ToDouble(tmp[5]), tmp[6]);

                int categoryId = Convert.ToInt32(tmp[0]);
                foreach (Marke marke in markes)
                    if (marke.GetID() == categoryId)
                        marke.AddAuto(auto);
            }
        }
    }
}

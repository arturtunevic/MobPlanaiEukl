using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobPlanaiEuklidas
{
    public class Plans
    {
        private int ID;
        private string provider;
        private List<Plan> plans;

        public Plans(int iD, string provider)
        {
            ID = iD;
            this.provider = provider;
            plans = new List<Plan>();
        }

        public int GetID()
        {
            return ID;
        }

        public string GetProvider()
        {
            return provider;
        }

        public void AddPlan(Plan plan)
        {
            plans.Add(plan);
        }

        public List<Plan> GetAllPlans()
        {
            return plans;
        }

    }
}

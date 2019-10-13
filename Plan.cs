using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobPlanaiEuklidas
{
    public class Plan
    {

        private string provider;
        private string planName;
        private int minAmt;
        private int smsAmt;
        private int netGBAmt;
        private double price;

        public Plan(string provider, string planName, int minAmt, int smsAmt, int netGBAmt, double price)
        {
            this.provider = provider;
            this.planName = planName;
            this.minAmt = minAmt;
            this.smsAmt = smsAmt;
            this.netGBAmt = netGBAmt;
            this.price = price;
        }


    }
}

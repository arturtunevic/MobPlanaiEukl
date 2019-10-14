using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobPlanaiEuklidas
{
    public class Plan
    {

        private int ID;
        private string planName;
        private int minAmt;
        private int smsAmt;
        private int netGBAmt;
        private double price;

        public Plan(int iD, string planName, int minAmt, int smsAmt, int netGBAmt, double price)
        {
            ID = iD;
            this.planName = planName;
            this.minAmt = minAmt;
            this.smsAmt = smsAmt;
            this.netGBAmt = netGBAmt;
            this.price = price;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string PlanName { get => planName; set => planName = value; }
        public int MinAmt { get => minAmt; set => minAmt = value; }
        public int SmsAmt { get => smsAmt; set => smsAmt = value; }
        public int NetGBAmt { get => netGBAmt; set => netGBAmt = value; }
        public double Price { get => price; set => price = value; }
    }
}

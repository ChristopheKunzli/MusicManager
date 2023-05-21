using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicManager
{
    public class Trade
    {
        private int id;
        private double amount;
        private DateTime date;

        public int Id { get { return id; } set {  id = value; } }
        public double Amount { get { return amount; } set { amount = value; } }
        public DateTime Date { get { return date; } set { date = value; } }

        public Trade(int id, double amount, DateTime date)
        {
            this.id = id;
            this.amount = amount;
            this.date = date;
        }
    }
}

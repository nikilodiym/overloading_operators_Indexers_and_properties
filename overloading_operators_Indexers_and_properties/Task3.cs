using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloading_operators_Indexers_and_properties
{
    internal class Task3
    {
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public static Task3 operator +(Task3 card, decimal amount)
        {
            card.Balance += amount;
            return card;
        }

        public static Task3 operator -(Task3 card, decimal amount)
        {
            card.Balance -= amount;
            return card;
        }

        public static bool operator ==(Task3 card1, Task3 card2)
        {
            return card1.Balance == card2.Balance;
        }

        public static bool operator !=(Task3 card1, Task3 card2)
        {
            return card1.Balance != card2.Balance;
        }

        public static bool operator <(Task3 card1, Task3 card2)
        {
            return card1.Balance < card2.Balance;
        }

        public static bool operator >(Task3 card1, Task3 card2)
        {
            return card1.Balance > card2.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Task3 otherCard = (Task3)obj;
            return Balance == otherCard.Balance;
        }

        public override int GetHashCode()
        {
            return Balance.GetHashCode();
        }
    }
}

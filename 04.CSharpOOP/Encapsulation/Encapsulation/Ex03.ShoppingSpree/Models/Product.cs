using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using P03.ShoppingSpree.Common;

namespace P03.ShoppingSpree.Models
{
    public class Product
    {
        private const decimal COST_MIN_VALUE = 0m;

        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(GlobalConstants.InvalidNameExceptionMessage);
                }
                this.name = value;
            }
        }

        public decimal Cost
        {
            get
            {
                return this.cost;
            }
            private set
            {
                if (value < COST_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyExceptionMessage);
                }

                this.cost = value;

            }
        }
        public override string ToString()
        {
            //return $"{this.Name}"; -- връща едно и също нещо
            return this.Name;
        }

    }
}

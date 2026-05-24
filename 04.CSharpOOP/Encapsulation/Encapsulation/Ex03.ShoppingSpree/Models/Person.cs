using P03.ShoppingSpree.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03.ShoppingSpree.Models
{
    public class Person
    {
        private const decimal MONEY_MIN_VALUE = 0m;

        private string name;
        private decimal money;
        private List<Product> bag;

        private Person()
        {
            this.bag = new List<Product>();
        }

        public Person(string name, decimal money) : this()
        {
            this.Name = name;
            this.Money = money;
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
                    throw new ArgumentException(GlobalConstants.InvalidNameExceptionMessage);
                }

                this.name = value;
            }
        }

        public decimal Money
        {
            get
            {
                return this.money;
            }
            private set
            {
                if (value < MONEY_MIN_VALUE)
                {
                    throw new ArgumentException(GlobalConstants.InvalidMoneyExceptionMessage);
                }

                this.money = value;
            }
        }

        //да не може да се променя отвън и има само get
        //this.bag.AsReadOnly() - това ми го образува в IReadOnlyCollection без кастването

        public IReadOnlyCollection<Product> Bag => this.bag.AsReadOnly();

        public void BuyProduct(Product product)
        {
            if (this.Money < product.Cost)
            {
                throw new InvalidOperationException(String.Format(GlobalConstants.InsuficientMoneyExceptionMessage, this.Name, product.Name));
            }

            // това го пиша аз за да съм сигурна че винаги ще бъде валидно 
            this.Money -= product.Cost;

            //this.Bag.Add(product) ще върне ReadOnly, които няма метод Add
            // тъй като данните са валидирани можем да работим директно с тях
            this.bag.Add(product);
        }

        public override string ToString()
        {
            string productsOutput = this.Bag.Count > 0
                ? String.Join(", ", this.Bag) : "Nothing bought";
            return $"{this.Name} - {productsOutput}";
        }
    }
}

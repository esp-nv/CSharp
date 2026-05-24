using P03.ShoppingSpree.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace P03.ShoppingSpree.Core
{
    public class Engine
    {
        private List<Product> products;
        private List<Person> people;

        public Engine()
        {
            this.products = new List<Product>();
            this.people = new List<Person>();
        }

        public void Run()
        {
            AddPeople();
            AddProducts();

            string commamd;

            while ((commamd = Console.ReadLine()) != "END")
            {
                string[] cmdArg = commamd.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                string peopleName = cmdArg[0];
                string productName = cmdArg[1];

                try
                {
                    //взима конкретни обекти от списъци
                    Person person = this.people.First(p => p.Name == peopleName);
                    Product product = this.products.First(p => p.Name == productName);

                    //за осъществяване на покупка
                    // ако купуването гръмне с exception
                    //направо отива на expection и няма да изпише Console.WriteLine($"{person} bought {product}");                    
                    person.BuyProduct(product);

                    //ще се изпълни само при успешно закупуване
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ioe)
                {

                    Console.WriteLine(ioe.Message);
                }
            }
            PrintOutput();
        }

        private void PrintOutput()
        {
            foreach (Person person in this.people)
            {
                Console.WriteLine(person);
            }
        }

        private void AddProducts()
        {
            string[] productArg = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < productArg.Length; i++)
            {
                string[] currProductToken = productArg[i].Split("=", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = currProductToken[0];
                decimal cost = decimal.Parse(currProductToken[1]);

                Product product = new Product(name, cost);
                this.products.Add(product);
            }
        }

        private void AddPeople()
        {
            string[] peopleArg = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries).ToArray();

            for (int i = 0; i < peopleArg.Length; i++)
            {
                string[] currPeopleToken = peopleArg[i].Split("=", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string name = currPeopleToken[0];
                decimal money = decimal.Parse(currPeopleToken[1]);

                Person person = new Person(name, money);
                this.people.Add(person);

            }
        }
    }
}

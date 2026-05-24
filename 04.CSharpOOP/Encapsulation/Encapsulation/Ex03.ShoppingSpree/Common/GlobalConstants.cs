using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace P03.ShoppingSpree.Common
{
    public class GlobalConstants
    {
        //static - не трябва да се инициализиран, но може да бъде достъпван по всяко време
        public static string InvalidNameExceptionMessage = "Name cannot be empty";

        public static string InvalidMoneyExceptionMessage = "Money cannot be negative";

        public static string InsuficientMoneyExceptionMessage = "{0} can't afford {1}";


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC
{
    public interface ICreditCard
    {
        string ChargeCard();
    }

    public class Visa : ICreditCard
    {
        public string ChargeCard()
        {
            return "Visa Card Has been Charge!";
        }
    }

    public class Master : ICreditCard
    {
        public string ChargeCard()
        {
            return "Master Card Has been Charge!";
        }
    }

    public class Shopper
    {
        private readonly ICreditCard creditCard;

        public Shopper(ICreditCard creditCard)
        {
            this.creditCard = creditCard;
        }

        public void Charge()
        {
            string message = creditCard.ChargeCard();
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}

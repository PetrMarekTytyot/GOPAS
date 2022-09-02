using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityDemo
{
    public class PartnerDiscountHandler : DiscountHandler
    {
        protected override bool IsForMe(Order o)
        {
            return o.Customer == "Gopas";
        }

        protected override Order Transform(Order o)
        {
            return new Order()
            {
                Customer = o.Customer,
                Text = o.Text,
                Price = o.Price * .9,
            };
        }
    }
}

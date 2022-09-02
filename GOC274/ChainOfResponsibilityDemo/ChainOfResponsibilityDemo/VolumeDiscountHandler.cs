namespace ChainOfResponsibilityDemo
{
    public class VolumeDiscountHandler : DiscountHandler
    {
        protected override bool IsForMe(Order o)
        {
            return o.Price > 1_000_000;
        }

        protected override Order Transform(Order o)
        {
            return new Order()
            {
                Price = o.Price - 100,
                Customer = o.Customer,
                Text = o.Text,
            };
        }
    }
}

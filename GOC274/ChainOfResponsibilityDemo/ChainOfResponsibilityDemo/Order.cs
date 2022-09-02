namespace ChainOfResponsibilityDemo
{
    public class Order
    {
        public string Customer { get; set; }
        public string Text { get; set; }
        public double Price { get; set; }

        public override string ToString() => 
            $"{Customer}, {Text} - {Price}";
    }
}
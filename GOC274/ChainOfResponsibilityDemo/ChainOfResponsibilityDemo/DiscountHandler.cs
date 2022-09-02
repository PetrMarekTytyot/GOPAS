namespace ChainOfResponsibilityDemo
{
    public abstract class DiscountHandler
    {
        public DiscountHandler Next { get; set; }

        public Order Handle(Order o)
        {
            //Chain of responsibility
            //if (IsForMe(o)) return Transform(o);
            //else
            //{
            //    if (Next != null) return Next.Handle(o);
            //    else return o;
            //}

            //Modified version
            if (IsForMe(o)) {
                if (Next != null) return Next.Handle(Transform(o));
                else return Transform(o);
            }
            else
            {
                if (Next != null) return Next.Handle(o);
                else return o;
            }
        }

        protected abstract Order Transform(Order o);

        protected abstract bool IsForMe(Order o);
    }
}

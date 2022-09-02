namespace VisitorDemo
{
    public class Attribute: INode
    {
        public string Value { get; set; }

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitAttribute(this);
        }
    }
}

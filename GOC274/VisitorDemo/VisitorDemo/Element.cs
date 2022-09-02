namespace VisitorDemo
{
    public class Element: INode
    {
        public string InnerText { get; set; }

        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.VisitElement(this);
        }
    }
}
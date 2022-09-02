namespace VisitorDemo
{
    public interface IVisitor
    {
        void VisitElement(Element element);
        void VisitAttribute(Attribute attribute);
    }
}
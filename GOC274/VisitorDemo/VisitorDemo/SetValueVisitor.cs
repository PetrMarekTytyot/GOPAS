using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    public class SetValueVisitor : IVisitor
    {
        private string value;

        public SetValueVisitor(string value)
        {
            this.value = value;
        }

        public void VisitAttribute(Attribute attribute)
        {
            attribute.Value = value;
        }

        public void VisitElement(Element element)
        {
            element.InnerText = value;
        }
    }
}

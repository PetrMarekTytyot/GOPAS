using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    public class SetUCaseValueVisitor : IVisitor
    {
        private string value;

        public SetUCaseValueVisitor(string value)
        {
            this.value = value;
        }

        public void VisitAttribute(Attribute attribute)
        {
            attribute.Value = value.ToUpper();
        }

        public void VisitElement(Element element)
        {
            element.InnerText = value.ToUpper();
        }
    }
}

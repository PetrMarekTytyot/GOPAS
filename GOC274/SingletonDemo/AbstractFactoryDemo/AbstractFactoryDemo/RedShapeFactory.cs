using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class RedShapeFactory : IShapeFactory
    {
        public ICircle CreateCircle() => new RedCircle();

        public ISquare CreateSquare() => new RedSquare();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class BlueShapeFactory : IShapeFactory
    {
        public ICircle CreateCircle() => new BlueCircle();

        public ISquare CreateSquare() => new BlueSquare();
    }
}

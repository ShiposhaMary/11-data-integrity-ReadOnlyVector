using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyVectorTask 
    /* Cоздание публичного класса с приватными полями.
      Поля задаются конструктором.
      Методы класса работают через вызов конструктора.
      Методы With заменяют одно из полей .*/
{
    public class ReadOnlyVector    
    {
        public readonly double X;
        public readonly double Y;
        public ReadOnlyVector(double x, double y)
        {
            X = x;
            Y = y;
        }
        public ReadOnlyVector Add(ReadOnlyVector other)
        {
            return new ReadOnlyVector(X + other.X, Y + other.Y);

        }
        public ReadOnlyVector WithX( double x)
        {
            return new ReadOnlyVector(x,Y) ;
        }
        public ReadOnlyVector WithY( double y)
        {
            return new ReadOnlyVector(X, y);
        }
    }
    
}

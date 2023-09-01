using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overriding
{
    class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw shape");
        }
    }

    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
    class Square : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();

            Square s1 = new Square();

            c1.Draw();

            s1.Draw();

        }
    }
}

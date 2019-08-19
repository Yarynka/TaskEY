using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class CFigure
    {
        readonly int x;
        readonly int y;


        public CFigure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public virtual void Draw()
        {
            Console.WriteLine("Figure");
        }

    }

    class CSquare : CFigure
    {
        public CSquare(int x, int y)
           : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
    class CRectangles : CFigure
    {
        public CRectangles(int x, int y)
            : base(x, y) { }

        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
    

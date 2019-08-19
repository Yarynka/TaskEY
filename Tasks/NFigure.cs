using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    interface IDrawable
    {
        void Draw();
    }
    class NFigure : IDrawable
    {
        readonly int x;
        readonly int y;

        public NFigure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Draw()
        {
            Console.WriteLine("Figure");
        }
    }
    class NSquare : NFigure, IDrawable
    {
        public NSquare(int x, int y)
            : base(x, y) { }
        public void Draw()
        {
            Console.WriteLine("Square");
        }
    }
    class NRectangles : NFigure, IDrawable
    {
        public NRectangles(int x, int y)
            : base(x, y) { }
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}

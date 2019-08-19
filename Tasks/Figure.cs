﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    abstract class Figure
    {
        public abstract void Draw();
        
    }

    class Square : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Square");
        }
    }
    class Rectangles : Figure
    {
        public override void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }
}

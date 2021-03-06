﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SnakeGame
{
    public class Food : FigureBase
    {
        private int _height;
        private int _width;

        public Food(int x, int y)
        {
            _width = x;
            _height = y;
            points = new List<Point>();
        }

        public void AddFood(int x=0,int y=0)
        {
            Random rand = new Random(unchecked((int)DateTime.Now.Millisecond));
            if (x==0 && y==0)
            do
            {
                x = rand.Next(_width);
                y = rand.Next(_height);
            } while (x == 0 || y == 0);
            points.Add(new Point(x, y, Figures.Food));

        }

        public void Clear()
        {
            points.Clear();
        }
        public Point GetPoint()
        {
            if (points.Count == 1)
                return points[0];
            else
                return null;
        }

        public override void Draw()
        {
            throw new NotImplementedException();
        }

    }

}

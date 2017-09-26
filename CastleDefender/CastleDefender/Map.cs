﻿using System;

namespace TreehouseDefense
{
    public class Map
    {
        public readonly int Width;
        public readonly int Height;

        //map constructor:
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point)
        {
            return point.X >= 0 && point.X < Width && point.Y >= 0 && point.Y < Height;
        }
    }
}
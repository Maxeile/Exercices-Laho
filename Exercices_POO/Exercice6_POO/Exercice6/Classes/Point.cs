using System;
using Exercice6;
namespace Exercice6
{
    public class Point
    {
        public double PosX {  get; set; }
        public double PosY { get; set; }
        
        public Point(double posX, double posY)

        {
            PosX = posX;
            PosY = posY;
        }

        public override string ToString()
        {
           return $"({PosX}, {PosY})";
        }


        
    }
}
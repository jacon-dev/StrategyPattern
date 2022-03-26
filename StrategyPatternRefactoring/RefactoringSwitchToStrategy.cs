using System;

namespace StrategyPatternRefactoring
{
    public class RefactoringSwitchToStrategy
    {
        public double CalculateArea(Shape shape, double length, double width, double radius, double side)
        {
            return shape switch
            {
                Shape.Rectangle => length * width,
                Shape.Circle => Math.PI * radius * radius,
                Shape.Triangle => side * side * (Math.Sqrt(3) / 4),
                _ => 0.0
            };
        }
    }
}
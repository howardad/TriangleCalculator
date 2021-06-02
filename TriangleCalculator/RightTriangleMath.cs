using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleCalculator
{
    public static class RightTriangleMath
    {
        private const double RAD_TO_DEG_FACTOR = 180.0 / Math.PI;

        public static double FindHypotenuse(double height, double length) => Math.Sqrt(height * height + length * length);

        public static double FindSide(double side, double hypotenuse) => Math.Sqrt(hypotenuse * hypotenuse - side * side);

        public static double FindAngleFromSides(double adjacentSide, double oppositeSide) => Math.Atan(oppositeSide / adjacentSide) * RAD_TO_DEG_FACTOR;

        public static double FindAdjacentAngleFromHypotenuse(double adjacentSide, double hypotenuse) => Math.Acos(adjacentSide / hypotenuse) * RAD_TO_DEG_FACTOR;

        public static double FindOppositeAngleFromHypotenuse(double oppositeSide, double hypotenuse) => Math.Asin(oppositeSide / hypotenuse) * RAD_TO_DEG_FACTOR;

        public static double FindOtherAngle(double angle) => 90 - angle;
    }
}

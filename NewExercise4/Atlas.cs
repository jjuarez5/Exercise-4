using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewExercise4
{
    public class Atlas
    {
        private double pointX;
        private double pointY;

        public Atlas(double x, double y)
        {
            this.pointX = x;
            this.pointY = y;
        }

        double location;

        public double DistanceAway(Atlas destinationAtlas)
        {
            var destX = this.pointX - destinationAtlas.pointX;
            var destY = this.pointY - destinationAtlas.pointY;

            var d = Math.Pow(destY, 2) + Math.Pow(destX, 2);
            
            return Math.Round(Math.Abs(Math.Sqrt(d)),2);
        }
    }
}

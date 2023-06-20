using CubeDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeDomain.Services
{
    public class CubeIntersectionService : ICubeIntersectionService
    {
        public double GetIntersectedVolume(ICube cubeA, ICube cubeB)
        {

            if (cubeA == null)
            {
                throw new ArgumentNullException(nameof(cubeA));
            }
            if (cubeB == null)
            {
                throw new ArgumentNullException(nameof(cubeB));
            }


            double Distance(double c1, double c2) => Math.Abs(c1 - c2);
            double Length(double d1, double d2, double d) => Math.Max(0, d1 / 2 + d2 / 2 - d);


            double V = Length(cubeA.Dimension.GetValue(), cubeB.Dimension.GetValue(), Distance(cubeA.X, cubeB.X)) *
                       Length(cubeA.Dimension.GetValue(), cubeB.Dimension.GetValue(), Distance(cubeA.Y, cubeB.Y)) *
                       Length(cubeA.Dimension.GetValue(), cubeB.Dimension.GetValue(), Distance(cubeA.Z, cubeB.Z));


            return V;
        }
    }
}

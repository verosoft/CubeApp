using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeDomain.Entities
{
    public class Cube : ICube
    {
        /// <summary>
        /// Length of the edge of the cube
        /// </summary>
        public double Dimension { get; }

        /// <summary>
        /// x-coordinate of the cube center
        /// </summary>
        public double X { get; }

        /// <summary>
        /// y-coordinate of the cube center
        /// </summary>
        public double Y { get; } 

        /// <summary>
        /// z-coordinate of the cube center
        /// </summary>
        public double Z { get; } 

        /// <summary>
        /// Constructor that receives the dimension and coordinates of the cube.
        /// </summary>
        /// <param name="dimension">Length of the edge of the cube</param>
        /// <param name="x">x-coordinate of the cube center</param>
        /// <param name="y">y-coordinate of the cube center</param>
        /// <param name="z">z-coordinate of the cube center</param>
       public Cube(double dimension, double x, double y, double z)
        {

            if (dimension <= 0)
            {
                throw new ArgumentException("The dimension must be positive", nameof(dimension));
            }


            // Asignar los valores a las propiedades
            Dimension = dimension;
            X = x;
            Y = y;
            Z = z;
        }

        public double Volume()
        {
            return Math.Pow(Dimension, 3);
        }
        
    }
}

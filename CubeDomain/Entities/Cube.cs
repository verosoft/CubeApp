using CubeDomain.ValueObjects;
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
        public Dimension Dimension { get; }

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
       public Cube(Dimension dimension, double x, double y, double z)
        {

                       
            Dimension = dimension;
            X = x;
            Y = y;
            Z = z;
        }

        /// <summary>
        /// Constructor that receives the dimension and coordinates of the cube.
        /// </summary>
        /// <param name="dimension">Length of the edge of the cube</param>
        /// <param name="x">x-coordinate of the cube center</param>
        /// <param name="y">y-coordinate of the cube center</param>
        /// <param name="z">z-coordinate of the cube center</param>
        public Cube(Dimension dimension, string x, string y, string z)
        {


            Dimension = dimension;
            X = Convert.ToDouble(x);
            Y = Convert.ToDouble(y);
            Z = Convert.ToDouble(z);
        }

        public double Volume()
        {
            return Math.Pow(Dimension.GetValue(), 3);
        }
        
    }
}

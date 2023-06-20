using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeDomain.ValueObjects
{
    public  class Dimension
    {
        
        private readonly double value;

        public Dimension(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("The dimension must be positive", nameof(value));
            }

            this.value = value;
        }

        public Dimension(string value)
        {
            try
            {
                var valueNumber = Convert.ToDouble(value);

                if (valueNumber <= 0)
                {
                    throw new ArgumentException("The dimension must be positive", nameof(value));
                }

                this.value = valueNumber;
            }
            catch (FormatException ex)
            {

                throw new FormatException(ex.Message, ex);
            }
            catch (OverflowException ex)
            {
                throw new OverflowException(ex.Message, ex);
            }
                        
        }


        public double GetValue()
        {
            return value;
        }

       
        public static bool operator ==(Dimension d1, Dimension d2)
        {
            return d1.value == d2.value;
        }

       
        public static bool operator !=(Dimension d1, Dimension d2)
        {
            return d1.value != d2.value;
        }

       
        public override bool Equals(object obj)
        {
            if (obj is Dimension other)
            {
                return this == other;
            }

            return false;
        }

       
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
    }
}

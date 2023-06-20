using CubeDomain.ValueObjects;

namespace CubeDomain.Entities
{
    public interface ICube
    {
        Dimension Dimension { get; }
        double X { get; }
        double Y { get; }
        double Z { get; }

        double Volume();
      
    }
}
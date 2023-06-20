namespace CubeDomain.Entities
{
    public interface ICube
    {
        double Dimension { get; }
        double X { get; }
        double Y { get; }
        double Z { get; }

        double Volume();
      
    }
}
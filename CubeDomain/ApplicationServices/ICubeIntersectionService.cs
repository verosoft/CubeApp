using CubeDomain.Entities;

namespace CubeDomain.ApplicationServices
{
    public interface ICubeIntersectionService
    {
        double GetIntersectedVolume(ICube cubeA, ICube cubeB);
    }
}
using CubeDomain.Entities;

namespace CubeDomain.Services
{
    public interface ICubeIntersectionService
    {
        double GetIntersectedVolume(ICube cubeA, ICube cubeB);
    }
}
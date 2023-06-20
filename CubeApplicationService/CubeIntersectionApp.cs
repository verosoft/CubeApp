using CubeDomain.Entities;
using CubeDomain.Services;
using CubeDomain.ValueObjects;
using System.Data;

namespace CubeApplicationService
{
    public class CubeIntersectionApp : ICubeIntersectionApp
    {


        private ICubeIntersectionService _intersectionService;


        public CubeIntersectionApp(ICubeIntersectionService cubeIntersectionService)
        {
            _intersectionService = cubeIntersectionService;
        }

        public double GetIntersectedVolume(string dimensionA, string dimensionB, string xA, string xB, string yA, string yB, string zA, string zB)
        {


            ICube cubeA = new Cube(new Dimension(dimensionA), xA, yA, zA);
            ICube cubeB = new Cube(new Dimension(dimensionB), xB, yB, zB);

            var result = _intersectionService.GetIntersectedVolume(cubeA, cubeB);

            return result;
        }

    }
}
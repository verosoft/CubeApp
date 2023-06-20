using CubeDomain.Services;
using CubeDomain.Entities;
using CubeDomain.ValueObjects;

namespace CubeDomain.Test
{
    [TestClass]
    public class CubeIntersectionServiceTest

    {
        [TestMethod]
        public void When_there_is_no_intersection_the_result_must_be_zero()
        {
            var service = new CubeIntersectionService();
            ICube cubeA = new Cube(new Dimension(10), 10, 10, 10);
            ICube cubeB = new Cube(new Dimension(10), 100, 100, 100);
            var volume = service.GetIntersectedVolume(cubeA, cubeB);

            Assert.AreEqual(0, volume);

        }

        [TestMethod]
        public void When_dimensions_are_equal_and_coordinates_are_equal_volumes_are_equal()
        {
            var service = new CubeIntersectionService();
            ICube cubeA = new Cube(new Dimension(10), 10, 10, 10);
            ICube cubeB = new Cube(new Dimension(10), 10, 10, 10);
            var volumeCubeA = cubeA.Volume();
            var volumeCubeB = cubeB.Volume();
            var volume = service.GetIntersectedVolume(cubeA, cubeB);

            Assert.IsTrue((volume == volumeCubeA) && (volume == volumeCubeB) && (volumeCubeA == volumeCubeB));

        }

        [TestMethod]
        public void When_there_is_intersection_the_result_is_greater_than_zero()
        {
            var service = new CubeIntersectionService();
            ICube cubeA = new Cube(new Dimension(10), 10, 10, 10);
            ICube cubeB = new Cube(new Dimension(30), 10, 20, 10);
            var volume = service.GetIntersectedVolume(cubeA, cubeB);

            Assert.IsTrue(volume > 0);
        }
    }
}
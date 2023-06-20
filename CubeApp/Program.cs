
using CubeDomain.ApplicationServices;
using CubeDomain.Entities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CubeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            var serviceProvicer = BuilSerrviceProvider();
            var cubeInterseccionService = serviceProvicer.GetService<ICubeIntersectionService>();

            Console.WriteLine("CUBE A:");
            Console.Write("Dimension:");
            var dimensionCubeA = Console.ReadLine();
            Console.Write("Coordinate X:"); 
            var coordinateXCubeA = Console.ReadLine();
            Console.Write("Coordinate Y:");
            var coordinateYCubeA = Console.ReadLine();
            Console.Write("Coordinate Z:");
            var coordinateZCubeA = Console.ReadLine();

            Console.WriteLine("CUBE B:");
            Console.Write("Dimension:");
            var dimensionCubeB = Console.ReadLine();
            Console.Write("Coordinate X:");
            var coordinateXCubeB = Console.ReadLine();
            Console.Write("Coordinate Y:");
            var coordinateYCubeB = Console.ReadLine();
            Console.Write("Coordinate Z:");
            var coordinateZCubeB = Console.ReadLine();

            ICube cubeA = new Cube(Convert.ToDouble(dimensionCubeA), Convert.ToDouble(coordinateXCubeA), Convert.ToDouble(coordinateYCubeA), Convert.ToDouble(coordinateZCubeA));
            ICube cubeB = new Cube(Convert.ToDouble(dimensionCubeB), Convert.ToDouble(coordinateXCubeB), Convert.ToDouble(coordinateYCubeB), Convert.ToDouble(coordinateZCubeB));
            
            var intersectionVolume = cubeInterseccionService?.GetIntersectedVolume(cubeA, cubeB);

            Console.WriteLine($"the intersection volume between {nameof(cubeA)} and {nameof(cubeB)} is {intersectionVolume}");


            Console.ReadLine();



        }


        private static IServiceProvider BuilSerrviceProvider()
        {
            var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (string.IsNullOrEmpty(environment))
            {
                environment = "Development";
            }

            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile($"appsettings.{environment}.json", optional: false, reloadOnChange: true)
               .AddEnvironmentVariables();

            var config = configuration.Build();

            var services = new ServiceCollection();
            services.AddSingleton<IConfiguration>(config);
            services.AddSingleton<ICubeIntersectionService, CubeIntersectionService>();

            return services.BuildServiceProvider();


        }
    }
}
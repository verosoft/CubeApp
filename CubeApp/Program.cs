
using CubeDomain.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CubeApplicationService;
using System.Resources;
using System.Reflection;

namespace CubeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            var  resourceManager = new ResourceManager(typeof(CubeApp.Properties.Resources));
            var serviceProvicer = BuilSerrviceProvider();
            var cubeInterseccionApp = serviceProvicer.GetService<ICubeIntersectionApp>();

            Console.WriteLine(resourceManager.GetString("CubeAHead"));
            Console.Write(resourceManager.GetString("Dimension"));
            var dimensionCubeA = Console.ReadLine();
            Console.Write(resourceManager.GetString("CoordinateX")); 
            var coordinateXCubeA = Console.ReadLine();
            Console.Write(resourceManager.GetString("CoordinateY"));
            var coordinateYCubeA = Console.ReadLine();
            Console.Write(resourceManager.GetString("CoordinateZ"));
            var coordinateZCubeA = Console.ReadLine();

            Console.WriteLine(resourceManager.GetString("CubeBHead"));
            Console.Write(resourceManager.GetString("Dimension"));
            var dimensionCubeB = Console.ReadLine();
            Console.Write(resourceManager.GetString("CoordinateX"));
            var coordinateXCubeB = Console.ReadLine();
            Console.Write(resourceManager.GetString("CoordinateY"));
            var coordinateYCubeB = Console.ReadLine();
            Console.Write(resourceManager.GetString("CoordinateZ"));
            var coordinateZCubeB = Console.ReadLine();
                        
            
            var intersectionVolume = cubeInterseccionApp?.GetIntersectedVolume(dimensionCubeA, dimensionCubeB, coordinateXCubeA, coordinateXCubeB, coordinateYCubeA, coordinateYCubeB, coordinateZCubeA, coordinateZCubeB);

            Console.WriteLine($"{resourceManager.GetString("Result")}{intersectionVolume}");


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
            services.AddSingleton<ICubeIntersectionApp, CubeIntersectionApp>();

            return services.BuildServiceProvider();


        }
    }
}
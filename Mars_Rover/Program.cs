using Mars_Rover.Concrete;
using System;
using System.Linq;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Mars_Rover.Abstract;
using Mars_Rover.DependcyResolvers.AutoFac;
using Microsoft.Extensions.DependencyInjection;

namespace Mars_Rover
{
    class Program
    {
        static void Main(string[] args)
        { 
            var serviceProvider = ContainerConfiguration.Configure();

            var spaceResolver = serviceProvider.Resolve<ISpace>(); 

            Console.WriteLine("Enter Plato's Coordinates");
            var plateauCoordinates = Console.ReadLine();
            var plateauCoordinate = plateauCoordinates.Split(" ");

            if (plateauCoordinate.Length == 2 )
            { 
                spaceResolver.VariableSet(Convert.ToInt32(plateauCoordinate[0]), Convert.ToInt32(plateauCoordinate[1]));
                Console.WriteLine("Enter the current location of the first rover");
                var rover1Coordinates = Console.ReadLine();
                var rover1Coordinate = rover1Coordinates.Split(" ");
                if (rover1Coordinate.Length==3)
                {
                    var vehicleResolver = serviceProvider.Resolve<IVehicle>();
                    Console.WriteLine("Enter First Rover's Instructions");
                    var rover1Directives = Console.ReadLine();
                    vehicleResolver.VariableSet(Convert.ToInt32(rover1Coordinate[0]), Convert.ToInt32(rover1Coordinate[1]), rover1Coordinate[2], rover1Directives);

                    Move move = new Move(vehicleResolver, spaceResolver); 
                    var result1 = move.GoVehicle();
                    Console.WriteLine("Latest status of the first rover : "+result1);

                }
                Console.WriteLine("Enter the current location of the second rover");
                var rover2Coordinates = Console.ReadLine();
                var rover2Coordinate = rover2Coordinates.Split(" ");
                if (rover2Coordinate.Length == 3)
                {
                    var vehicleResolver2 = serviceProvider.Resolve<IVehicle>();
                    Console.WriteLine("Enter Second Rover's Instructions");
                    var rover2Directives = Console.ReadLine();
                    vehicleResolver2.VariableSet(Convert.ToInt32(rover2Coordinate[0]), Convert.ToInt32(rover2Coordinate[1]), rover2Coordinate[2], rover2Directives);
                    
                    Move move2 = new Move(vehicleResolver2, spaceResolver);
                    var result2 = move2.GoVehicle();
                    Console.WriteLine("Latest status of the second rover : " + result2.Xlocation + " " + result2.Ylocation + " " + result2.Position);
                }
            } 
            Console.ReadLine();
        }




    }
}


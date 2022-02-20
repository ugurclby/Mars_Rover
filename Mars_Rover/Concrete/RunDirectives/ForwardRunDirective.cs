using System;
using Mars_Rover.Abstract;

namespace Mars_Rover.Concrete.RunDirectives
{
    public class ForwardRunDirective : IRunDirectives
    {
        public void Run(IVehicle vehicle, ISpace space)
        {
            switch (vehicle.Position)
            {
                case Positions.North:
                    if (vehicle.Ylocation>= space.Height)
                    {
                        VehicleCantMove();
                    }
                    else
                    {
                        vehicle.Ylocation++;
                    }
                    
                    break;

                case Positions.East:
                    if (vehicle.Xlocation >= space.Width)
                    {
                        VehicleCantMove();
                    }
                    else
                    {
                        vehicle.Xlocation++;
                    }
                    
                    break;

                case Positions.South:
                    if (vehicle.Ylocation == 0)
                    {
                        VehicleCantMove();
                    }
                    else
                    {
                        vehicle.Ylocation--;
                    } 
                    break;

                case Positions.West:
                    if (vehicle.Xlocation == 0)
                    {
                        VehicleCantMove();
                    }
                    else
                    {
                        vehicle.Xlocation--;
                    }

                    
                    break;
            } 
        }

        private void VehicleCantMove()
        {
            Console.WriteLine("Vehicle cant move");
        }
    }
}
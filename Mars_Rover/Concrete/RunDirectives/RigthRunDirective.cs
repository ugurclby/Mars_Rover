using Mars_Rover.Abstract;

namespace Mars_Rover.Concrete.RunDirectives
{
    public class RigthRunDirective : IRunDirectives
    {
        public void Run(IVehicle vehicle, ISpace space)
        {
            switch (vehicle.Position)
            {
                case Positions.North:
                    vehicle.Position = Positions.East;
                    break;

                case Positions.East:
                    vehicle.Position = Positions.South;
                    break;

                case Positions.South:
                    vehicle.Position = Positions.West;
                    break;

                case Positions.West:
                    vehicle.Position = Positions.North;
                    break;
            }
        }
    }
}
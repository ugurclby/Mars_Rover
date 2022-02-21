using Mars_Rover.Abstract;
using Mars_Rover.Concrete.RunDirectives;

namespace Mars_Rover.Concrete
{
    public class Move 
    { 
        private IVehicle _vehicle;
        private ISpace _space;

        public Move(IVehicle vehicle, ISpace space)
        {
            _vehicle = vehicle;
            _space = space;
        }

        public IVehicle GoVehicle()
        {
            foreach (var directive in _vehicle.Directives.ToCharArray()) 
            {
                
                if (directive.ToString()== Directives.Forward)
                {
                    new ForwardRunDirective().Run(_vehicle, _space);
                }
                else
                {
                    if (directive.ToString() == Directives.Right)
                    {
                        new RigthRunDirective().Run(_vehicle, _space);
                    }
                    else
                    {
                        new LeftRunDirective().Run(_vehicle, _space);
                    }
                }
            }

            return _vehicle;
        } 
    }
}
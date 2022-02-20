using Mars_Rover.Abstract;

namespace Mars_Rover.Concrete
{
    public class Rover: IVehicle
    {
        //public Rover(int xLocation, int yLocation, string position, string directives)
        //{
        //    Xlocation = xLocation;
        //    Ylocation = yLocation;
        //    Position = position;
        //    Directives = directives;
        //}
        public int Xlocation { get; set; }
        public int Ylocation { get; set; }
        public string Position { get; set; }
        public string Directives { get; set; }
        public void VariableSet(int xLocation, int yLocation, string position, string directives)
        {
            Xlocation = xLocation;
            Ylocation = yLocation;
            Position = position;
            Directives = directives;
        }
    }
}
namespace Mars_Rover.Abstract
{
    public interface IVehicle
    {
        public int Xlocation { get; set; }
        public int Ylocation { get; set; }
        public string Position { get; set; }
        public string Directives { get; set; }

        void VariableSet(int xLocation, int yLocation, string position, string directives);
    }
}
using Mars_Rover;
using Mars_Rover.Abstract;

namespace Mars_Rover.Concrete
{
    public class Plateau: ISpace
    {
        //public Plateau(int width,int height)
        //{
        //    Width = width;
        //    Height = height; 
        //}
        public int Width { get; set; }
        public int Height { get; set; }

        public void VariableSet(int width, int height)
        {
            Width = width;
            Height = height;
        }
    }
}
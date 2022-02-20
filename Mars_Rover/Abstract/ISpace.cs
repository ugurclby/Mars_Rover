namespace Mars_Rover.Abstract
{
    public interface ISpace
    {
        public int Width { get; }
        public int Height { get; }
        void VariableSet(int width, int height);
    }
}
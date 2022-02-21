using System;
using Mars_Rover.Abstract;
using Mars_Rover.Concrete;
using Mars_Rover.Concrete.RunDirectives;
using Xunit;

namespace Mars_Rover.Test
{
    public class GoVehicle
    {
        private ISpace _space;
        private IVehicle _vehicle;

        public GoVehicle()
        {
            _space = new Plateau();
            _vehicle = new Rover();
        }


        /// <summary>
        /// Rover mock data Example
        /// </summary>
        [Fact]
        public void GoVehicle_MockData_RoverLastState()
        {
            _space.VariableSet(Convert.ToInt32(MockData.PlateauCoordinate[0]) , Convert.ToInt32(MockData.PlateauCoordinate[1]) );
            _vehicle.VariableSet(Convert.ToInt32(MockData.Rover1Coordinates[0]), Convert.ToInt32(MockData.Rover1Coordinates[1]), 
                MockData.Rover1Coordinates[2],MockData.Rover1Directives);
            Move move = new Move(_vehicle, _space);

            var testResult =move.GoVehicle();
 
            Assert.Equal<string>(MockData.Rover1OutPut, testResult.Xlocation+" "+ testResult.Ylocation+" "+ testResult.Position);
        }

        /// <summary>
        /// Rover2WithParams Example
        /// </summary>
        [Theory]
        [InlineData(5, 5, 1, 2, "N", "LMLMLMLMM", "1 3 N")]
        [InlineData(5,5,3,3,"E", "MMRMMRMRRM", "5 1 E")] 
        public void GoVehicle_WithParams_RoverLastState(int xPlateu, int yPlateu, int xRover, int yRover,string roverPosition,string roverDirectives,string outPut)
        {
            _space.VariableSet(xPlateu, yPlateu);
            _vehicle.VariableSet(xRover, yRover, roverPosition, roverDirectives);
            Move move = new Move(_vehicle, _space);

            var testResult = move.GoVehicle();

            Assert.Equal<string>(outPut, testResult.Xlocation + " " + testResult.Ylocation + " " + testResult.Position);
        }
    }
     
}

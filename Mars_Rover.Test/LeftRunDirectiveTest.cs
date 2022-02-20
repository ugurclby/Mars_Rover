using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mars_Rover.Abstract;
using Mars_Rover.Concrete;
using Mars_Rover.Concrete.RunDirectives;
using Xunit;

namespace Mars_Rover.Test
{
    public class LeftRunDirectiveTest
    {
        private ISpace _space;
        private IVehicle _vehicle;

        public LeftRunDirectiveTest()
        {
            _space = new Plateau();
            _vehicle = new Rover();
        }
        [Fact]
        public void Run()
        {
            _space.VariableSet(Convert.ToInt32(MockData.PlateauCoordinate[0]), Convert.ToInt32(MockData.PlateauCoordinate[1]));
            _vehicle.VariableSet(Convert.ToInt32(MockData.Rover1Coordinates[0]), Convert.ToInt32(MockData.Rover1Coordinates[1]),
                MockData.Rover1Coordinates[2], MockData.Rover1Directives);

            LeftRunDirective lft = new LeftRunDirective();

            lft.Run(_vehicle, _space);

            Assert.Equal<string>(MockData.Rover1OutPutLeftPosition, _vehicle.Position);
        }
    }
}

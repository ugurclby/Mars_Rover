using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover.Test
{
    public static class MockData
    {
        public static string[] PlateauCoordinate = { "5", "5" };

        public static string[] Rover1Coordinates = {"1", "2", "N"};

        public static string Rover1Directives = "LMLMLMLMM" ;

        public static string Rover1OutPut = "1 3 N";
        
        public static string Rover1OutPutCoordinate = "1 3";

        public static string Rover1OutPutLeftPosition = "W";
        
        public static string Rover1OutPutRightPosition = "E"; 
         
    }
}

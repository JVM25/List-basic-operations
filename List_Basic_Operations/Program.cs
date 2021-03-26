using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace List_Basic_Operation.List_Basic_Operations
{
    class Program
    {
        public static void Main(String[] args)
        {
            StationaryBicycleList stationaryBicycleList = new StationaryBicycleList();

            StationaryBicycle b1 = new StationaryBicycle();
            b1.cost = 900000;
            b1.Color = "Pink";
            b1.Units = 2;
            stationaryBicycleList.Add(b1);

            StationaryBicycle b2 = new StationaryBicycle();
            b2.cost = 500000;
            b2.Color = "White";
            b2.Units = 5;
            stationaryBicycleList.Add(b2);

            StationaryBicycle b3 = new StationaryBicycle();
            b3.cost = 750000;
            b3.Color = "Black";
            b3.Units = 7;
            stationaryBicycleList.Add(b3);

            StationaryBicycle b4 = new StationaryBicycle();
            b4.cost = 1000000;
            b4.Color = "Purple";
            b4.Units = 10;
            stationaryBicycleList.Add(b4);

            StationaryBicycle b5 = new StationaryBicycle();
            b5.cost = 850000;
            b5.Color = "Green";
            b5.Units = 12;
            stationaryBicycleList.Add(b5);

            StationaryBicycle b6 = new StationaryBicycle();
            b6.cost = 400000;
            b6.Color = "Blue";
            b6.Units = 18;
            stationaryBicycleList.Add(b6);

            StationaryBicycle b7 = new StationaryBicycle();
            b7.cost = 950000;
            b7.Color = "Brown";
            b7.Units = 21;
            stationaryBicycleList.Add(b7);

            StationaryBicycle b8 = new StationaryBicycle();
            b8.cost = 650000;
            b8.Color = "Yellow";
            b8.Units = 25;

            stationaryBicycleList.Insert(b8, 3);


            stationaryBicycleList.Print();
        }
    }
}

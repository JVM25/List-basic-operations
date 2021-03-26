using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace List_Basic_Operation.List_Basic_Operations
{
    class StationaryBicycleList
    {
        StationaryBiclycleNode Head;

        public void Add(StationaryBicycle stationaryBicycleToAdd)
        {
            StationaryBiclycleNode newStationaryBiclycleNode = new StationaryBiclycleNode();
            newStationaryBiclycleNode.StationaryBicycle = stationaryBicycleToAdd;

            if (Head == null)
            {
                Head = newStationaryBiclycleNode;
            }
            else
            {
                StationaryBiclycleNode last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newStationaryBiclycleNode;
            }
        }

        public void Insert(StationaryBicycle item, int position)
        {
            StationaryBiclycleNode newstationaryBiclycleNode = new StationaryBiclycleNode();
            newstationaryBiclycleNode.StationaryBicycle = item;
            newstationaryBiclycleNode.Next = null;

            if (Head == null)
            {
                Head = newstationaryBiclycleNode;
            }
            else
            {
                StationaryBiclycleNode last;
                last = Head;

                if (position == 1)
                {
                    Head = newstationaryBiclycleNode;
                    newstationaryBiclycleNode.Next = last;
                }
                else
                {
                    for (int i = 1; i < position - 1; i++)
                    {
                        last = last.Next;
                        if (last.Next == null)
                            break;
                    }
                    StationaryBiclycleNode lastNext;
                    lastNext = last.Next;
                    last.Next = newstationaryBiclycleNode;
                    newstationaryBiclycleNode.Next = lastNext;
                }
            }
        }


        public void Print()
        {
            StationaryBiclycleNode sb = Head;
            while (sb != null)
            {
                Console.WriteLine($"Cost: {sb.StationaryBicycle.cost} - Color: {sb.StationaryBicycle.Color} - Units: {sb.StationaryBicycle.Units}");
                sb = sb.Next;
            }
        }
    }
}

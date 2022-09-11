using System;

namespace DZ_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building1 = new Building();
            building1.AddHeightOfBuilding(48);
            building1.AddLevelsNumber(15);
            building1.AddApartmentsNumberOnLevel(5);
            building1.AddEntrancesNumber(3);
            building1.PrinBuildingInfo();

            Building building2 = new Building(30, 9, 4, 5);
            building2.PrinBuildingInfo();
        }
    }
}

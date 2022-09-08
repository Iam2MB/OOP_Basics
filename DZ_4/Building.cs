using System;
using System.Collections.Generic;
using System.Text;

namespace DZ_4
{
    public class Building
    {
        static uint _counter = 1;

        uint _idOfBuilding { get; set; }
        float _heightOfBuilding { get; set; }
        uint _levelsNumber { get; set; }
        uint _apartmentsNumberOnLevel { get; set; }
        uint _entrancesNumber { get; set; }

        /// <summary>
        /// BuildingParam
        /// </summary>
        /// <param высота дома="height"></param>
        /// <param этажность="levels"></param>
        /// <param квартир на этаже="levelapartments"></param>
        /// <param кол-во подъездов="entrances"></param>
        public Building(float height, uint levels, uint levelapartments, uint entrances)
        {
            _heightOfBuilding = height;
            _levelsNumber = levels;
            _apartmentsNumberOnLevel = levelapartments;
            _entrancesNumber = entrances;
            _idOfBuilding = _counter++;
        }

        public Building()
        {
            _idOfBuilding = _counter++;
        }

        public void AddParamBuilding(float height, uint levels, uint levelapartments, uint entrances)
        {
            _heightOfBuilding = height;
            _levelsNumber = levels;
            _apartmentsNumberOnLevel = levelapartments;
            _entrancesNumber = entrances;
        }

        public void PrinBuildingInfo()
        {
            Console.WriteLine($"Номер здания:     \t{_idOfBuilding}");
            Console.WriteLine($"Высота:           \t{_heightOfBuilding}м");
            Console.WriteLine($"Количество этажей:\t{_levelsNumber}");
            Console.WriteLine($"Высота этажа:     \t{HeightOfLevel()}м");
            Console.WriteLine($"Квартир на этаже: \t{_apartmentsNumberOnLevel}");
            Console.WriteLine($"Квартир в доме:   \t{ApartmentsNumber()}");
            Console.WriteLine($"Количество подъездов:\t{_entrancesNumber}");
            Console.WriteLine();
        }

        public float AddHeightOfBuilding(float value)
        {
            return _heightOfBuilding = value;
        }

        public uint AddLevelsNumber(uint value)
        {
            return _levelsNumber = value;
        }

        public float HeightOfLevel()
        {
            float height = MathF.Round((_heightOfBuilding / _levelsNumber), 2);

            if (height > 0)
            {
                return height;
            }
            else
            {
                return 0;
            }
        }

        public uint AddApartmentsNumberOnLevel(uint value)
        {
            return _apartmentsNumberOnLevel = value;
        }

        public uint AddEntrancesNumber(uint value)
        {
            return _entrancesNumber = value;
        }

        public uint ApartmentsNumber()
        {
            uint apartmentsNumber = _apartmentsNumberOnLevel * _levelsNumber * _entrancesNumber;
            return apartmentsNumber;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6._2
{
    internal class CatalogOfPlanets
    {
        private int _errorCounter;
        private readonly List<Planet> _planets = new();
        public CatalogOfPlanets()
        {
            var venus = new Planet("Венера", 2, 38025, null);
            var earth = new Planet("Земля", 3, 47075, venus);
            var mars = new Planet("Марс", 4, 21344, earth);
            _planets.Add(venus);
            _planets.Add(earth);
            _planets.Add(mars);
        }
        public (int, int, string) GetPlanet(string name)
        {
            _errorCounter++;
            if (_errorCounter % 3 == 0)
            {
                return (0, 0, "Вы спрашиваете слишком часто");
            }
            foreach (var planet in _planets)
            {
                if(planet.Name == name)
                {
                    return (planet.IdFromSun, planet.EquatorLength, null);
                }
            }
            return (0, 0, "Не удалось найти планету");
        }

    }
}

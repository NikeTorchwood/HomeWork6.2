using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6._2
{
    internal class Planet
    {
        public string Name{get;private set;}
        public int IdFromSun{get; private set;}
        public int EquatorLength{get; private set;}
        private Planet _prevPlanet;

        public Planet(string name, int idFromSun, int equatorLength, Planet planet)
        {
            Name= name;
            IdFromSun= idFromSun;
            EquatorLength= equatorLength;
            _prevPlanet = planet;
        }
    }
}

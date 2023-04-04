using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.SpaceAge
{
    internal class SpaceAge
    {
        private float _years;
        private float _informedYear;

        public SpaceAge(int seconds)
        {
            float yearInSeconds = 31557600f;
            _informedYear = seconds / yearInSeconds;
        }

        public float OnEarth()
        {
            return _informedYear;
        }

        public float OnMercury()
        {
            return _informedYear / orbitalPeriodInYears("Mercury");
        }

        public float OnVenus()
        {
            return _informedYear / orbitalPeriodInYears("Venus");
        }

        public float OnMars()
        {
            return _informedYear / orbitalPeriodInYears("Mars");
        }

        public float OnJupiter()
        {
            return _informedYear / orbitalPeriodInYears("Jupiter");
        }

        public float OnSaturn()
        {
            return _informedYear / orbitalPeriodInYears("Saturn");
        }

        public float OnUranus()
        {
            return _informedYear / orbitalPeriodInYears("Uranus");
        }

        public float OnNeptune()
        {
            return _informedYear / orbitalPeriodInYears("Neptune");
        }

        //Mercury: orbital period 0.2408467 Earth years
        //Venus: orbital period 0.61519726 Earth years
        //Earth: orbital period 1.0 Earth years, 365.25 Earth days, or 31557600 seconds
        //Mars: orbital period 1.8808158 Earth years
        //Jupiter: orbital period 11.862615 Earth years
        //Saturn: orbital period 29.447498 Earth years
        //Uranus: orbital period 84.016846 Earth years
        //Neptune: orbital period 164.79132 Earth years

        private float orbitalPeriodInYears(string planet)
        {
            switch (planet)
            {
                case "Mercury":
                    return _years = 0.2408467f;
                case "Venus":
                    return _years = 0.61519726f;
                case "Mars":
                    return _years = 1.8808158f;
                case "Jupiter":
                    return _years = 11.862615f;
                case "Saturn":
                    return _years = 29.447498f;
                case "Uranus":
                    return _years = 84.016846f;
                case "Neptune":
                    return _years = 164.79132f;
                default:
                    return _years = 1f;
            }
        }
    }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnPackageManager
{
    internal class Temperature
    {
        private float _temperature;
        
        public float TempInFerenheit { 
            get { return _temperature; }//getter
            set { //setter
            if (value > 1000 || value < -200)
                { throw new ArgumentOutOfRangeException("value to high"); }
            _temperature = value;
            } }
        public float TempInCelcius { get { return (_temperature - 32) * 5 / 9; } }
        public float TempInKelvin { get { return TempInCelcius + 273.15f; } }

        public Temperature(float temperatureInFerenheit)
        {
            _temperature = temperatureInFerenheit;      
        }
    }
}

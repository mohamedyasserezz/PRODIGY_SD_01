using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODIGY_SD_01
{
    public class UserInterface
    {
        private readonly double _temperature;
        private readonly char _unit;

        private UserInterface(double temperature, char unit)
        {
            _temperature = temperature;
            _unit = char.ToUpper(unit);
        }

        public void StartConversion()
        {
            TemperatureConverter converter = new TemperatureConverter(_temperature, _unit);
            converter.ConvertTemperature();
        }

        public class Builder
        {
            private double _temperature;
            private char _unit;

            public Builder SetTemperature(double temperature)
            {
                _temperature = temperature;
                return this;
            }

            public Builder SetUnit(char unit)
            {
                _unit = char.ToUpper(unit);
                return this;
            }

            public UserInterface Build()
            {
                return new UserInterface(_temperature, _unit);
            }
        }
    }
}

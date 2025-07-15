using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTProject.lab1
{

    public class TempConverter
    {

        public double ConvertTemp(double temperature, char from, char to)
        {
            if (from == to)
            {
                return temperature;
            }
            switch (from)
            {
                case 'C':
                    if (to == 'F')
                    {
                        return temperature * 1.8 + 32;
                    }
                    else if (to == 'K')
                    {
                        return temperature + 273.15;
                    }
                    break;
                case 'F':
                    if (to == 'C')
                    {
                        return (temperature - 32) / 1.8;
                    }
                    else if (to == 'K')
                    {
                        return (temperature + 459.67) * 5 / 9;
                    }
                    break;
                case 'K':
                    if (to == 'C')
                    {
                        return temperature - 273.15;
                    }
                    else if (to == 'F')
                    {
                        return temperature * 9 / 5 - 459.67;
                    }
                    break;
            }
            throw new ArgumentException("Invalid temperature unit");
        }
    }
}

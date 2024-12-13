using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace UnitConversionService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double ConvertLength(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == "meters" && toUnit == "kilometers")
                return value / 1000;
            else if (fromUnit == "meters" && toUnit == "feet")
                return value * 3.28084;
            else if (fromUnit == "kilometers" && toUnit == "meters")
                return value * 1000;
            else if (fromUnit == "kilometers" && toUnit == "feet")
                return value * 3280.84;
            else if (fromUnit == "feet" && toUnit == "meters")
                return value / 3.28084;
            else if (fromUnit == "feet" && toUnit == "kilometers")
                return value / 3280.84;
            else
                return value; // Same unit
        }

        public double ConvertWeight(double value, string fromUnit, string toUnit)
        {
            if (fromUnit == "grams" && toUnit == "kilograms")
                return value / 1000;
            else if (fromUnit == "grams" && toUnit == "pounds")
                return value * 0.00220462;
            else if (fromUnit == "kilograms" && toUnit == "grams")
                return value * 1000;
            else if (fromUnit == "kilograms" && toUnit == "pounds")
                return value * 2.20462;
            else if (fromUnit == "pounds" && toUnit == "grams")
                return value * 453.592;
            else if (fromUnit == "pounds" && toUnit == "kilograms")
                return value / 2.20462;
            else
                return value; // Same unit
        }

        public string GetData(int value)
        {
            throw new NotImplementedException();
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }

}

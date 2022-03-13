using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BikeFactory.Business
{
    public class Validator
    {
        public bool checkModel(string str)
        {
            string modelEx = @"^\d{5}$";
            return new Regex(modelEx).IsMatch(str);
        }
        public bool checkSerial(string str)
        {
            string serialEx = @"^\d$";
            return new Regex(serialEx).IsMatch(str);
        }
        public bool checkYear(string str)
        {
            string yearEx = @"^\d{4}$";
            return new Regex(yearEx).IsMatch(str);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory.Business
{
    public enum ESuspensionType
    {
        Front, Rear, Dual
    }
    public class MountainBike:Bike
    {
        private ESuspensionType _type;

        public MountainBike(int serialNum, int model, EColor color, int manufacturingYear, ESuspensionType eSuspension) : base(serialNum, model, color, manufacturingYear)
        {
            _type = eSuspension;
        }

        public ESuspensionType Type { get => _type; set => _type = value; }
    }
}

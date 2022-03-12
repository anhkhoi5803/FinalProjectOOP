using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory.Business
{
    public enum ETireType
    {
        Regular, Commuter, Gravel
    }
    public class RoadBike:Bike
    {
        private ETireType _type;

        public RoadBike(int serialNum, int model, EColor color, int manufacturingYear, ETireType eTire) : base(serialNum,  model,  color,  manufacturingYear)
        {
            _type = eTire;
        }

        public ETireType Type { get => _type; set => _type = value; }
    }
}

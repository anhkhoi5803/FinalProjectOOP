using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeFactory.Business
{
    public enum EColor
    {
        Black, Blue, Red, Green
    }
    
    
    public abstract class Bike
    {
        private int _serialNum;
        private int _model;
        private EColor _color;
        private int _manufacturingYear;

        

        public int SerialNum { get => _serialNum; set => _serialNum = value; }
        public int Model { get => _model; set => _model = value; }
        public EColor Color { get => _color; set => _color = value; }
        public int ManufacturingYear { get => _manufacturingYear; set => _manufacturingYear = value; }

        protected Bike(int serialNum, int model, EColor color, int manufacturingYear)
        {
            _serialNum = serialNum;
            _model = model;
            _color = color;
            _manufacturingYear = manufacturingYear;
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class CCar: CVehicle
    {
        //Car property
        public int NumberOfDoors { get; set; }

        
        public CCar(int _NumDoors, string _make, string _model, DateTime _year, VehicleTypes _Vehicletype, int _count) : base(_make,_model,  _year, _Vehicletype,  _count)
        {
            NumberOfDoors = _NumDoors;
        }
        public override string DisplayInfo()
        {
            string sInfo = "Vehicle Type: " + type + "\n" +
                "make " + Make + "\n" +
                "model " + model + "\n" +
                "number of doors " + NumberOfDoors + "\n" +
                "year: " + year;

            return sInfo;
        }
    }
}

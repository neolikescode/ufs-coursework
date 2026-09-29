using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class CMotorCycle:CVehicle
    {
        public string motorcycle { get; set; }

        public CMotorCycle(string _motorcycle, string _make, string _model, DateTime _year, VehicleTypes _Vehicletype, int _count)
            : base(_make, _model, _year, _Vehicletype, _count)
        {
            motorcycle = _motorcycle;
        }
        public new virtual string DisplayInfo()
        {
            string sInfo = "Vehicle Type: " + type + "\n" +
                "make " + Make + "\n" +
                "model " + model + "\n" +
                "type of motorcycle " + motorcycle + "\n" +
                "year: " + year.ToString("yyyy");

            return sInfo;
        }
    }
}

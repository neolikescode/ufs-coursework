using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class CSUV:CVehicle
    {
        public double displacement { get; set; }

        public CSUV(double _displacement, string _make, string _model, DateTime _year, VehicleTypes _Vehicletype, int _count)
            :base(_make, _model, _year, _Vehicletype, _count)
        {
            displacement = _displacement;
        }
        public new virtual string DisplayInfo()
        {
            string sInfo = "Vehicle Type: " + type + "\n" +
                "make " + Make + "\n" +
                "model " + model + "\n" +
                "Displacement " + displacement + "\n" +
                "year: " + year.ToString("yyyy");

            return sInfo;
        }
    }
}

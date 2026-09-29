using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class CVehicle
    {
        //Properties
        public string Make { get; set; }
        public string model { get; set; }
        public DateTime year { get; set; }
        public  VehicleTypes type { get; set; }
        public int count { get; set; }

        public CVehicle(string _make, string _model, DateTime _year, VehicleTypes _Vehicletype, int _count)
        {
            Make = _make;
            model = _model;
            year = _year;
            type =_Vehicletype;
        }
        //method
        public virtual string DisplayInfo()
        {
            string sInfo = "Vehicle Type: " + type + "\n"+
                "make " + Make +"\n"+
                "model "+ model +"\n"+
                "year: "+ year.ToString("yyyy") ;

            return sInfo;
        }
    }
}

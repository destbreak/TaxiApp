using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiApp
{
    public class Taxi
    {
        public string DriverName { get; set; }
        public string DriverStatus { get; set; }
        public bool OnDuty { get; set; }
        public int NumPassenger { get; set; }

        public void TaxiInfo()
        {
            Console.WriteLine("Driver Name          : {0}", DriverName);
            if(OnDuty == true)
            {
              DriverStatus = "Yes";
              Console.WriteLine("On Duty              : {0}", DriverStatus);
              Console.WriteLine("Number of Passenger  : {0}", NumPassenger);
            }else
            {
              DriverStatus = "No";
              Console.WriteLine("On Duty              : {0}", DriverStatus);
            }
        }
    }
}

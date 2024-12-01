using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            vehicles MyVehicle= new vehicles();
            vehicles Car = new car();
            vehicles Bicycle=new Bicycle(); 
            vehicles Boat=new Boat();

            MyVehicle.ShowVehiclesTypes();
            Car.ShowVehiclesTypes();
            Bicycle.ShowVehiclesTypes();
            Boat.ShowVehiclesTypes();
        }
    }
}

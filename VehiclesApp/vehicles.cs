using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehiclesApp
{
    internal class vehicles
    {
        public virtual void ShowVehiclesTypes()
        {
            Console.WriteLine("Type of Vehicle");
           
        }
    }
    class car : vehicles 
    {
        public override void ShowVehiclesTypes()
        {
            Console.WriteLine("Type of Vehicle - On the road");
           
        }
    }
    class Bicycle : vehicles
    { 
        public override void ShowVehiclesTypes()
        {
            Console.WriteLine("Type of Vehicle - on the road ");
          
        }
    }
    class Boat : vehicles
    {
        public override void ShowVehiclesTypes()
        {
            Console.WriteLine("Type of Vehicle - on the surface of the water ");
            Console.ReadKey(); 
        }
     
    }





}

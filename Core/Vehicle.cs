using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Vehicle
    {
        public async Task TravelAsync()
        {
            Console.WriteLine("Neqliyyat vasitesi yola cixdi");
            await Task.Delay(3000); 
            Console.WriteLine("hedef yerine catti");
        }
    }
}

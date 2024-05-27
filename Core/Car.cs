using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Car
    {
        public async Task DriveAsync()
        {
            Console.WriteLine("Masin surulmeye basladi");
            await Task.Delay(2000); 
            Console.WriteLine("Masin hedef bolgesine catti");
        }
    }
}

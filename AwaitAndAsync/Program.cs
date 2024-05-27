using Core;

namespace AwaitAndAsync
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var car = new Car();
            await car.DriveAsync();

            var vehicle = new Vehicle();
            await vehicle.TravelAsync();
        }
    }
}

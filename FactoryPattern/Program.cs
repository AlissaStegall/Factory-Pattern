using System.Buffers.Text;
using System.ComponentModel;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of tires for the vehicle you want to create");

            int tireCount;
            var input = int.TryParse(Console.ReadLine(), out tireCount);

            var vehicle = VehicleFactory.GetVehicle(tireCount);
            
            vehicle.Drive();
        }
    }
}

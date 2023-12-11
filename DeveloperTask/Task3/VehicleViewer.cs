using DeveloperTask.Task1;
using DeveloperTask.Task2;

namespace DeveloperTask.Task3
{
    internal static class VehicleViewer
    {
        public static void ViewVehicles() 
        {
            var vehicleInstances = InstanceService<Vehicle>.GetInstances();
            foreach (var item in vehicleInstances.OrderBy(t => t.GetType().Name).ToList())
            {
                Console.WriteLine(item.GetType().Name);
            }
        }

        public static IEnumerable<Vehicle> SearchForVehicles(string namePart) 
        {
            return InstanceService<Vehicle>.GetInstances().Where(i => i.GetType().Name.ToLower().Contains(namePart.ToLower())).ToList();
        }
    }
}

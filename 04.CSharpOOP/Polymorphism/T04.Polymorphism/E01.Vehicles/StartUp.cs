using E01.Vehicles.Core;
using E01.Vehicles.Core.Contracts;
using System;

namespace E01.Vehicles
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IEngine engine = new Engine();
            engine.Run();
        }
    }
}

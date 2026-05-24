using MilitaryElite.Core;

namespace P07.MilitaryElite;
public class StartUp
{
    static void Main(string[] args)
    {
        IEngine engine = new Engine();
        engine.Run();
    }
}

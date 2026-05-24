using MyLogger.Core;

namespace MyLogger;
internal class StartUp
{
    static void Main(string[] args)
    {
        Engine engine = new Engine();
        engine.Run();
    }
}

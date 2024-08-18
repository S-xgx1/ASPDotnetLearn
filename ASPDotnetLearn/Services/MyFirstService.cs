using ASPDotnetLearn.Shared;
using MagicOnion;
using MagicOnion.Server;

namespace ASPDotnetLearn.Services;

public class MyFirstService : ServiceBase<IMyFirstService>, IMyFirstService
{
    public async UnaryResult<int> SumAsync(int x, int y)
    {
        Console.WriteLine($"Received:{x}, {y}");
        return x + y;
    }
}
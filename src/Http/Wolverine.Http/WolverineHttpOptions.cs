using System.Text.Json;
using Lamar;

namespace Wolverine.Http;

[Singleton]
public class WolverineHttpOptions
{
    public JsonSerializerOptions JsonSerializerOptions { get; set; } = new();
}
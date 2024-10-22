using System.Runtime.CompilerServices;

namespace Interceptors;

public static class Interceptor
{
    [InterceptsLocation("C:\\Dropbox\\Work\\PluralSight\\dot-net-8-whats-new\\m3\\Demos\\CSharp12NewFeatures\\Interceptors\\Program.cs", line: 11, column: 13)]
    [InterceptsLocation("C:\\Dropbox\\Work\\PluralSight\\dot-net-8-whats-new\\m3\\Demos\\CSharp12NewFeatures\\Interceptors\\Program.cs", line: 13, column: 13)]
    public static void InterceptorDisplay(this Pie ex, string name)
    {
        Console.WriteLine($"Interceptor Display {name}");
    }
}

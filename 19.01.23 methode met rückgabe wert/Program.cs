double x = 4;
Console.WriteLine($"f(g(x)) = {f(f(g(x)))}");
Console.WriteLine($"g(f(x)) = {g(f(x))}");

static double f(double x)
{
    return 2 * x;
}
static double g(double x)
{
    return x * x;
}
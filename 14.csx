public bool areaTriangulo(double bas1, double alt1, double bas2, double alt2, double bas3, double alt3)
{
    double a = (bas1 * alt1) /2;
    double b = (bas2 * alt2) /2;
    double c = (bas3 * alt3) /2;
    bool d = a == b && a == c;
    return d;
}

bool x = areaTriangulo(5, 4, 5, 5, 5, 5);
Console.WriteLine(x);
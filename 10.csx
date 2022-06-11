public double hipotenusa(double catO, double catA){
    double a = catA * catA + catO * catO;
    double b =  Math.Sqrt(a);
    return b;
}

double x = hipotenusa(3, 4);
Console.WriteLine(x);

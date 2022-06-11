public bool verificar(double b1, double h1, double b2, double h2){
    double ret1 = b1 * h1;
    double ret2 = b2 * h2;
    bool iguais = ret1 == ret2;
    return iguais;
}

bool x = verificar(5, 5, 5, 5);
Console.WriteLine(x);
public double compra(double valor, double cupom){
    double cm = valor - cupom;
    return cm;
}

double x = compra(25, 10);
Console.WriteLine(x);
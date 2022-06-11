public double CalcularTotal(double valorCompra, double cupom)
{
    double desconto = valorCompra * cupom / 100;
    double total = valorCompra - desconto;
    return total;
}



double x = CalcularTotal(120, 10);
Console.WriteLine(x);
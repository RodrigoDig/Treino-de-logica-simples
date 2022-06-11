public bool verificar(double l1, double l2){
    double qua1 = l1 * l1;
    double qua2 = l2 * l2;
    bool iguais = qua1 == qua2;
    return iguais;
}

bool x = verificar(5, 5);
Console.WriteLine(x);
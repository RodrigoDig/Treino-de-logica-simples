public bool equilatero(double lado1, double lado2, double lado3){
    bool a = lado1 == lado2;
    bool b = lado1 == lado3;
    bool c = a == b;
    return c;
}

bool x = equilatero(2, 2, 2);
Console.WriteLine(x);
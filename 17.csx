public bool corPrimaria(string cor)
{
    bool primaria = cor == "azul" || cor == "amarelo" || cor == "vermelho";
    return primaria;
}

bool x = corPrimaria("azul");
Console.WriteLine(x);
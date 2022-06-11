public bool coresPrimarias(string cor1, string cor2)
{
    bool primaria1 = cor1 == "azul" || cor1 == "vermelho" || cor1 == "amarelo";
    bool primaria2 = cor2 == "azul" || cor2 == "vermelho" || cor2 == "amarelo";
    bool confirmacao = primaria1 == true && primaria2 == true;
    return confirmacao;
}

bool x = coresPrimarias("vermelho", "preto");
Console.WriteLine(x);
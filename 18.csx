public bool farolPedestre(string farol)
{
    bool atravessar = farol == "verde";
    return atravessar;
}

bool x = farolPedestre("vermelho");
Console.WriteLine(x);
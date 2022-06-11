public bool passou(double nota1, double nota2, double nota3){
    double media = (nota1 + nota2 + nota3) /3;
    bool aprovado = media >= 5;
    return aprovado;
}

bool x = passou(10, 9, 8);
Console.WriteLine(x);
public double nota(double nota1, double nota2, double nota3, double nota4, double nota5){
    double media = (nota1 + nota2 + nota3 + nota4 + nota5) /5;
    return media;
}

double x = nota(10, 9, 8, 8, 9);
Console.WriteLine(x);
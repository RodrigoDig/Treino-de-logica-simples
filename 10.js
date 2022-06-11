function hipotenusa(ca, co)
{
    let somaQuadCatetos = ca * ca + co * co;
    let hip = Math.Sqrt(somaQuadCatetos);
    return hip;
}


x = hipotenusa(3, 4);
console.log(x);
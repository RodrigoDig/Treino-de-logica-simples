function coresPrimarias(cor1, cor2)
{
    let primaria1 = cor1 == "azul" || cor1 == "vermelho" || cor1 == "amarelo";
    let primaria2 = cor2 == "azul" || cor2 == "vermelho" || cor2 == "amarelo";
    let confirmacao = primaria1 == true && primaria2 == true;
    return confirmacao;
}

let x = coresPrimarias("vermelho", "preto");
console.log(x);

function valorFinal(compra, cupom){
    let desconto = compra * cupom / 100;
    let a = compra - desconto;
    return a ;
}

let x = valorFinal(300, 10);
console.log(x);
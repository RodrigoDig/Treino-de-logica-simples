
function equilatero(lado1, lado2, lado3){
    let a = lado1 == lado2;
    let b = lado1 == lado3;
    let c = a == b;
    return c;
}
let x = equilatero(2, 5, 2);
console.log(x);
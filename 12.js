function mesmaArea(lado1, lado2){
    let a = lado1 * lado1;
    let b = lado2 * lado2;
    let c = a == b;
    return c;
}
let x = mesmaArea(5, 5, 5, 5);
console.log(x);
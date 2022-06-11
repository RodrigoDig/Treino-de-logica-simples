function areaTriangulo(bas1, alt1, bas2, alt2, bas3, alt3){
    let a = (bas1 * alt1) /2;
    let b = (bas2 * alt2) /2;
    let c = (bas3 * alt3) /2;
    let d = a == b && a == c;
    return d;
}

let x = areaTriangulo(5, 5, 5, 5, 8, 5);
console.log(x);

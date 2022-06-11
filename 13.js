
function mesmaArea(bas1, alt1, bas2, alt2){
    let a = bas1 * alt1;
    let b = bas2 * alt2;
    let c = a == b;
    return c;
}
let x = mesmaArea(5, 5, 5, 5);
console.log(x); 

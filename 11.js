function aprovado(nota1, nota2, nota3){
    let a = (nota1 + nota2 + nota3) /3;
    let b = a >=5;
    return b;
    
}
let x = aprovado(5, 5, 5);
console.log(x);
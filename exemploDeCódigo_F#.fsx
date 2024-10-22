// Definindo um módulo
module MathOperations =

    // Função para calcular o fatorial de um número
    let rec factorial n =
        if n < 0 then
            failwith "Número deve ser não-negativo"
        elif n = 0 then
            1
        else
            n * factorial (n - 1)

    // Função para calcular a soma de uma lista de inteiros
    let sumList numbers =
        List.fold (+) 0 numbers

    // Função para verificar se um número é primo
    let isPrime n =
        let rec checkDivisor d =
            d * d > n || (n % d <> 0 && checkDivisor (d + 1))
        n > 1 && checkDivisor 2


// Exemplo de uso do fatorial
let fact5 = MathOperations.factorial 5
printfn "Fatorial de 5 é: %d" fact5

// Exemplo de uso da soma de lista
let sum = MathOperations.sumList [1; 2; 3; 4; 5]
printfn "Soma da lista é: %d" sum

// Exemplo de verificação de número primo
let isFivePrime = MathOperations.isPrime 5
printfn "5 é primo? %b" isFivePrime

// Retornando 0 para indicar sucesso
0

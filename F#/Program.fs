open System

//let Stepeni n =
//    [for i in 0..n do
//        yield pown 2 i]

//[<EntryPoint>]
//let main arg =
//    printfn "Введите максимальную степень числа 2"
//    let n = int(Console.ReadLine())
//    if n < 0 then
//        printfn "Ошибка, число должно быть положительным"
//    else
//        let powers = Stepeni n
//        printfn "Наш список"
//        printfn "%A" powers
//    0


let rec firstDigit n =
    if n < 10 then
        n
    else
        firstDigit (n / 10)

[<EntryPoint>]
let main arg =
    printfn "Введите натуральное число"
    let n = int(Console.ReadLine())
    if n < 0 then
        printfn "Ошибка, число должно быть натуральным"
    else
        let result = firstDigit n
        printfn "Первая цифра числа %i: %i" n result
    0
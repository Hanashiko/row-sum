module Lab2task2
let rec sumSquares (n: int) (acc: float) =
    if n = 0 then acc
    else sumSquares (n - 1) (acc + (1.0 / (float(n * n))))

let n = 10

let result = sumSquares n 0.0

printfn "Сума: %f" result

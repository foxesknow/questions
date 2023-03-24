// For more information see https://aka.ms/fsharp-console-apps

Inefficient.fib 10 |> printfn "Inefficient: %A"
Inefficient.fib 20 |> printfn "Inefficient: %A"
Inefficient.fib 30 |> printfn "Inefficient: %A"
Inefficient.fib 40 |> printfn "Inefficient: %A"  // <- Slooooooooooow!

Sequencial.fib 10 |> printfn "Sequencial: %A"
Sequencial.fib 20 |> printfn "Sequencial: %A"
Sequencial.fib 30 |> printfn "Sequencial: %A"
Sequencial.fib 40 |> printfn "Sequencial: %A"
Sequencial.fib 50 |> printfn "Sequencial: %A"

TailRecursive.fib 10 |> printfn "TailRecursive: %A"
TailRecursive.fib 20 |> printfn "TailRecursive: %A"
TailRecursive.fib 30 |> printfn "TailRecursive: %A"
TailRecursive.fib 40 |> printfn "TailRecursive: %A"
TailRecursive.fib 50 |> printfn "TailRecursive: %A"

Memoization.fib 10 |> printfn "Memoization: %A"
Memoization.fib 20 |> printfn "Memoization: %A"
Memoization.fib 30 |> printfn "Memoization: %A"
Memoization.fib 40 |> printfn "Memoization: %A"
Memoization.fib 50 |> printfn "Memoization: %A"

printf "Done"

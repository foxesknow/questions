module TailRecursive

[<Struct>]
type private Accumulator = {
    Current : bigint; 
    Next : bigint
}

//
// An implementation of Sequential.fib but using tail recursion
//
let fib (position : int64) =
    let rec loop (acc : Accumulator) position =
        match position with
        | _ when position = 0L -> acc
        | _                 ->  loop {Current = acc.Next; Next = acc.Current + acc.Next} (position - 1L)

    let answer = loop {Current = 0I; Next = 1I} position
    answer.Current
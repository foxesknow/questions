module Sequencial

//
// Loops forward from zero up to the position in the sequence.
// The downside is it uses mutable variables (oh-no!)
//
let fib (position : int64) =
    let mutable current = 0I
    let mutable next = 1I

    let mutable count = position

    while count <> 0L do 
        let newCurrent, newNext = next, current + next
        current <- newCurrent
        next <- newNext
        
        count <- count - 1L

    current


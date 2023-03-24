module Inefficient

//
// A classic implementation of Fibonacci where we use recursion to work out the answer.
// For small numbers it's not a problem, but it doesn't scale as "position" gets bigger.
//
let rec fib (position : int64) =
    match position with
    | _ when position = 0L -> 0I
    | _ when position = 1L -> 1I
    | _                    -> fib (position - 1L) + fib (position - 2L)


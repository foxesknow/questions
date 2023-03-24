module Memoization

//
// A memoized fibonacci where we remember the value at a given position with the sequence.
// This means when we recurse pack down to that position we've already got the value
//
let rec fib (position : int64) =
    
    let cache = System.Collections.Generic.Dictionary<int64, bigint>()

    let rec fibRec (position : int64) =
        match position with
        | _ when position = 0 -> 0I
        | _ when position = 1 -> 1I
        | _                   -> match cache.TryGetValue(position) with
                                 | (true, value) -> value
                                 | (false, _)    -> let value = fibRec (position - 1L) + fibRec (position - 2L)
                                                    cache[position] <- value
                                                    value

    fibRec position
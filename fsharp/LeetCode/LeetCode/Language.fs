namespace LeetCode

open NUnit.Framework

module Language =
    let loop acc body state  =
        let rec exec body acc state =
            let (newAcc, newState, keepGoing) = body acc state
            match keepGoing with
            | false -> newAcc
            | true -> exec body newAcc newState 

        exec body acc state

    type Tests() =
        [<Test>]
        member this.Example1() =
            let total = 10 |> loop 0 (fun acc state ->
                match state with
                | 0 -> (acc, 0, false)
                | x -> ((acc + x), (x - 1), true)
            )

            Assert.That(total, Is.EqualTo(55));


namespace LeetCode

open NUnit.Framework

//[<AutoOpen>]
module Language =
    type LoopResult<'TAcc, 'TData, 'TResult> =
        | Return of 'TResult
        | Loop of 'TAcc * 'TData

    let looper acc body state  =
        let rec exec body acc data =
            let result = body acc data
            match result with
            | Return answer -> answer
            | Loop(acc, data) -> exec body acc data

        exec body acc state

    type Tests() =
        [<Test>]
        member this.``Add to 10``() =
            let total = 10 |> looper 0 (fun acc data ->
                match data with
                | 0 -> Return acc
                | x -> Loop ((acc + x), (x - 1))
            )

            Assert.That(total, Is.EqualTo(55));

        [<Test>]
        member this.``Reverse a list``() =
            let reversed = [1; 2; 3; 4] |> looper [] (fun acc data ->
                match data with
                | [] -> Return acc
                | hd :: rest -> Loop(hd :: acc, rest)
            )

            let array = reversed |> List.toArray
            Assert.That(array, Has.Length.EqualTo(4));
            Assert.That(array[0], Is.EqualTo(4));
            Assert.That(array[1], Is.EqualTo(3));
            Assert.That(array[2], Is.EqualTo(2));
            Assert.That(array[3], Is.EqualTo(1));


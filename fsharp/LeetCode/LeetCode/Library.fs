namespace LeetCode

open NUnit.Framework

module Q001_TwoSum =
    let twoSum nums target =
        let rec find target index nums map =
            match nums with
            | number :: rest ->
                match Map.tryFind (target - number) map with
                | Some(value) -> [index; value]
                | _ -> Map.add number index map |> find target (index + 1) rest

            | [] -> []
            
        find target 0 nums Map.empty

    type Tests() =
        [<Test>]
        member this.Example1() =
            let results = twoSum [2; 7; 11; 15] 9 |> List.toArray
            Assert.That(results, Contains.Item(1))
            Assert.That(results, Contains.Item(0))

        [<Test>]
        member this.Example2() =
            let results = twoSum [3; 2; 4] 6 |> List.toArray
            Assert.That(results, Contains.Item(1))
            Assert.That(results, Contains.Item(2))

        [<Test>]
        member this.Example3() =
            let results = twoSum [3; 3] 6 |> List.toArray
            Assert.That(results, Contains.Item(0))
            Assert.That(results, Contains.Item(1))

        [<Test>]
        member this.Example4() =
            let results = twoSum [3; 4] 8 |> List.toArray
            Assert.That(results, Has.Length.EqualTo(0))

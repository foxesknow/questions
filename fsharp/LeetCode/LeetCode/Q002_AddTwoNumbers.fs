namespace LeetCode

open NUnit.Framework

module Q002_AddTwoNumbers =
    let digitCarry total =
        let digit = total % 10
        let carry = total / 10
        (digit, carry)

    let addTwoNumbers l1 l2 =
        let rec recurse left right carry =
            match (left, right, carry) with
            | (l :: lrest, r :: rrest, c) ->    let digit, carry = digitCarry (l + r + c) in digit :: recurse lrest rrest carry
            | (l :: lrest, [], c) ->            let digit, carry = digitCarry (l + c) in digit :: recurse lrest [] carry
            | ([], r :: rrest, c) ->            let digit, carry = digitCarry (r + c) in digit :: recurse [] rrest carry
            | ([], [], 1) ->                    [1]
            | ([], [], _) ->                    []

        recurse l1 l2 0

    type Tests() =
        [<Test>]
        member this.Example1() =
            let results = addTwoNumbers [2; 4; 3] [5; 6; 4] |> List.toArray
            Assert.That(results, Has.Length.EqualTo(3))
            Assert.That(results[0], Is.EqualTo(7))
            Assert.That(results[1], Is.EqualTo(0))
            Assert.That(results[2], Is.EqualTo(8))

        [<Test>]
        member this.Example2() =
            let results = addTwoNumbers [0] [0] |> List.toArray
            Assert.That(results, Has.Length.EqualTo(1))
            Assert.That(results[0], Is.EqualTo(0))

        [<Test>]
        member this.Example3() =
            let results = addTwoNumbers [9; 9; 9; 9; 9; 9; 9] [9; 9; 9; 9] |> List.toArray
            Assert.That(results, Has.Length.EqualTo(8))
            Assert.That(results[0], Is.EqualTo(8))
            Assert.That(results[1], Is.EqualTo(9))
            Assert.That(results[2], Is.EqualTo(9))
            Assert.That(results[3], Is.EqualTo(9))
            Assert.That(results[4], Is.EqualTo(0))
            Assert.That(results[5], Is.EqualTo(0))
            Assert.That(results[6], Is.EqualTo(0))
            Assert.That(results[7], Is.EqualTo(1))

       

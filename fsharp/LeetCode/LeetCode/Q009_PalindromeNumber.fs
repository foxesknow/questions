namespace LeetCode

open NUnit.Framework

module Q009_PalindromeNumber =
    let reverse x =
        x |> Language.loop 0 (fun acc num ->
            match num with
            | 0 -> (acc, 0, false)
            | x -> (((acc * 10) + (x % 10)), num / 10, true) 
        );

    let isPalindrome x =
        match x with
        | n when n = 0 -> true
        | n when n < 0 -> false
        | n -> n = reverse n

    type Tests() =
        [<Test>]
        member this.Example1() =
            Assert.That(isPalindrome 121, Is.True);

        [<Test>]
        member this.Example2() =
            Assert.That(isPalindrome -121, Is.False);

        [<Test>]
        member this.Example3() =
            Assert.That(isPalindrome 10, Is.False);
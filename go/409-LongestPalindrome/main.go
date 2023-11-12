package main

import "fmt"

func longestPalindrome(s string) int {
	lookup := make(map[int]int)

	for _, c := range s {
		index := int(c)

		lookup[index]++

	}

	largestOddLength := 0
	largestOddCharacter := 0

	// The largest odd value will go in the middle of the palindrome
	for ascii, count := range lookup {
		if (count&1) == 1 && count > largestOddLength {
			largestOddLength = count
			largestOddCharacter = ascii
		}
	}

	sumOfEvens := 0
	sumOfRoundedDownOdds := 0

	/*
	 * Now we've got our stats the rule is that all even count characters
	 * can go in as they evenly divide either side of the center.
	 * For any remaining odd characters that aren't the largest one found above
	 * we round down to the nearest even count and use that
	 */
	for ascii, count := range lookup {
		if count == 0 || ascii == largestOddCharacter {
			continue
		}

		if (count & 1) == 0 {
			sumOfEvens += count
		} else {
			sumOfRoundedDownOdds += (count - 1)
		}

	}

	return sumOfEvens + sumOfRoundedDownOdds + largestOddLength
}

func test1() {
	fmt.Println(longestPalindrome("abccccdd"))
}

func test2() {
	fmt.Println(longestPalindrome("a"))
}

func test3() {
	input := "civilwartestingwhetherthatnaptionoranynartionsoconceivedandsodedicatedcanlongendureWeareqmetonagreatbattlefiemldoftzhatwarWehavecometodedicpateaportionofthatfieldasafinalrestingplaceforthosewhoheregavetheirlivesthatthatnationmightliveItisaltogetherfangandproperthatweshoulddothisButinalargersensewecannotdedicatewecannotconsecratewecannothallowthisgroundThebravelmenlivinganddeadwhostruggledherehaveconsecrateditfaraboveourpoorponwertoaddordetractTgheworldadswfilllittlenotlenorlongrememberwhatwesayherebutitcanneverforgetwhattheydidhereItisforusthelivingrathertobededicatedheretotheulnfinishedworkwhichtheywhofoughtherehavethusfarsonoblyadvancedItisratherforustobeherededicatedtothegreattdafskremainingbeforeusthatfromthesehonoreddeadwetakeincreaseddevotiontothatcauseforwhichtheygavethelastpfullmeasureofdevotionthatweherehighlyresolvethatthesedeadshallnothavediedinvainthatthisnationunsderGodshallhaveanewbirthoffreedomandthatgovernmentofthepeoplebythepeopleforthepeopleshallnotperishfromtheearth"
	fmt.Println(longestPalindrome(input))
}

func main() {
	//test1()
	//test2()
	test3()
}

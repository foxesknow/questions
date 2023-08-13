package main

import (
	"fmt"
	"sort"
)

func groupAnagrams(strs []string) [][]string {
	mappings := make(map[string][]string)

	for _, key := range strs {
		original := key

		// Sort the characters in the string
		keyEncoding := []byte(key)
		sort.Slice(keyEncoding, func(i, j int) bool { return keyEncoding[i] < keyEncoding[j] })
		sortedKey := string(keyEncoding)

		// And map the sorted key to a sequnece of strings that contain those keys
		mappings[sortedKey] = append(mappings[sortedKey], original)
	}

	groups := make([][]string, 0, len(mappings))

	for _, value := range mappings {
		groups = append(groups, value)
	}

	return groups
}

func main() {
	fmt.Println(groupAnagrams([]string{"eat", "tea", "tan", "ate", "nat", "bat"}))
}

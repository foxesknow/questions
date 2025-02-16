enum Q14 {
    class Solution {
        func longestCommonPrefix(_ strs: [String]) -> String {
            if strs.count == 1 {return strs[0]}

            var values = strs;
            values.sort();

            let first = values[0];
            let last = values.last!;
            let range = min(first.count, last.count)
            let index = first.startIndex

            for i in 0..<range {
                if first[first.index(index, offsetBy: i)] != last[last.index(index, offsetBy: i)] {
                    return String(first.prefix(i))
                }
            }

            return first
        }
    }
}
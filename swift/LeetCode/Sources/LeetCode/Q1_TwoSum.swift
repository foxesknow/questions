enum Q1 {
    class Solution {
        func twoSum(_ nums: [Int], _ target: Int) -> [Int] {
            var cache = [Int:Int]()
            
            for (index, number) in nums.enumerated() {
                if let value = cache[target - number] {
                    return [value, index]
                }

                cache[number] = index
            }

            return []
        }
    }
}

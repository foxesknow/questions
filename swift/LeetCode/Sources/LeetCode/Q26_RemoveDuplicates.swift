enum Q26 {
    class Solution {
        func removeDuplicates(_ nums: inout [Int]) -> Int {
            var front = 1
            
            for i in 1..<nums.count {
                if nums[front - 1] < nums[i] {
                    nums[front] = nums[i]
                    front += 1
                }
            }

            return front
        }
    }
}

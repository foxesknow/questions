enum Q27 {
    class Solution {
        func removeElement(_ nums: inout [Int], _ val: Int) -> Int {
            var count = 0
            var front = 0

            for (i, n) in nums.enumerated() {
                if n != val {
                    let x = nums[front]
                    let y = nums[i]
                    nums[i] = x;
                    nums[front] = y

                    front += 1
                    count += 1
                }
            }

            return count
        }
    }
}

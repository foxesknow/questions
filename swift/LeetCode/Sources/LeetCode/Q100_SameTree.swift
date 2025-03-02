enum Q100 {
    class Solution {
        func isSameTree(_ p: TreeNode?, _ q: TreeNode?) -> Bool {
           var stack = [(p, q)]

            while !stack.isEmpty {
                let (left, right) = stack.removeLast()

                if left == nil && right == nil {
                    continue
                }

                if left == nil || right == nil {
                    return false
                }

                if left!.val != right!.val {
                    return false;
                }

                stack.append((left?.left, right?.left))
                stack.append((left?.right, right?.right))
            }

            return true
        }
    }
}

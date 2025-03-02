import Testing

@testable import LeetCode

class Q100_SameTreeTests {
    @Test
    public func example1() {
        let s = Q100.Solution()

        let p = TreeNode(1, TreeNode(2), TreeNode(3))
        let q = TreeNode(1, TreeNode(2), TreeNode(3))
        
        #expect(s.isSameTree(p, q) == true)
    }

    @Test
    public func example2() {
        let s = Q100.Solution()

        let p = TreeNode(1, TreeNode(2), nil)
        let q = TreeNode(1, nil, TreeNode(2))
        
        #expect(s.isSameTree(p, q) == false)
    }

    @Test
    public func example3() {
        let s = Q100.Solution()

        let p = TreeNode(1, TreeNode(2), TreeNode(1))
        let q = TreeNode(1, TreeNode(1), TreeNode(2))
        
        #expect(s.isSameTree(p, q) == false)
    }
}
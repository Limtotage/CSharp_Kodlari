/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution_21 {
    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> SmallStack = new  Stack<TreeNode>();
        TreeNode current = root;
        int count=0;
        while(SmallStack.Count>0||current!=null){
            while(current!=null){
                SmallStack.Push(current);
                current=current.left;
            }
            current=SmallStack.Pop();
            count++;
            if(count==k) return current.val;
            current=current.right;
        }
        return 999;
    }
}

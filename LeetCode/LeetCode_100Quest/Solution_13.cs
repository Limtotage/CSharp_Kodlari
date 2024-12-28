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
public class Solution_13 {
    public List<int> result;
    public IList<int> InorderTraversal(TreeNode root) {
        result= new List<int>();
        test(root);
        return result;
    }
    public void test(TreeNode node){
        if(node==null) return;
        if(node.left!=null) test(node.left);
        result.Add(node.val);
        if(node.right!=null) test(node.right);
    }
}

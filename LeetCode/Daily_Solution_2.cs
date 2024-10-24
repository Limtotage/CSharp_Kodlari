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
public class Daily_Solution_2 {
    public bool FlipEquiv(TreeNode root1, TreeNode root2) {
        if(root1 == null && root2==null) return true;
        if(root1 == null || root2==null) return false;
        if (root1.val!=root2.val) return false;
        bool noswprslt= FlipEquiv(root1.left,root2.left)&&FlipEquiv(root1.right,root2.right);
        bool swprslt = FlipEquiv(root1.right,root2.left)&&FlipEquiv(root1.left,root2.right);
        return noswprslt || swprslt;
    }
}

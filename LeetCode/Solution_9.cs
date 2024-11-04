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
public class Solution_9 {
    public void DFS(TreeNode root, int targetSum,List<int> yol,IList<IList<int>> rslt) {
        if (root == null) return; 
        yol.Add(root.val);
        if (root.left == null && root.right == null&&targetSum == root.val) {
            rslt.Add(new List<int>(yol));
        }
        DFS(root.left, targetSum-root.val,yol,rslt);
        DFS(root.right, targetSum-root.val,yol,rslt);
        yol.RemoveAt(yol.Count - 1);
    }
    public IList<IList<int>> PathSum(TreeNode root, int targetSum) {
        IList<IList<int>> rslt = new List<IList<int>>();
        List<int> yol = new List<int>();
        DFS(root, targetSum, yol, rslt);
        return rslt;
    }
}

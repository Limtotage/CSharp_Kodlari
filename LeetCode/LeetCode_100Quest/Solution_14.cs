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
public class Solution_14 {
    public List<int> Vals;
    public bool IsValidBST(TreeNode root) {
        Vals=new List<int>();
        Test(root);
        int[] values = Vals.ToArray();
        int prev =values[0];
        for(int i=1;i<values.Length;i++){
            if(prev>=values[i]) return false;
            prev=values[i];
        }
        return true;
    }
    public void Test(TreeNode Node){
        if (Node == null) return;
        if (Node.left != null) Test(Node.left); 
        Vals.Add(Node.val); 
        if (Node.right != null) Test(Node.right);
    }
}

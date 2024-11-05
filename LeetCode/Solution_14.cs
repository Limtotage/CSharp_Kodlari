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
    public IList<int> RightSideView(TreeNode root) {
        List<int> cvp = new List<int>();
        if(root==null) return cvp;
        Queue<TreeNode> nodelar= new Queue<TreeNode>();
        nodelar.Enqueue(root);
        while(nodelar.Count>0){
            int levelSize = nodelar.Count;
            for(int i=0;i<levelSize;i++){
                TreeNode simdiki = nodelar.Dequeue();
                if(simdiki.left!=null)nodelar.Enqueue(simdiki.left);
                if(simdiki.right!=null)nodelar.Enqueue(simdiki.right);
                if(i==levelSize-1) cvp.Add(simdiki.val);
            }
        }
        return cvp;
    }
}

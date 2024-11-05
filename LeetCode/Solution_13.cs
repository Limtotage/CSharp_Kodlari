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
    public int MaxLevelSum(TreeNode root) {
        Queue<TreeNode> nodelar= new Queue<TreeNode>();
        nodelar.Enqueue(root);
        int levelCount = 0,max=int.MinValue,cvp=1;
        while(nodelar.Count>0){
            int levelSize = nodelar.Count;
            int top=0;
            levelCount++;
            for(int i=0;i<levelSize;i++){
                TreeNode simdiki = nodelar.Dequeue();
                if(simdiki.left!=null)nodelar.Enqueue(simdiki.left);
                if(simdiki.right!=null)nodelar.Enqueue(simdiki.right);
                top+=simdiki.val;
            }
            if(top>max){
                max=top;
                cvp=levelCount;
            }
        }
        return cvp;
    }
}

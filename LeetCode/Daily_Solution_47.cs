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
public class Daily_Solution_47 {
    public IList<int> LargestValues(TreeNode root) {
        if(root==null) return new List<int>();
        Queue<TreeNode> queue = new Queue<TreeNode>();
        List<int> result = new List<int>();
        queue.Enqueue(root);
        while (queue.Count > 0) {
            int max= int.MinValue;
            int size = queue.Count;
            for (int i = 0; i < size; i++) {
                TreeNode currentNode = queue.Dequeue();
                max= Math.Max(max,currentNode.val);
                if(currentNode.left!=null)queue.Enqueue(currentNode.left);
                if(currentNode.right!=null)queue.Enqueue(currentNode.right);
            }
            result.Add(max);
        }
        return result;
    }
}

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
public class Solution_16 {
    public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> Levels = new List<IList<int>>();
        if (root == null) return Levels;
        Queue<TreeNode> Hostage = new Queue<TreeNode>();
        Hostage.Enqueue(root);
        while(Hostage.Count>0){
            List<int> level = new List<int>();
            int size=Hostage.Count;
            for(int i=0;i<size;i++){
                TreeNode temp = Hostage.Dequeue();
                level.Add(temp.val);
                if(temp.left!=null) Hostage.Enqueue(temp.left);
                if(temp.right!=null) Hostage.Enqueue(temp.right);
            }
            Levels.Add(new List<int>(level));
        }
        return Levels;
    }
}

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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if (root == null) return null;
        if (key < root.val) root.left = DeleteNode(root.left, key);
        else if (key > root.val) root.right = DeleteNode(root.right, key);
        if(root.val==key) {
            if (root.left == null) return root.right;
            else if (root.right == null) return root.left;
            root.val=BFS(root.right);
            root.right = DeleteNode(root.right, root.val);
        }
        return root;
    }
    public int BFS(TreeNode node){
        int minValue = node.val;
        while (node.left != null) {
            node = node.left;
            minValue = node.val;
        }
        return minValue;
    }
}

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
public class Solution_11 {
    public int LongestZigZag(TreeNode root) {
        if(root==null) return 0;
        if(root.left==null&&root.right==null) return 0;
        int Dfs(TreeNode node, int max,int zigzag,string dir)
        {
            if(node.left == null&&node.right == null) return zigzag;
            if(node.left != null&&dir=="right"){
                zigzag++;
                Console.WriteLine(dir+""+zigzag);
                max= Math.Max(max,Dfs(node.left, max,zigzag,"left"));
            } 
            if(node.left != null&&dir=="left"){
                Console.WriteLine(dir+""+zigzag);
                max= Math.Max(max,Dfs(node.left, max,0,"left"));
            } 
            if(node.right != null&&dir=="left"){
                zigzag++;
                Console.WriteLine(dir+""+zigzag);
                max= Math.Max(max,Dfs(node.right, max,zigzag,"right"));
            } 
            if(node.right != null&&dir=="right"){
                Console.WriteLine(dir+""+zigzag);
                max= Math.Max(max,Dfs(node.right, max,0,"right"));
            } 
            return Math.Max(zigzag,max);
        }
        int x=0,y=0;
        if(root.left!=null) x= Dfs(root.left,0,0,"left");
        if(root.right!=null) y= Dfs(root.right,0,0,"right");
        return Math.Max(x,y)+1;
    }
}

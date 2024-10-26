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
public class Daily_Solution_4 {
    private List<int> FindLongestPath(TreeNode root) {
        if (root == null) return new List<int>();
        
        List<int> leftPath = FindLongestPath(root.left);
        List<int> rightPath = FindLongestPath(root.right);

        if (leftPath.Count > rightPath.Count) {
            leftPath.Insert(0, root.val);
            return leftPath;
        } else {
            rightPath.Insert(0, root.val);
            return rightPath;
        }
    }
    public int BFS(TreeNode BFS,int queries){
        if (BFS == null) return 0;
        Queue<TreeNode> BFque = new Queue<TreeNode>();
        BFque.Enqueue(BFS);
        int cur =0;
        while(BFque.Count>0){
            int levelSize = BFque.Count;
            for(int i=0;i<levelSize;i++){
                TreeNode temp=BFque.Dequeue();
                if(temp.left!=null&&queries!=temp.left.val){
                    BFque.Enqueue(temp.left);
                }
                if(temp.right!=null&&queries!=temp.right.val){
                    BFque.Enqueue(temp.right);
                }
            }
            cur++;
        }
        return cur-1;
    }
    public int[] TreeQueries(TreeNode root, int[] queries) {
        int[] path= FindLongestPath(root).ToArray();
        int[] result = new int[queries.Length];
        int j=0;
        foreach(int i in queries){
            if(!path.Contains(i)){
                result[j]= path.Length-1;
                j++;
            }
            else{
                result[j]= BFS(root,i);
                j++;
            }
        }
        return result;
    }
}


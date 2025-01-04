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
public class Solution_18 {
    public TreeNode SortedArrayToBST(int[] nums) {
        return IsEasy(nums,0,nums.Length-1);
    }
    public TreeNode IsEasy(int[] nums, int start, int end){
        if(start>end) return null;
        int mid= start+(end-start)/2;
        TreeNode temp = new TreeNode(nums[mid]);
        temp.right=IsEasy(nums,mid+1,end);
        temp.left=IsEasy(nums,start,mid-1);
        return temp;
    }
}

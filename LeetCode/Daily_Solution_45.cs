public class Daily_Solution_45 {
    public TreeNode ReverseOddLevels(TreeNode root) {
        if (root == null) return null;

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);
        int level = 0;

        while (queue.Count > 0) {
            int size = queue.Count;
            List<TreeNode> currentLevelNodes = new List<TreeNode>();

            for (int i = 0; i < size; i++) {
                TreeNode current = queue.Dequeue();
                currentLevelNodes.Add(current);

                if (current.left != null) queue.Enqueue(current.left);
                if (current.right != null) queue.Enqueue(current.right);
            }

            if (level % 2 == 1) {
                int left = 0, right = currentLevelNodes.Count - 1;
                while (left < right) {
                    int temp = currentLevelNodes[left].val;
                    currentLevelNodes[left].val = currentLevelNodes[right].val;
                    currentLevelNodes[right].val = temp;
                    left++;
                    right--;
                }
            }
            level++;
        }

        return root;
    }
}

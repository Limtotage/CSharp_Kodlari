/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution_36 {
    public ListNode SortList(ListNode head) {
        if(head == null) return null;
        var res = new List<int>();
        ListNode temp =head;
        while(temp != null)
        {
            res.Add(temp.val);
            temp = temp.next;
        }
        res.Sort();
        var root = new ListNode(res[0]);
        var curr = root;
        for(int i=1; i<res.Count; i++)
        {
            curr.next = new ListNode(res[i]);
            curr = curr.next;
        }
        return root;
    }
}

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
public class Solution_37 {
    public ListNode SwapPairs(ListNode head) {
        ListNode temp = new ListNode(0,head);
        ListNode prev=temp;
        ListNode curr=head;
        while(curr!=null && curr.next!=null){
            ListNode tmp= curr.next.next;
            ListNode second= curr.next;
            second.next=curr;
            curr.next=tmp;
            prev.next=second;
            prev=curr;
            curr=tmp;
        }
        return temp.next;
    }
}

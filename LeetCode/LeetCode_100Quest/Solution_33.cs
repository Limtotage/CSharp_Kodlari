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
public class Solution_33 {
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int Length =0;
        ListNode curr = head;
        while(curr!=null){
            Length++;
            curr=curr.next;
        }
        int destroy_pos= Length-n-1;
        curr=head;
        for(int i=0;i<destroy_pos;i++) curr=curr.next;
        if(destroy_pos<=-1) return head.next;
        else{
            curr.next=curr.next.next;
            return head;
        }
    }
}

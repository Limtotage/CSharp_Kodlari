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
public class Solution_2 {
    public ListNode OddEvenList(ListNode head) {
        if(head==null||head.next==null) return head;
        ListNode Tek = new ListNode(0);
        ListNode Tek_ptr = Tek;
        ListNode Cift = new ListNode(0);
        ListNode Cift_ptr = Cift;
        int i=0;
        while(head!=null){
            if(i%2==0){
                Tek_ptr.next=head;
                Tek_ptr=head;
            }
            else {
                Cift_ptr.next=head;
                Cift_ptr=head;
            }
            head=head.next;
            i++;
        }
        Cift_ptr.next=null;
        Tek_ptr.next=Cift.next;
        return Tek.next;
    }
}

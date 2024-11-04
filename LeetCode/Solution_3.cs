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
public class Solution_3 {
    public ListNode ReverseList(ListNode head) {
        if (head==null||head.next==null) return head;
        ListNode Cur = head,nops=new ListNode(0);
        ListNode nopsptr=nops;
        Stack<int> nop= new Stack<int>();
        while(Cur.next!=null){
            nop.Push(Cur.val);
            Cur=Cur.next;
        }
        nop.Push(Cur.val);
        while(nop.Count>0){
            nopsptr.next= new ListNode(nop.Pop());
            nopsptr=nopsptr.next;
        }
        return nops.next;
    }
}

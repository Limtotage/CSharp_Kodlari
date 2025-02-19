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
public class Solution_35 {
    public bool IsPalindrome(ListNode head) {
        var word = new StringBuilder();
        ListNode temp=head;
        while(temp!=null){
            word.Append(""+temp.val);
            temp=temp.next;
        }
        int n=word.Length;
        int i=0;
        while (i < n / 2) {
            if (word[i] != word[n - 1 - i]) {
                return false;
            }
            i++;
        }
        return true;
    }
}

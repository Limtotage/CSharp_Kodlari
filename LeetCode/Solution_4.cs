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
public class Solution_4 {
    public int PairSum(ListNode head) {
        ListNode Cur = head;
        List<int> numbers = new List<int>();
        while(Cur!=null){
            numbers.Add(Cur.val);
            Cur=Cur.next;
        }
        int[] numbersArray = numbers.ToArray();
        int i=0, j=numbersArray.Length-1;
        int max=0;
        while(i<=j){
            int temp =numbersArray[i]+numbersArray[j];
            if(max<temp) max=temp;
            i++;
            j--;
        }
        return max;
    }
}

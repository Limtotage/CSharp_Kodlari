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
public class Solution_34 {
    public ListNode MergeKLists(ListNode[] lists) {
        ListNode result=new ListNode();
        if(lists.Length==0||(lists.Length==1 && lists[0]==null)) return null;
        var temp=new List<int>();
        for(int i=0;i<lists.Length;i++){
            ListNode lisy= lists[i];
            while(lisy!=null){
                temp.Add(lisy.val);
                lisy=lisy.next;
            }
        }
        temp.Sort();
        ListNode Head=result;
        foreach(int val in temp){
            var Curr = new ListNode(val);
            result.next  = Curr;
            result=result.next;
        }
        Console.WriteLine(string.Join(", ", temp));
        return Head.next;
    }
}

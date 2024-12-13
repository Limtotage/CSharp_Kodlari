public class Solution_44 {
    public IList<IList<string>> SuggestedProducts(string[] products, string searchWord) {
        
        var result = new List<IList<string>>();
        var trie = new Trie();

        foreach (var product in products.OrderBy(it => it))
        {
            trie.Insert(product);
        }
        string prefix="";
        foreach (var ch in searchWord)
        {
            prefix+=ch;
            result.Add(trie.GetSuggestions(prefix));
        }

        return result;
    }

}
public class Trie_Node{
    public Dictionary<char,Trie_Node> Children { get; private set; }
    public bool eodw  { get; set; }
    public string Word { get; set; }
    public Trie_Node(){
        Children = new Dictionary<char, Trie_Node>();
        eodw  = false;
        Word=null;
    }
}
public class Trie {
    private readonly Trie_Node root;
    public Trie() {
        root = new Trie_Node();
    }
    
    public void Insert(string word) {
        Trie_Node node = root;
        foreach(char ch in word){
            if(!node.Children.ContainsKey(ch)){
                node.Children[ch]=new Trie_Node();
            }
            node = node.Children[ch];
        }
        node.eodw  = true;
        node.Word = word;
    }
    
    public IList<string> GetSuggestions(string prefix){
        var node = root;
        var suggestions = new List<string>();
        foreach(char ch in prefix){
            if(!node.Children.ContainsKey(ch)){
                return suggestions;
            }
            node = node.Children[ch];
        }
        DFS(node, suggestions);
        return suggestions.Take(3).ToList();
    }
    private void DFS(Trie_Node node, List<string> suggestions) {
        if(suggestions.Count==3) return;
        if(node.eodw) suggestions.Add(node.Word);
        foreach(var child in node.Children.Values){
            DFS(child, suggestions);
        }
    }
    
}

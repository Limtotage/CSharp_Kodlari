public class Trie_Node{
    public Dictionary<char,Trie_Node> Children { get; private set; }
    public bool eodw  { get; set; }
    public Trie_Node(){
        Children = new Dictionary<char, Trie_Node>();
        eodw  = false;
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
    }
    
    public bool Search(string word) {
        Trie_Node node = root;
        foreach(char ch in word){
            if(!node.Children.ContainsKey(ch)){
                return false;
            }
            else node = node.Children[ch];
        }
        return node.eodw ;
    }
    
    public bool StartsWith(string prefix) {
        Trie_Node node = root;
        foreach(char ch in prefix){
            if(!node.Children.ContainsKey(ch)){
                return false;
            }
            else node = node.Children[ch];
        }
        return true;
    }
}

/**
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */

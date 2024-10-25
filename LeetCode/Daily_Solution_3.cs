public class Daily_Solution_3 {
    public IList<string> RemoveSubfolders(string[] folder) {
        HashSet<string> Dizinler = new HashSet<string>(folder);
        List<string> cevap = new List<string>();
        foreach(string f in folder){
            bool alt_dizin = false;
            string temp = f;
            while(temp !=""){
                int index = temp.LastIndexOf('/');
                if (index == -1 ) break;
                temp = temp.Substring(0,index);
                if(Dizinler.Contains(temp)){
                    alt_dizin = true;
                    break;
                }
            }
            if(!alt_dizin) cevap.Add(f);
        }
        return cevap;
    }
}

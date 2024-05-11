public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        
        int keyIndex = 0;

        switch(ruleKey) {
            case "type": keyIndex = 0; break;
            case "color": keyIndex = 1; break;
            case "name": keyIndex = 2; break;
            default: keyIndex = 3; break;
        }

        int count = 0;

        foreach(var item in items) {
            if(item[keyIndex] == ruleValue) {
                count++;
            }
        }

        return count;
    }
}
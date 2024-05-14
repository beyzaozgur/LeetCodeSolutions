public class Solution {
    // Solution 1 - Built-in replace function
    public string DefangIPaddr1(string address) {
        return address.Replace(".", "[.]");
    }

    // Solution 2
    public string DefangIPaddr2(string address) {
        string modified = "";
        for(int i = 0; i < address.Length; i++) {
            if(address[i] == '.') {
                modified += "[.]";
            }
            else {
                modified += address[i];
            }
        }
        return modified;
    }
}
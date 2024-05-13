public class Solution {
    // Solution 1 - Bubble Sort - good memory
    public string[] SortPeople(string[] names, int[] heights) {
    
        for(int i = 0; i < names.Length; i++) {
            for(int j = 0; j < names.Length-1; j++) {
                if(heights[j+1] > heights[j]) {

                    int height = heights[j];
                    heights[j] = heights[j+1];
                    heights[j+1] = height;

                    string name = names[j+1];
                    names[j+1] = names[j];
                    names[j] = name;
                    
                }
            }
        }

        return names;
    }

    // Solution 2 - Built-in LINQ funcions - good runtime
    public string[] SortPeople(string[] names, int[] heights) {
    
        Dictionary<int,string> dictionary = new Dictionary<int,string>();

        for(int i = 0; i < names.Length; i++) {
            dictionary.Add(heights[i], names[i]);
        }

        return dictionary.OrderByDescending(k => k.Key).Select(v =>v.Value).ToArray();
    }
}
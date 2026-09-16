using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        string[] small;
        string[] Large;
        int smallcount = 0;
        int largecount = 0;
        
        for(int i=0; i<s.Length; i++){
            if(s[i] >= 'a' && s[i] <= 'z'){
                smallcount++;
            }
            else if(s[i] >= 'A' && s[i] <= 'Z'){
                largecount++;
            }
        }
        small = new string[smallcount];
        Large = new string[largecount];
        int smallindex = 0;
        int largeindex = 0;
        for(int i=0; i<s.Length; i++){
            if(s[i] >= 'a' && s[i] <= 'z'){
                small[smallindex++] = s[i].ToString();
            }
            else if(s[i] >= 'A' && s[i] <= 'Z'){
                Large[largeindex++] = s[i].ToString();
            }
        }
        
        Array.Sort(small);
        Array.Sort(Large);
        
        for(int i=small.Length-1; i>=0; i--){
            answer += small[i];
        }
        
        for(int i=Large.Length-1; i>=0; i--){
            answer += Large[i];
        }
        return answer;
    }
}
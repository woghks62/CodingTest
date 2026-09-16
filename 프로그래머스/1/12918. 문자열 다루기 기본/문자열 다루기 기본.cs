public class Solution {
    public bool solution(string s) {
        bool answer = false;
        int count = 0;
        
        if(s.Length == 4 || s.Length == 6){
            for(int i=0; i<s.Length; i++){
                if(s[i] >= '0' && s[i] <= '9'){
                    count++;
                }
            }
            if(count == s.Length) return true;
        }
        
        
        return answer;
    }
}
public class Solution {
    public string solution(string s) {
        string answer = "";
        int index = 0;
        
        for(int i=0; i<s.Length; i++){
            if(s[i] == ' '){
                index = 0;
                answer += s[i];
            }
            else{
                if(index % 2 == 0) answer += (s[i] >= 'A' && s[i] <= 'Z') ? s[i] : (char)(s[i] - 32);
                else answer += (s[i] >= 'a' && s[i] <= 'z') ? s[i] : (char)(s[i] + 32);
                index++;
            }
        }
        
        return answer;
    }
}
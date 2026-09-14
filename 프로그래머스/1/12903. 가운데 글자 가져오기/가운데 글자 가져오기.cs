public class Solution {
    public string solution(string s) {
        string answer = "";
        
        if(s.Length % 2 == 1){
            answer = s[s.Length/2].ToString();;
        }
        else{
            for(int i=s.Length/2-1; i<=s.Length/2; i++){
                answer += s[i];
            }
        }
        
        return answer;
    }
}
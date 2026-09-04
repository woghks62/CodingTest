using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        string str = "";
        for(int i=1; i<=n; i++){
            answer++;
            str = answer.ToString(); 
            while(answer%3 == 0 || str.Contains("3")){
                answer++;
                str = answer.ToString(); 
            }

        }
        
        return answer;
    }
}
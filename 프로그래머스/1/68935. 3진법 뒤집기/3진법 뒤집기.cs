using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;  
        string str = "";
        int num = 1;
        
        while(n>0){
            str += (n%3).ToString();
            n/=3;
        }
        
        for(int i= str.Length-1; i>=0; i--){
            answer += int.Parse(str[i].ToString()) * num;
            num*=3;
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int i, int j, int k) {
        int answer = 0;
        string str= "";
        
        for(int c = i; c<=j; c++){
            str+= c.ToString();
        }
        
        for(int a=0; a<str.Length; a++){
            if(str[a]-'0' == k){
                answer++;
            }
        }
        
        return answer;
    }
}
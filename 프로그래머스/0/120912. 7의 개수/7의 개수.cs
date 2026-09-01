using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        
        string str = "";
        
        for(int i=0; i<array.Length; i++){
            str += array[i].ToString();
        }
        
        for(int i=0; i<str.Length; i++){
            if(str[i] == '7'){
                answer++;
            }
        }
        
        return answer;
    }
}
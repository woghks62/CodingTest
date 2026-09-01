using System;

public class Solution {
    public string solution(string cipher, int code) {
        string answer = "";
        int n = 1;
        
        for(int i=0; i<cipher.Length; i++){
            //if( i+1 % 4 == 0)
            if(i%code == code -1 ){
                answer += cipher[i];
                n++;
            }
            
        }
        return answer;
    }
}
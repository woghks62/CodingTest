using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        for(int i=0; i<my_string.Length; i++){
            if(my_string[i] >= 'a' && my_string[i] <= 'z'){
                answer += (char)((int)my_string[i] - 32);
            }
            else{
                answer += (char)((int)my_string[i] + 32);
            }
        }
        
        return answer;
    }
}
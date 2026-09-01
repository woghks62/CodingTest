using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
      
        for(int i=0; i<my_string.Length; i++){
            bool a = false;
            for(int j=0; j<answer.Length; j++){
                if(my_string[i] == answer[j]){
                    a = true;
                    break;
                }
            }
            if(a == true){
                continue;
            }
            answer += my_string[i];
        }
        
        return answer;
    }
}
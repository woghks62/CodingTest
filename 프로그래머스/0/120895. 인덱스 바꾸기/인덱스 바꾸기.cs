using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        
        for(int i=0; i<my_string.Length; i++){
            if(i == num1){
                continue;
            }
            else if(i == num2){
                continue;
            }
            else{
                answer += my_string[i]; 
            }
        }
        
        
        char str1 = my_string[num2];
        char str2 = my_string[num1];
        
        answer = answer.Insert(num1, str1.ToString());
        answer = answer.Insert(num2, str2.ToString());
        
        return answer;
    }
}
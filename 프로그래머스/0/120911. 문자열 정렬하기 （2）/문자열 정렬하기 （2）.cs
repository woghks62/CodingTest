using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        
        for(int i=0; i<my_string.Length; i++){
            if(my_string[i] >= 'A' && my_string[i] <= 'Z'){
                answer += (char)(my_string[i] + 32);
            }
            else{
                answer += my_string[i];
            }
        }
        
        string[] str = new string[answer.Length];
        
        for(int i=0; i<str.Length; i++){
            str[i] = answer[i].ToString();
        }
        
        Array.Sort(str);
        
        string answer2 = "";
        
        for(int i=0; i<str.Length; i++){
            answer2+=str[i];
        }
        
        
        
        
        return answer2;
    }
}
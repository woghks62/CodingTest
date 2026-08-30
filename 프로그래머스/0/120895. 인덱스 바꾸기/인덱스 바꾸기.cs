using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
        string answer = "";
        string str1 = my_string[num1].ToString();
        string str2 = my_string[num2].ToString();
        
        for(int i=0; i<my_string.Length; i++){
            if(i == num1){
                answer+=str2;
            }
            else if(i == num2){
                answer+=str1;
            }
            else{
                answer += my_string[i];
            }
        }
        
        return answer;
    }
}
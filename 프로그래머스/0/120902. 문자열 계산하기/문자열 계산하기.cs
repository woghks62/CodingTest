using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int middle = 0;
        int count = 0;
        
        string[] str = my_string.Split(' ');
     
        for(int i=0; i<str.Length; i++){
            if(str[i] == "+"){
                if(count == 0){
                    middle = int.Parse(str[i-1]) + int.Parse(str[i+1]);
                }
                
                else if(count >= 1){
                    middle += int.Parse(str[i+1]);
                }
                count++;
            }
            
            else if(str[i] == "-"){
                if(count == 0){
                    middle = int.Parse(str[i-1]) - int.Parse(str[i+1]);
                }
                
                else if(count >= 1){
                    middle -= int.Parse(str[i+1]);
                }
                count++;
            }
            
        }
        answer = middle;
            
        
        return answer;
    }
}
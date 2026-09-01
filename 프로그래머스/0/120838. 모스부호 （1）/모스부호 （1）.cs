using System;

public class Solution {
    public string solution(string letter) {
        
        string[] morse = {
    ".-","-...","-.-.","-..",".","..-.","--.","....","..",".---",
    "-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-",
    "..-","...-",".--","-..-","-.--","--.."
};
        char ch;
        string answer = "";
        
        // ".... . .-.. .-.. ---"
        /*
        "...." 
        "." 
        ".-.." 
        ".-.." 
        "---"
        */
        string[] str = letter.Split(' ');
        
        for(int i=0; i<str.Length; i++){
            for(int j=0; j<morse.Length; j++){
                if(str[i] == morse[j]){
                    ch = (char)(j+97);
                    answer += ch;
                }
            }
            
        }
        
        // str2는 길이가 5
        //string[] str2 = new string[str.Length];  
        
        return answer;
    }
}
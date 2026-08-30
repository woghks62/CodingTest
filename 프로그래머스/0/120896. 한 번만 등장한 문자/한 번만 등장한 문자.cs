using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        char[] ch = s.ToCharArray();
        
        int count = 0;
        
        for(int i=0; i<s.Length; i++){
            count = 0;
            for(int j=0; j<s.Length; j++){
                if(s[i] == s[j]){
                    count++;
                }
            }
            if(count == 1){
                answer += s[i];
            }
        }
        
        char ch2 = ' ';
        
        char[] charArray = answer.ToCharArray();
        
        
        for(int i=0; i<charArray.Length; i++){
            for(int j=0; j<charArray.Length; j++){
                if(charArray[i] < charArray[j]){
                    ch2 = charArray[i];
                    charArray[i] = charArray[j];
                    charArray[j] = ch2;
                }
            }
        }
        
        string answer2= "";
        
        for(int i=0; i<charArray.Length; i++){
            answer2 += charArray[i];
        }
        
        return answer2;
    }
}
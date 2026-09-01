using System;

public class Solution {
    public int solution(string str1, string str2) {
        int answer = 2;
        int count = 0;
        int a = 0;
        
        for(int i=0; i<str1.Length; i++){   //str1 길이만큼 반복
            if(str1[i] == str2[0]){         // 만약 str1[i] 가 str2[0]과 같으면
                                            // 시작 문자가 같다
                a = i;
                int str2len = str2.Length;
                count = 0;
                
                for(int j=0; j<str2.Length; j++){
                    
                    if(a >= str1.Length){
                        break;
                    }
                    
                    if(str1[a] == str2[j]){
                        count++;
                        a++;
                    }
                    else{
                        break;
                    }
                    
                }
                
                if(count == str2len){
                    answer = 1;
                }
                
            }
        }

        
        return answer;
        
    }
}
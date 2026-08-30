using System;

public class Solution {
    public long solution(string numbers) {
        long answer = 0;
        
        for(int i=0; i<numbers.Length; i++){
            if(numbers[i] == 'z'){
                answer*=10;
                answer+=0;
                i+=3;
            }
            else if(numbers[i] == 'o'){
                answer*=10;
                answer+=1;
                i+=2;
            }
            else if(numbers[i] == 't'){
                if(numbers[i+1] == 'w'){
                    answer*=10;
                    answer+=2;
                    i+=2;
                }
                else if(numbers[i+1] == 'h'){
                    answer*=10;
                    answer+=3;
                    i+=4;
                }
            }
            else if(numbers[i] == 'f'){
                if(numbers[i+1] == 'o'){
                    answer*=10;
                    answer+=4;
                    i+=3;
                }
                else if(numbers[i+1] == 'i'){
                    answer*=10;
                    answer+=5;
                    i+=3;
                }
            }
            
            else if(numbers[i] == 's'){
                if(numbers[i+1] == 'i'){
                    answer*=10;
                    answer+=6;
                    i+=2;
                }
                else if(numbers[i+1] == 'e'){
                    answer*=10;
                    answer+=7;
                    i+=4;
                }
            }
            
            else if(numbers[i] == 'e'){
                answer*=10;
                answer+=8;
                i+=4;
            }
            
            else if(numbers[i] == 'n'){
                answer*=10;
                answer+=9;
                i+=3;
            }
            
        }
        
        return answer;
    }
}
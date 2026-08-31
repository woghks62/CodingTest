using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = -1;
//         int count = 0;      // num 자리수
        
//         while(num > 0){
//             count++;
//             num = num / 10;
//         }
//         int a=0;
        
        string str = num.ToString();
        
        for(int i=0; i<str.Length; i++){
            if(str[i] - '0' == k){
                answer = i+1;
                break;
            }
        }
        
        return answer;
    }
}
using System;

public class Solution {
    public int solution(int a, int b) {
        int answer = 1;
        
        
        // 기약분수로 바꾸기
        for(int i=2; i<=a; i++){
            if(a % i == 0 && b % i == 0){
                a/=i;
                b/=i;
            }
        }
        
        // 기약분수 분모가 소인수인지
        for(int j=2; j<=b; j++){
            if(b%j == 0){
                if(j == 2 || j==5){
                    while(b%j == 0){
                        b/=j;
                    }
                    continue;
                }
                answer=2;
            }
        }
        
        
        return answer;
    }
}
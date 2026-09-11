using System;

public class Solution {
    public int solution(int a, int b, int n) {
        // 받는 콜라수
        int answer = 0;
        
        // 현재 콜라 수
        int cola = 0;
                
        // 처음 빈병으로 받은 콜라수
        answer = (n/a)*b;
        
        // 현재 콜라 수
        cola = (n/a)*b + n%a;
        
        // 현재 콜라수가 a보다 크거나 같으면
        while(cola >= a){
            // 받는 콜라수에 b를 더하고
            answer+=b;
            // 현재 콜라수에서 a를 빼고 받은 콜라수를 더한다
            cola = cola - a + b;
        }
        
        return answer;
    }
}
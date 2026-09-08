using System;

public class Solution {
    public int solution(int[] common) {
        int answer = 0;
        int a = common[1] - common[0];
        int b = common[2] - common[1];
        
        if(a == b){     // 등차 수열
            answer = common[common.Length-1] + a;
        }
        else{
            a = common[1] / common[0];
            answer = common[common.Length-1] * a;
        }
        
        return answer;
    }
}
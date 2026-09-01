using System;

public class Solution {
    public int solution(int[] box, int n) {
        
        int a,b,c;
        
        a = box[0] / n;
        b = box[1] / n;
        c = box[2] / n;
        
        
        int answer = 0;
        
        answer = a*b*c;
        return answer;
    }
}
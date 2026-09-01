using System;

public class Solution {
    public int solution(int num1, int num2) {
        double num3 = num1 / (double)num2;
        double num4 = 1000*num3;
        int answer = (int)num4;
        return answer;
    }
}
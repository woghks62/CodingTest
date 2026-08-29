using System;

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 0;
        int min = 999;
        
        for(int i=0; i<array.Length; i++){
            if(min > Math.Abs(array[i] - n)){
                min = Math.Abs(array[i] - n);
                answer = array[i];
            }
            else if(min == Math.Abs(array[i] - n)){
                if(answer > array[i]){
                    answer = array[i];
                }
            }
        }
        
        return answer;
    }
}
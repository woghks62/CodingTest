using System;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int count = 0;
        
        for(int i=0; i<arr.Length; i++){
            if(arr[i] % divisor == 0){
                count++;
            }
        }
        if (count == 0) count++;
        
        int[] answer = new int[count];
        if (count == 1) {
            answer[0] = -1;
        }
        
        int num = 0;
        
        for(int i=0; i<arr.Length; i++){
            if(arr[i] % divisor == 0){
                answer[num++] = arr[i];
            }
        }
        
        
        
        Array.Sort(answer);
        
        return answer;
    }
}
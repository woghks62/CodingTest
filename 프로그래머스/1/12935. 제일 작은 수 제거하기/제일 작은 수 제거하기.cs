using System;

public class Solution {
    public int[] solution(int[] arr) {
        int len = arr.Length-1;
        int[] answer;
        if(len == 0){
            answer = new int[1] {-1};
            return answer;
        }
        
        answer = new int[len];
        
        int min = Int32.MaxValue;
        
        for(int i=0; i<arr.Length; i++){
            if(min > arr[i]){
                min = arr[i];
            }
        }
        
        int num = 0;
        for(int i=0; i<arr.Length; i++){
            if(arr[i] != min){
                answer[num++] = arr[i];
            }
        }
        
        
        return answer;
    }
}
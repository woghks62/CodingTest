using System;

public class Solution {
    public int[] solution(int[] arr) {
        int min = Int32.MaxValue;
        int num = 0;
        int[] answer;
        answer = new int[arr.Length-1];
        
        if(arr.Length-1 == 0){
            answer = new int[1] {-1};
            return answer;
        }
 
        for(int i=0; i<arr.Length; i++){
            if(min > arr[i]){
                min = arr[i];
            }
        }
        
        for(int i=0; i<arr.Length; i++){
            if(arr[i] != min){
                answer[num++] = arr[i];
            }
        }
        
        
        return answer;
    }
}
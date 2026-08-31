using System;

public class Solution {
    public int[] solution(int[] array) {
        
        
        int max = -1;
        int maxindex = -1;
            
        for(int i=0; i<array.Length; i++){
            if(array[i]> max){
                max = array[i];
                maxindex = i;
            }
        }
        
        int[] answer = new int[2]{max, maxindex};
        
        return answer;
    }
}
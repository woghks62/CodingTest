using System;

public class Solution {
    public int[] solution(int n) {
        
        int arrSize;
        
        if(n%2 !=0){
            arrSize = (n/2)+1;
        }
        else{
            arrSize = n/2;
        }
        
        int[] answer = new int[arrSize];
        int index = 0;
        
        for(int i=1; i<=n; i++){
            if(i % 2 != 0){
                answer[index] = i;
                index++;
            }
        }
        
        return answer;
    }
}
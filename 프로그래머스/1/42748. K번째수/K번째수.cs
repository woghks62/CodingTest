using System;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        int[] mid;
        int count = 0;

        for(int i=0; i<commands.GetLength(0); i++){
            count = 0;
            mid = new int[commands[i,1] - commands[i,0] +1];
            for(int j=commands[i,0]; j<=commands[i,1]; j++){
                mid[count++] = array[j-1];
            }
            Array.Sort(mid);            
            
            answer[i] = mid[commands[i,2]-1];
        }
        
        return answer;
    }
}
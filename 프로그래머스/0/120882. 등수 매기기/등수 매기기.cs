using System;

public class Solution {
    public int[] solution(int[,] score) {
        int[] answer = new int[score.GetLength(0)];
        float[] avg = new float[score.GetLength(0)];
        
        for(int i=0; i<score.GetLength(0); i++){
            avg[i] = (score[i,0] + score[i,1]) / (float)2;
        }
        
        
        
        int count = 1;
        
        
        for(int i=0; i<avg.Length; i++){
            count = 1;
            for(int j=0; j<avg.Length; j++){
                if(i == j) continue;
                
                if(avg[i] < avg[j]){
                    count++;
                }
                
            }
            answer[i] = count;
        }
        
        
        
        return answer;
    }
}
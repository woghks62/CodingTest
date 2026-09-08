using System;

public class Solution {
    public int solution(int[,] lines) {
        int answer = 0;
        int[] arr = new int[201];
        
        for(int i=0; i<3; i++){
            for(int j = lines[i,0]+100; j<lines[i,1]+100; j++){
                arr[j] +=1;
            }
        }
        
        for(int i=0; i<201; i++){
            if(arr[i] >=2){
                answer++;
            }
        }
            
        return answer;
    }
}
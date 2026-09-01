using System;

public class Solution {
    public int[] solution(int n) {
        int count = 0;
        
        for(int i = 2; i<=n; i++){
            if(n%i == 0){
                count++;
            }
        }
        
        int[] answer = new int[count];
        
        int arr = 0;
        
        for(int i = 2; i<=n; i++){
            if(n%i == 0){
                answer[arr] = i;
                arr++;
            }
        }

        
        
        
        int count2 = 0;
        int count3 = 0;     //소수개수
        for(int i=0; i<answer.Length; i++){
            count2 = 0;
            for(int j=2; j<= answer[i]; j++){
                if(answer[i] % j == 0){
                    count2++;
                }
            }
            if(count2 == 1){
                count3++;
            }
        }
        
        int[] answer2 = new int[count3];
        
        int arr2=0;
        
        for(int i=0; i<answer.Length; i++){
            count2 = 0;
            for(int j=2; j<= answer[i]; j++){
                if(answer[i] % j == 0){
                    count2++;
                }
            }
            if(count2 == 1){
                answer2[arr2] = answer[i];
                arr2++;
            }
        }
        
        
        
        
        
        
        return answer2;
    }
}
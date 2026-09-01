using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 0;
        int temp = 0;
        
        
        for(int i=0; i<numbers.Length-1; i++){
            for(int j=0; j<numbers.Length-1-i; j++){
                if(numbers[j] > numbers[j+1]){
                    temp = numbers[j];
                    numbers[j] = numbers[j+1];
                    numbers[j+1] = temp;
                }
            }
        }
        
        answer = numbers[numbers.Length-1] * numbers[numbers.Length-2];
        
        return answer;
    }
}
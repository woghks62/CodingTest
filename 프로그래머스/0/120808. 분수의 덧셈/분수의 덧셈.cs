using System;

public class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int max = 1;
        
        int sumnumer = denom1 * denom2;
        int sumdenom = numer1 * denom2 + numer2 * denom1;
        
        for(int i=1; i<=sumdenom; i++){
            if(sumnumer % i == 0 && sumdenom % i == 0){
                max = i;
            }
        }
        sumdenom/=max;
        sumnumer/=max;
            
        
        int[] answer = new int[] {sumdenom,sumnumer};
        return answer;
    }
}
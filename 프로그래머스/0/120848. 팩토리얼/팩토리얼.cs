using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        int sum = 1;
        
        for(int i=1; i<=n; i++){
            sum*=i;
            
            if(sum == n){
                return i;
            }
            else if(sum > n){
                return i-1;
            }
            
        }
        
        return 0;
    }
}
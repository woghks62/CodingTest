using System;

public class Solution {
    public int solution(int n, int k) {
        int total=12000 * n + k*2000;
        
        if(n>=10){
            int service =n/10;
            total = 12000 * n + (k-service) * 2000;
        }
                    
        return total;
    }
}
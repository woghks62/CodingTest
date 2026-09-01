using System;

public class Solution {
    public int solution(string message) {
        
        int count = 0;
        
        for(int i=0; i<message.Length; i++){
            count++;
        }
        
        return count*2;
    }
}
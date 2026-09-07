using System;

public class Solution {
    public int solution(int[,] dots) {
        int answer = 0;
        
        int xmin = 256;
        int xmax = -256;
        
        for(int i=0; i<4; i++){
            if(dots[i,0] < xmin){
                xmin = dots[i,0];
            }
            if(dots[i,0] > xmax){
                xmax = dots[i,0];
            }
        }
        
        int ymin = 256;
        int ymax = -256;
        
        for(int i=0; i<4; i++){
            if(dots[i,1] < ymin){
                ymin = dots[i,1];
            }
            if(dots[i,1] > ymax){
                ymax = dots[i,1];
            }
        }
        
        answer = (xmax-xmin) * (ymax-ymin);
        
        
        return answer;
    }
}
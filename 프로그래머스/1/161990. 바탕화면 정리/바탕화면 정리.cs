using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int rowmin = Int32.MaxValue; int rowmax = Int32.MinValue;
        int colmin = Int32.MaxValue; int colmax = Int32.MinValue;
        
        for(int i=0; i<wallpaper.Length; i++){
            for(int j=0; j<wallpaper[i].Length; j++){
                if(wallpaper[i][j] == '#'){
                    if(i <= rowmin) rowmin = i;
                    if(j <= colmin) colmin = j;
                    if(i >= rowmax) rowmax = i+1;
                    if(j >= colmax) colmax = j+1;
                    
                }
            }
        }
        
        int[] answer = new int[4] {rowmin, colmin, rowmax, colmax};
        
        return answer;
    }
}
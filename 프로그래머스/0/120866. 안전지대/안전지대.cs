using System;

public class Solution {
    public int solution(int[,] board) {
        int answer = 0;
        int num = board.GetLength(0);
        
         int[,] a = new int[num+2,num+2];
        
        for(int i=0; i<num; i++){
            for(int j=0; j<num; j++){
                if(board[i,j] == 1){    
                    int x = i + 1;
                    int y = j + 1;
                    a[x-1,y-1] = 1;
                    a[x-1,y] = 1;
                    a[x-1,y+1] = 1;
                    a[x,y-1] = 1;
                    a[x,y] = 1;
                    a[x,y+1] = 1;
                    a[x+1,y-1] = 1;
                    a[x+1,y] = 1;
                    a[x+1,y+1] = 1;
                    
                }
            }
        }
        
        for(int i=1; i<=num; i++){
            for(int j=1; j<=num; j++){
                if(a[i,j] == 0){
                    answer++;
                }
            }
        }
            
        
        
        return answer;
    }
}
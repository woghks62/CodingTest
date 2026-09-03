using System;

public class Solution {
    public int[] solution(string[] keyinput, int[] board) {
        int[] answer = new int[2] {0,0};
        
        int row = board[0]/2;
        int column = board[1]/2;
        
        for(int i=0; i<keyinput.Length; i++){
            if(keyinput[i] == "left"){
                if(answer[0] <= -row) continue;
                
                answer[0]--;
            }
            else if(keyinput[i] == "right"){
                if(answer[0] >= row) continue;
                
                answer[0]++;
            }
            else if(keyinput[i] == "down"){
                if(answer[1] <= -column) continue;
                
                answer[1]--;
            }
            else if(keyinput[i] == "up"){
                if(answer[1] >= column) continue;
                
                answer[1]++;
            }
            
            
            
            
            
            
            
//             if(answer[0] < row && answer[0] > -row){
//                 if(keyinput[i] == "left"){
//                     answer[0]--;
//                 }
//                 else if(keyinput[i] == "right"){
//                     answer[0]++;
//                 }
//             }
            
//             if(answer[1] < column && answer[1] > -column){
//                 if(keyinput[i] == "down"){
//                     answer[1]--;
//                 }
//                 else if(keyinput[i] == "up"){
//                     answer[1]++;
//                 }
//             }
        }
        
        
        return answer;
    }
}
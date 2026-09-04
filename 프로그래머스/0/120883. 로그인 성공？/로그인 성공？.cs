using System;

public class Solution {
    public string solution(string[] id_pw, string[,] db) {
        string answer = "fail";
        
        for(int i=0; i<db.Length/2; i++){
            if(id_pw[0] == db[i,0]){
                if(id_pw[1] == db[i,1]){
                    return "login";
                }
                else{
                    answer = "wrong pw";
                }
            }
        }
        
        return answer;
    }
}
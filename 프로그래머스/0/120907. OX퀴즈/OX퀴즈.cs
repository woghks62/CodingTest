using System;

public class Solution {
    public string[] solution(string[] quiz) {        
        
        string str1 = "";
        
        // str2 = ["3 - 4 = -3","5 + 6 = 11"]
        // string[] str2 = new string[quiz.Length];
        // for(int i = 0; i<quiz.Length; i++){
        //     str2[i]+=quiz[i];
        // }

        
        
        for(int i = 0; i<quiz.Length; i++){
            str1+=quiz[i];
            str1 += ' ';
        }
        
        // 지금 str에 -3과 5
        // 결과값과 시작값이 붙어서 저장되는중
        string[] str  = str1.Split(' ');
        int count = 0;
        int num = 0;
        
        for(int i=0; i<str.Length; i++){
            if(str[i] == "+" || str[i] == "-"){
                count++;
            }
        }
        
        string[] answer = new string[count];
        
        for(int i=0; i<str.Length; i++){
            if(str[i] == "+"){
                if(int.Parse(str[i-1]) + int.Parse(str[i+1]) == int.Parse(str[i+3])){
                    answer[num++] = "O";
                }
                else{
                    answer[num++] = "X";
                }
            }
            else if(str[i] == "-"){
                if(int.Parse(str[i-1]) - int.Parse(str[i+1]) == int.Parse(str[i+3])){
                    answer[num++] = "O";
                }
                else{
                    answer[num++] = "X";
                }
            }
        }
        
        return answer;
    }
}
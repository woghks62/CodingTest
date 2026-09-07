using System;

public class Solution {
    public string solution(string polynomial) {
        string answer = "";
        
        string[] str = polynomial.Split(" + ");
        // 지금 빈 공간 _까지 들어감
        bool[] bol = new bool[str.Length];
        
        for(int i=0; i<str.Length; i++){
            bol[i] = str[i].Contains("x");
        }
        // 
        // true false true
        // true true true
        
        string str2 = "";
        int xnum = 0;
        int num = 0;
        
        for(int i=0; i<str.Length; i++){    // 3
            
            if(bol[i] == true){
                if(str[i].Length == 1){
                    xnum+=1;
                    // num에 잘 더해지고 있음
                }
                else{
                    str2 = "";
                    for(int j=0; j<(str[i].Length-1); j++){
                        str2 += str[i][j];
                    }
                    xnum += int.Parse(str2);
                }
            }
            else{
                num += int.Parse(str[i]);
            }
            
        }
        
        if(xnum > 0){
            if(xnum == 1){
                answer = "x";
            }
            else{
                answer = xnum.ToString() + "x";
            }
            if(num > 0){
                answer += " + ";
                answer += num.ToString();
            }
        }
        else{
            answer = num.ToString();
        }
        
        
        
        
        
        return answer;
    }
}
using System;

public class Solution {
    public string solution(string bin1, string bin2) {
        string answer = "";
        
        int num1 = int.Parse(bin1);
        int num2 = int.Parse(bin2);
        
        int sum1 = 0;
        int sum2 = 0;
        
        int num3 = 1;
        
        for(int i=0; i<bin1.Length; i++){
            sum1 += (num1 % 2) * num3;
            num1/=10;
            num3*=2;
        }
        
        num3 = 1;
        for(int i=0; i<bin2.Length; i++){
            sum2 += (num2 % 2) * num3;
            num2/=10;
            num3*=2;
        }
        
        int sum3 = sum1 + sum2;
        
        if(sum3 == 0){
            return "0";
        }
        
        while(sum3>0){
            answer += (sum3%2).ToString();
            sum3/=2;
        }        
        
        string answer2 = "";
        
        for(int i=answer.Length-1; i>=0; i--){
            answer2 += answer[i];
        }
        
        
        return answer2;
    }
}
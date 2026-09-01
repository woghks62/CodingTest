using System;

public class Solution {
    public string solution(int age) {
        string answer = "";
        string change = "";
        
        int num1, num2, num3;
        
        num1 = age%10;   // 1의자리
        num2 = (age%100)/10; // 10의 자리
        num3 = (age%1000)/100; // 100의 자리
        
        
        if(age == 1000){
            change = "baaa";
            return change;
        }
        else if(age >= 100){
            change = num3.ToString() + num2.ToString() + num1.ToString();
        }
        else if(age >= 10){
            change = num2.ToString() + num1.ToString();
        }
        else if(age < 10){
            change = num1.ToString();
        }
        
        for(int i=0; i<change.Length; i++){
            answer += (char)(change[i] + 49);
        }
        
        
        return answer;
    }
}
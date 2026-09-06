using System;

public class Solution {
    public string[] solution(string my_str, int n) {
        int len = 0;
        if(my_str.Length % n == 0){
            len = my_str.Length / n;
        }
        else{
            len = my_str.Length / n + 1;
        }
        string[] answer = new string[len];
        
        int a = 0;
        for(int i = 0; i<my_str.Length; i++){
            answer[a] += my_str[i];
            if(answer[a].Length == n){
                a++;
            }
        }
        return answer;
    }
}
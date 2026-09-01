using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;

        string[] str = new string[200];
                
        str = s.Split(' ');
        
        string[] str2 = new string[str.Length];
        
        str2 = s.Split(' ');
        int sum = 0;
        
        for(int i=0; i<str2.Length; i++){
            if(str2[i] != "Z"){
                sum += Int32.Parse(str2[i]);
            }
            else{
                sum -= Int32.Parse(str2[i-1]);
            }
        }
        
        //int num = Int32.Parse(str2[0]);
        
        
                
        return sum;
    }
}
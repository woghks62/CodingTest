using System;

public class Solution {
    public int solution(int a, int b) {
        
        string s = a.ToString() + b.ToString();
        
        int si = Convert.ToInt32(s);
        
        int sum;
        sum = 2*a*b;
        
        if(si>sum){
            return si;
        }
        else if(si == sum){
            return si;
        }
        else{
            return sum;
        }

    }
}
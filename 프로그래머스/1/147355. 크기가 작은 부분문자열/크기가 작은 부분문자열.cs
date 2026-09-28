using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        int tlen = t.Length;
        int plen = p.Length;
        int len = tlen - plen +1;

        string[] str = new string[len];

        for(int i=0; i<len; i++){
            for(int j=i; j<i+plen; j++){
                str[i] += t[j];
            }
        }
        
        for(int i=0; i<str.Length; i++){
            if(long.Parse(str[i]) <= long.Parse(p)){
                answer++;
            }
        }
        
        return answer;
    }
}
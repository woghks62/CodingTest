using System;

public class Solution {
    public int solution(int order) {
        int count = 0;

        string str = order.ToString();
        for(int i=0; i<str.Length; i++){
            if(str[i]-'0' == 3 || str[i]-'0' == 6 || str[i]-'0' == 9){
                count++;
            }
        }
        return count;
    }
}
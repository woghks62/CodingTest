using System;

public class Solution {
    public int solution(string before, string after) {
        int answer = 0;
        int count = 0;
        
        int[] arr = new int [26];
        foreach(char c in before){
            if (c >= 'a' && c <= 'z') {
                arr[c - 'a']++;
            }
        }
        
        int[] arr2 = new int [26];
        foreach(char ch in after){
            if (ch >= 'a' && ch <= 'z') {
                arr2[ch - 'a']++;
            }
        }
        
        for(int i=0; i<26; i++){
            if(arr[i] == arr2[i]){
                count++;
            }
        }
        
        if(count == 26){
            answer =1;
        }

        
        return answer;
    }
}
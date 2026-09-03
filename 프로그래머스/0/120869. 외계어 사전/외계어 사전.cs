using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
        int answer = 2;
        int count = 0;
        
        int[] arr = new int [26];
        
        for(int i=0; i<spell.Length; i++){
            if(spell[i][0] >= 'a' && spell[i][0] <= 'z'){
                arr[spell[i][0] - 'a']++;
            }
        }
        
        // foreach(char c in spell){
        //     if (c >= 'a' && c <= 'z') {
        //         arr[c - 'a']++;
        //     }
        // }
        
        for(int i=0; i<dic.Length; i++){
            int[] arr2 = new int [26];
            count = 0;
            foreach(char ch in dic[i]){
                if (ch >= 'a' && ch <= 'z') {
                    arr2[ch - 'a']++;
                }
            }
            
            for(int j=0; j<26; j++){
                if(arr[j] == arr2[j]){
                count++;
                }
            }
            if(count == 26){
                return 1;
            }
        }
        
        
        return answer;
    }
}
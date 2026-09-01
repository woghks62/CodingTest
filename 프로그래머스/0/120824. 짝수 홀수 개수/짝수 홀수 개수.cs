using System;

public class Solution {
    public int[] solution(int[] num_list) {
        int hol=0;
        int jjak=0;
        
        for(int i =0; i<num_list.Length; i++){
            if(num_list[i] % 2 == 0){
                jjak++;
            }
        }
        hol = num_list.Length - jjak;
        
        int[] answer = new int[] {jjak,hol};
        return answer;
    }
}
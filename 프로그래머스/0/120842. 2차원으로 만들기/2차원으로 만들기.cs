using System;

public class Solution {
    public int[,] solution(int[] num_list, int n) {
        int[,] answer = new int[num_list.Length/n,n];
        int k=0;
        
        // for(int i=0; i<num_list.Length; i++){
        //     for(int j=0; j<n; j++){
        //         answer[i,j] = num_list[i]
        //     }
        // }

        for(int i=0; i<num_list.Length/n; i++){
            for(int j=0; j<n; j++){
                answer[i,j] = num_list[k++];
            }
        }
        
        return answer;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> list = new();
        
        for(int i=0; i<numbers.Length-1; i++){
            for(int j=i+1; j<numbers.Length; j++){
                list.Add(numbers[i] + numbers[j]);
            }
        }
        
        List<int> list2 = list.Distinct().ToList();
        
        int[] answer = new int[list2.Count];
        
        list2.Sort();
        
        for(int i=0; i<answer.Length; i++){
            answer[i] = list2[i];
        }
        
        return answer;
    }
}
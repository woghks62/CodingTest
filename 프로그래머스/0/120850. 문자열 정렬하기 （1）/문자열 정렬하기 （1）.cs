using System;

public class Solution {
    public int[] solution(string my_string) {
        //int[] answer = new int[];
        int count = 0;
        
        
        for(int i=0; i<my_string.Length; i++){
            if(my_string[i] >= '0' && my_string[i]<='9'){
                count++;
            }
        }
        
        int [] arr = new int[count];
        int count2 = 0;
        
        for(int i=0; i<my_string.Length; i++){
            if(my_string[i] >= '0' && my_string[i]<='9'){
                arr[count2] = my_string[i] - '0';
                count2++;
            }
        }
        int temp;
        
        for(int i=0; i<arr.Length; i++){
            for(int j=i+1; j<arr.Length; j++){
                if(arr[i] > arr[j]){
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
        }
        
        return arr;
    }
}
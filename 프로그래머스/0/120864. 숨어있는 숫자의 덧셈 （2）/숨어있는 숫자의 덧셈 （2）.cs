using System;

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        int middle = 0;
        
        for(int i=0; i<my_string.Length; i++){
            middle = 0;
            while(my_string[i] >= '0' && my_string[i] <= '9'){
                middle*=10;
                middle += int.Parse(my_string[i].ToString());
                
                
                if(i < my_string.Length-1){
                    i++;
                }
                else if(i == my_string.Length-1){
                    break;
                }
            }
            answer+=middle;
        }
        
        return answer;
    }
}
public class Solution {
    public bool solution(int x) {
        bool answer = false;
        
        int num = 0;
        int x1 = x;
        while(x1>0){
            num += x1 % 10;
            x1/=10;
        }
        
        if(x % num == 0) {
            answer = true;
        }
        return answer;
    }
}
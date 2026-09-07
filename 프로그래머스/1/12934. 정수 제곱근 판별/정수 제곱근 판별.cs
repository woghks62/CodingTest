public class Solution {
    public long solution(long n) {
        long answer = -1;
        long a = -1;
        if(n == 1) return 4;
        for(int i=1; i<n/2; i++){
            if(n/i==i && n%i==0){
                a=i;
                break;
            }
        }
        
        if(a!=-1){
            answer = (a+1) * (a+1);
        }
        
        
        
        return answer;
    }
}
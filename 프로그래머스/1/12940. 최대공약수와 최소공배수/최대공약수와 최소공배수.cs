public class Solution {
    public int[] solution(int n, int m) {
        int max = 1;        // 최대공약수
        int min = 1;        // 최소공배수
        int num = n>=m?m:n;
        
        for(int i=1; i<=num; i++){
            if(n % i == 0 && m % i == 0){
                max = i;
            }
        }
        
        min = n*m/max;
        int[] answer = new int[2]{max,min};
        
        return answer;
    }
}
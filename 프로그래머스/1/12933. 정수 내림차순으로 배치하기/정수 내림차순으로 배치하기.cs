public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        string str = n.ToString();
        int[] num = new int[str.Length];
        int tmp;
        
        for(int i=0; i<str.Length; i++){
            num[i] = int.Parse(str[i].ToString());
        }
        
        for(int i=0; i<num.Length-1; i++){
            for(int j=i+1; j<num.Length; j++){
                if(num[i] < num[j]){
                    tmp = num[i];
                    num[i] = num[j];
                    num[j] = tmp;
                }
            }
        }
        
        string str2 = "";
        
        for(int i=0; i<num.Length; i++){
            str2 += num[i].ToString();
        }
        
        return long.Parse(str2);
    }
}
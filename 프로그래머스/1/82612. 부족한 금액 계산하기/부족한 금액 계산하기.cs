using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long num = 0;
                
        for(int i=1; i<=count; i++){
            num+= price*i;
        }
        
        if(num > money) return num-money;
        
        return 0;
        
        
    }
}
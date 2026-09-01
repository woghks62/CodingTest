using System;

public class Solution {
    public int solution(int hp) {
        
        int a = 0;
        int b = 0;
        int c = 0;
        int resthpb;
        
        // 27이면
        a = hp / 5;   // a = 장군 개미 마릿수
        int resthpa = hp % 5;   // 남은 hp
        
        //b = resthpa / 3;        // b = 1
        if(resthpa % 3 == 0){       //만약 남은hp가 3의 배수면
            resthpb = 0;            //남은hp는 0
            b = resthpa / 3;        //
        }
        else{                       // 만약 남은hp가 3의 배수가 아니면
            resthpb = resthpa % 3;        // 남은hp = 
            b = resthpa / 3;        // b = 병졍개미 마릿수
        }
        
        
        c = resthpb / 1;
        
        int answer = a+b+c;
        return answer;
    }
}
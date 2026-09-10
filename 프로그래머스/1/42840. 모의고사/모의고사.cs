using System;

public class Solution {
    public int[] solution(int[] answers) {
        string str = "";
        for(int i=0; i<answers.Length; i++){
            str+=answers[i];
        }
        // 주어진 정답 문자열로 바꿈
        
        string str1 = "12345";          // 수포자 1
        string str2 = "21232425";       // 수포자 2
        string str3 = "3311224455";     // 수포자 3
        int cnt1 = 0;
        int cnt2 = 0;
        int cnt3 = 0;
        int count = 0;
        int max = -1;
        
        // 수포자 1
        // 5번 반복
        for(int i=0; i<answers.Length; i++){
            if(count == 5){
                count = 0;
            }
            if(answers[i] == int.Parse(str1[count++].ToString())){
                cnt1++;
            }
        }
        if(cnt1 > max){
            max = cnt1;
        }
        
        // 수포자 2
        // 5번 반복
        count = 0;
        for(int i=0; i<answers.Length; i++){
            if(count == 8){
                count = 0;
            }
            if(answers[i] == int.Parse(str2[count++].ToString())){
                cnt2++;
            }
        }
        if(cnt2 > max){
            max = cnt2;
        }
        
        // 수포자 3
        // 5번 반복
        count = 0;
        for(int i=0; i<answers.Length; i++){
            if(count == 10){
                count = 0;
            }
            if(answers[i] == int.Parse(str3[count++].ToString())){
                cnt3++;
            }
        }
        if(cnt3 > max){
            max = cnt3;
        }
        
        int maxcnt = 0;
        if(max == cnt1) maxcnt++;
        if(max == cnt2) maxcnt++;
        if(max == cnt3) maxcnt++;

        int[] answer = new int[maxcnt];
        
        int a = 0;
        if(max == cnt1){
            answer[a++] = 1;
        }
        if(max == cnt2){
            answer[a++] = 2;
        }
        if(max == cnt3){
            answer[a++] = 3;
        }
        
        return answer;
    }
}
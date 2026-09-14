public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        
        switch(a)
        {
            case 1 :
                if(b%7 == 1) answer = "FRI";
                if(b%7 == 2) answer = "SAT";
                if(b%7 == 3) answer = "SUN";
                if(b%7 == 4) answer = "MON";
                if(b%7 == 5) answer = "TUE";
                if(b%7 == 6) answer = "WED";
                if(b%7 == 0) answer = "THU";
                break;
            case 2 :
                if(b%7 == 1) answer = "MON";
                if(b%7 == 2) answer = "TUE";
                if(b%7 == 3) answer = "WED";
                if(b%7 == 4) answer = "THU";
                if(b%7 == 5) answer = "FRI";
                if(b%7 == 6) answer = "SAT";
                if(b%7 == 0) answer = "SUN";
                break;
            case 3 :
                if(b%7 == 1) answer = "TUE";
                if(b%7 == 2) answer = "WED";
                if(b%7 == 3) answer = "THU";
                if(b%7 == 4) answer = "FRI";
                if(b%7 == 5) answer = "SAT";
                if(b%7 == 6) answer = "SUN";
                if(b%7 == 0) answer = "MON";
                break;
            case 4 :
                if(b%7 == 1) answer = "FRI";
                if(b%7 == 2) answer = "SAT";
                if(b%7 == 3) answer = "SUN";
                if(b%7 == 4) answer = "MON";
                if(b%7 == 5) answer = "TUE";
                if(b%7 == 6) answer = "WED";
                if(b%7 == 0) answer = "THU";
                break;
            case 5 :
                if(b%7 == 1) answer = "SUN";
                if(b%7 == 2) answer = "MON";
                if(b%7 == 3) answer = "TUE";
                if(b%7 == 4) answer = "WED";
                if(b%7 == 5) answer = "THU";
                if(b%7 == 6) answer = "FRI";
                if(b%7 == 0) answer = "SAT";
                break;
            case 6 :
                if(b%7 == 1) answer = "WED";
                if(b%7 == 2) answer = "THU";
                if(b%7 == 3) answer = "FRI";
                if(b%7 == 4) answer = "SAT";
                if(b%7 == 5) answer = "SUN";
                if(b%7 == 6) answer = "MON";
                if(b%7 == 0) answer = "TUE";
                break;
            case 7 :
                if(b%7 == 1) answer = "FRI";
                if(b%7 == 2) answer = "SAT";
                if(b%7 == 3) answer = "SUN";
                if(b%7 == 4) answer = "MON";
                if(b%7 == 5) answer = "TUE";
                if(b%7 == 6) answer = "WED";
                if(b%7 == 0) answer = "THU";
                break;
            case 8 :
                if(b%7 == 1) answer = "MON";
                if(b%7 == 2) answer = "TUE";
                if(b%7 == 3) answer = "WED";
                if(b%7 == 4) answer = "THU";
                if(b%7 == 5) answer = "FRI";
                if(b%7 == 6) answer = "SAT";
                if(b%7 == 0) answer = "SUN";
                break;
            case 9 :
                if(b%7 == 1) answer = "THU";
                if(b%7 == 2) answer = "FRI";
                if(b%7 == 3) answer = "SAT";
                if(b%7 == 4) answer = "SUN";
                if(b%7 == 5) answer = "MON";
                if(b%7 == 6) answer = "TUE";
                if(b%7 == 0) answer = "WED";
                break;
            case 10 :
                if(b%7 == 1) answer = "SAT";
                if(b%7 == 2) answer = "SUN";
                if(b%7 == 3) answer = "MON";
                if(b%7 == 4) answer = "TUE";
                if(b%7 == 5) answer = "WED";
                if(b%7 == 6) answer = "THU";
                if(b%7 == 0) answer = "FRI";
                break;
            case 11 :
                if(b%7 == 1) answer = "TUE";
                if(b%7 == 2) answer = "WED";
                if(b%7 == 3) answer = "THU";
                if(b%7 == 4) answer = "FRI";
                if(b%7 == 5) answer = "SAT";
                if(b%7 == 6) answer = "SUN";
                if(b%7 == 0) answer = "MON";
                break;
            case 12 :
                if(b%7 == 1) answer = "THU";
                if(b%7 == 2) answer = "FRI";
                if(b%7 == 3) answer = "SAT";
                if(b%7 == 4) answer = "SUN";
                if(b%7 == 5) answer = "MON";
                if(b%7 == 6) answer = "TUE";
                if(b%7 == 0) answer = "WED";
                break;
        }
        
        return answer;
    }
}
using System;
public class Solution
{
    public int[] solution(int numer1, int denom1, int numer2, int denom2)
    {

        // 분자
        int numerator = numer1 * denom2 + numer2 * denom1;

        // 분모
        int denominator = denom1 * denom2;
        
        // 지금 상태는 12, 8 이라고 치면 -> 분수로 12 / 8임
        // 약분을 해줘야함 기약분수로 만들어줘야함 
        // 최대공약수를 구야하 하는데

        // 최대공약수 구하기
        int gcd = MaxCommonNum(numerator, denominator); 

        return new int[] { numerator / gcd, denominator / gcd };


    }

    // 최대 공약수 구하기
    // ex) 12, 8 -> 4가 나옴 ㅇㅇ 
    // 나누는 수가 0이 되어야함
    int MaxCommonNum(int a, int b)
    {
        while (b != 0)
        {
            int temp = a % b;
            a = b;
            b = temp;

        }
        return a;
    }
}
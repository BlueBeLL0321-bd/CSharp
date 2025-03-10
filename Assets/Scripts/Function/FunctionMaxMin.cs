using UnityEngine;

public class FunctionMaxMin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 3, 5를 입력 받아 큰 수를 출력하기
        int max = GetMax(3, 5);
        Debug.Log($"3과 5 중 큰 수는 {max}이다.");

        int min = GetMin(-3, -5);
        Debug.Log($"-3과 -5 중 작은 수는 {min}이다.");
    }

    int GetMax(int x, int y)
    {
        /* int MaxValue;
         if(x > y)
         {
             MaxValue = x;
         }
         else
         {
             MaxValue = y;
         }*/

        // 3항 연산자
        /*int MaxValue = (x > y) ? x : y;
        return MaxValue;*/

        // return (x > y) ? x : y;

        if(x > y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }

    // [2] 매개 변수로 입력 받은 두 개의 정수 중 작은 수를 반환하는 함수
    int GetMin(int x, int y)
    {
        if(x < y)
        {
            return x;
        }
        else
        {
            return y;
        }
    }


}
/*
[1]
1. 매개 변수로 입력 받은 두 개의 정수 중 큰 수를 반환하는 함수
2. 매개 변수로 입력 받은 두 개의 정수 중 작은 수를 반환하는 함수
3. 3, 5를 입력 받아 큰 수 출력하기
4. -3, -5를 입력 받아 작은 수 출력하기
*/
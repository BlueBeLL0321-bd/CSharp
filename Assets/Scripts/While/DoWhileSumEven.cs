using UnityEngine;

// dowhile문을 이용해서 1부터 n(100)까지의 정수 중에서 짝수의 합을 구하는 프로그램 구현
public class DoWhileSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0; // 결과를 저장하는 변수

        // [1] 초기식
        int i = 1;
        do
        {
            // 반복 실행문
            if(i % 2 == 0)
            {
                sum = sum + i;
            }

            // [2] 증감식
            i++;

        } while (i <= n); // [3] 조건식

        Debug.Log($"1부터 {n}까지의 짝수의 합 : {sum}");
    }
}

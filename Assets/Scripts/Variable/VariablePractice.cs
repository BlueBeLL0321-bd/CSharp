using UnityEngine;

public class VariablePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 변수 선언
        int first, second, third;

        // [2] 변수에 값 저장
        first = 10;
        second = 20;
        third = 30;

        // [3] 변수 사용
        Debug.Log(first + ", " + second + ", " + third);
    }
}

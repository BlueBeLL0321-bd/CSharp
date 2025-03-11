using UnityEngine;
using UnityEngine.InputSystem.Layouts;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;

        result = Add(5, 3);
        Debug.Log(result);

        result = Subtract(5, 3);
        Debug.Log(result);

        result = Multiply(5, 3);
        Debug.Log(result);

        result = Divide(5, 3);
        Debug.Log(result);

        result = Reminder(5, 3);
        Debug.Log(result);

        Hi("안녕하세요");

    }
    // 두 개의 정수를 입력 받아 +, -, *, /, %를 계산하여 결과 값을 반환하는 함수 만들기
    int Add(int x, int y)
    {
        return x + y;
    }

    // 화살표 함수, 람다 식, 축약형 함수
    int Subtract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
    int Divide(int x, int y) => x / y;
    int Reminder(int x, int y) => x % y;

    void Hi(string msg) => Debug.Log(msg);
}

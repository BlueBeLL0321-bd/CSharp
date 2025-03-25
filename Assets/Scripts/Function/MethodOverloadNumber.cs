using UnityEngine;

// Method Overload(메서드 오버로드, 함수 다중 정의)
// 동일한 이름의 메서드를 매개 변수를 달리 해서 여러 개 생성하는 것
public class MethodOverloadNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*PrintNumber(1234);
        PrintNumber(1234L);
        PrintNumber(1234F);
        PrintNumber(3.14);*/

        PrintNumber<int>(1234);
        PrintNumber<long>(1234L);
        PrintNumber<float>(1234F);
        PrintNumber<double>(3.14);
    }

   // 제네릭 메서드
   void PrintNumber<T>(T number)
    {
        Debug.Log($"{number}");
    }

    // 매개 변수로 숫자를 입력 받아 출력하는 함수 : PrintNumber
    // int 타입의 정수를 매개 변수로 입력 받아 출력
    void PrintNumber(int number)
    {
        Debug.Log($"Int32 : {number}");
    }

    // long 타입의 정수를 매개 변수로 입력 받아 출력
    void PrintNumber(long number)
    {
        Debug.Log($"Int64 : {number}");
    }

    // float 타입의 실수를 매개 변수로 입력 받아 출력
    void PrintNumber(float number)
    {
        Debug.Log($"실수형 : {number}");
    }

    void PrintNumber(double number)
    {
        Debug.Log($"더블형 : {number}");
    }
}

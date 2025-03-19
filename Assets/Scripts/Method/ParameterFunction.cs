using UnityEngine;

namespace Method
{
    // [3] 반환형 전달 방법 (out int num)
    public class ParameterFunction : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int number = 10;
            Debug.Log($"[1] {number}"); // [1] 10

            PrintNumber(out number);

            Debug.Log($"[3] {number}"); // [3] 20
        }
        // 정수형 out number를 매개 변수로 입력 받아 출력하는 함수
        void PrintNumber(out int number)
        {
            number = 20;
            Debug.Log($"[2] {number}"); // [2] 20
        }
    }
}

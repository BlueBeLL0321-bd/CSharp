using UnityEngine;

namespace Method
{
    // Optional Parameter(선택적 매개 변수) - 사용해도 되고, 생략해도 되고
    public class ParameterOptional : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            Debug.Log(Add(5)); // 5 + 1
            Debug.Log(Add(5, 3)); // 5 + 3
        }

        // 선택적 매개 변수 : b 선언과 동시에 초기 값 설정
        int Add(int a, int b = 1)
        {
            return a + b;
        }
    }
}

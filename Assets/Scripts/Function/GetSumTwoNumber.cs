using Unity.VisualScripting;
using UnityEngine;

public class GetSumTwoNumber : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [2] 두 수의 합을 반환 값을 받아 출력하기
        int result = GetSum(3, 4);
        Debug.Log(result);
    }

    // [1] 두 수의 합을 구하는 함수 만들기 - 매개 변수, 반환 값 이용
    // 매개 변수로 들어온 후 함수의 합을 반환하는 함수 선언

    int GetSum(int x, int y)
    {
        // int sum = x + y;
        // return sum;
        return (x + y);
    }
}

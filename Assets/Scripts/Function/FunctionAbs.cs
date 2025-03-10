using UnityEngine;

// Abs(절댓값)을 구하는 함수 만들기
// -5 => 5, 5 => 5, -99 => 99, 99 => 99
public class FunctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = -21;
        // int abs = Abs(number);
        int abs = Mathf.Abs(number);

        Debug.Log($"{number}의 절댓값은 {abs}");
    }

    // 매개 변수로 들어온 정수의 절댓값을 반환하는 경우
    int Abs(int num)
    {
        /*if(num < 0)
        {
            return -num;
        }
        else
        {
            return num;
        }*/

        return (num < 0) ? -num : num;
    }
}

using UnityEngine;

public class TryCatchDescription : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        try
        {

        }
        catch
        {

        }
        int[] arr = new int[2];
        arr[100] = 10;
    }
}
/*
예외 처리(Exception Handling) : try-catch-finally 문을 사용
예외(오류)
- 문법 오류
- 런타임 오류
- 알고리즘 오류
*/

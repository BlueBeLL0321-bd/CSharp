using UnityEngine;

public class SwapDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = 100;
        int j = 200;
        int temp;

        Debug.Log($"처음 값 i : {i}, j : {j}");

        // 자리 바꾸기
        temp = i; // 임시 변수(temp)에 1 값 저장
        i = j; // i 변수에 j 값 저장
        j = temp; // j 변수에 임시 변수(temp)에 저장되었던 1 값을 저장

        Debug.Log($"나중 값 i : {i}, j : {j}");
    }
}

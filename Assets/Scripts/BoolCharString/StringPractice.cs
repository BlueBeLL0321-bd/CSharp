using UnityEngine;

public class StringPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = 3; // int형 변수 선언하고 3으로 초기화한다
        string result = "홀수";

        Debug.Log($"{number}은(는) {result}입니다");
    }
}

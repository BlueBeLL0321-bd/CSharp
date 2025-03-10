using UnityEngine;

// 가변형 배열 : 배열의 길이가 가변이다.
public class ArrayTwo3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 2차원 배열 선언, 첫 번째 요소수(크기)만 생성
        int[][] intArray = new int[2][];

        // [2] 2차원 배열 (두 번째) 요소수(크기) 각각 따로 생성한다, 초기화
        intArray[0] = new int[3] { 1, 2, 3 };
        intArray[1] = new int[2] { 4, 5 };

        // [3] 2차원 배열 초기화
        Debug.Log($"배열의 길이 : {intArray.Length}"); // 2

        // [4] 2차원 배열 사용하기
        for(int i = 0; i < 2; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Debug.Log(intArray[i][j]);
            }
            Debug.Log("==========");
        }
    }
}

using UnityEngine;

public class ArrayPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // 3행 3열의 2차원 배열을 만들고
        int[,] arr = new int[3, 3];

        // 값 초기화, 행과 열의 인덱스 같으면 1, 행과 열의 인덱스가 틀리면 0
        for (int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                if (i == j) // 행과 열의 인덱스 같으면 1
                {
                    arr[i, j] = 1;
                }
                else // 행과 열의 인덱스 다르면 0
                {
                    arr[i, j] = 0;
                }
            }
        }

        // 출력
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Debug.Log($"arr[{i}, {j}] : {arr[i, j]}");
            }
        }
    }
}

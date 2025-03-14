using System.Linq;
using UnityEngine;

public class MaxPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] data = { -2, -5, -3, -7, -1 };

        // 최댓값을 저장하는 함수
        // max의 초기화 값 : max의 데이터 타입이 가지는 값 중 가장 작은 값
        int max = int.MinValue;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > max)
            {
                max = data[i]; // 두 수 비교 후 큰 값을 max에 저장
            }
        }

        Debug.Log($"최댓값은 {max}");

    }
}

using UnityEngine;
using System.Linq;
using System.Collections.Generic;
public class AveragePractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[] data = { 90, 65, 78, 50, 95 };
        // 평균 점수 = 총점 / 점수의 개수;
        double average = 0;
        int sum = 0;
        int count = 0;

        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] >= 70 & data[i] <= 95)
            {
                sum = sum + data[i];
                count++;
            }
        }
        if(count > 0)
        {
            average = sum / (double)count;
        }

        Debug.Log($"평균 점수 : {average : 0.00}");
    }
}

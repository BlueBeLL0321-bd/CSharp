using UnityEngine;

// 1, 2, 3, 4, 5
// 6, 7, 8, 9, 10
public class WhileCountDown : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] 1���� 5���� 1�� ����
        // �ʱ��
        int i = 1;

        while(i <= 5)
        {
            // �ݺ� ���๮
            Debug.Log($"ī��Ʈ�ٿ� : {i}");

            i++;
        }

        Debug.Log("===========================");

        // [2] 5���� 1���� 1�� ����
        // �ʱ��
        int j = 5;

        while (j >= 1)
        {
            // �ݺ� ���๮
            Debug.Log($"ī��Ʈ�ٿ� : {j}");

            j--;
        }
    }
}

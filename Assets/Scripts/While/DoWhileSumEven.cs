using UnityEngine;

// dowhile���� �̿��ؼ� 1���� n(100)������ ���� �߿��� ¦���� ���� ���ϴ� ���α׷� ����
public class DoWhileSumEven : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 100;
        int sum = 0; // ����� �����ϴ� ����

        // [1] �ʱ��
        int i = 1;
        do
        {
            // �ݺ� ���๮
            if(i % 2 == 0)
            {
                sum = sum + i;
            }

            // [2] ������
            i++;

        } while (i <= n); // [3] ���ǽ�

        Debug.Log($"1���� {n}������ ¦���� �� : {sum}");
    }
}

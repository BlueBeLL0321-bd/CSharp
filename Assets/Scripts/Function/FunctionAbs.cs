using UnityEngine;

// Abs(����)�� ���ϴ� �Լ� �����
// -5 => 5, 5 => 5, -99 => 99, 99 => 99
public class FunctionAbs : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int number = -21;
        // int abs = Abs(number);
        int abs = Mathf.Abs(number);

        Debug.Log($"{number}�� ������ {abs}");
    }

    // �Ű� ������ ���� ������ ������ ��ȯ�ϴ� ���
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

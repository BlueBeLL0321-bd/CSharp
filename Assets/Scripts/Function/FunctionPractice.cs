using UnityEngine;
using UnityEngine.InputSystem.Layouts;

public class FunctionPractice : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int result;

        result = Add(5, 3);
        Debug.Log(result);

        result = Subtract(5, 3);
        Debug.Log(result);

        result = Multiply(5, 3);
        Debug.Log(result);

        result = Divide(5, 3);
        Debug.Log(result);

        result = Reminder(5, 3);
        Debug.Log(result);

        Hi("�ȳ��ϼ���");

    }
    // �� ���� ������ �Է� �޾� +, -, *, /, %�� ����Ͽ� ��� ���� ��ȯ�ϴ� �Լ� �����
    int Add(int x, int y)
    {
        return x + y;
    }

    // ȭ��ǥ �Լ�, ���� ��, ����� �Լ�
    int Subtract(int x, int y) => x - y;
    int Multiply(int x, int y) => x * y;
    int Divide(int x, int y) => x / y;
    int Reminder(int x, int y) => x % y;

    void Hi(string msg) => Debug.Log(msg);
}

using UnityEngine;
using System.Collections;

public class StackDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // [1] Stack Ŭ������ ��ü(�ν��Ͻ�, ��ü) ����
        Stack stack = new Stack();

        // [2] ������ �Է�
        stack.Push("ù ��°");
        stack.Push("�� ��°");
        stack.Push("�� ��°");

        // [3] ������ ���� ����
        Debug.Log(stack.Pop()); // �� ��°
        Debug.Log(stack.Pop()); // �� ��°
        Debug.Log(stack.Pop()); // ù ��°

        

        try
        {
            // ��� �ִ� ���ÿ��� ������ ������
            Debug.Log(stack.Pop()); //
        }
        catch (System.Exception ex)
        {
            Debug.Log($"���� ���� : {ex.Message}");
        }
    }
}
/*
Stack Ŭ���� : LIFO(Last In First Out)
LIFO(Last In First Out) : ���Լ���, �������� ���� �����͸� ���� ���� ������
- �ֹ��� ���ø� �׾� ���� ������ ������ ����, �칰�� ������ ����

Push() : ���� ������ ������ �Է�
Pop() : ���� �������� ������ ���
Peek() : ���� ������ ������ �� ���� ���(�������� �Է���) �������� ���� ��ȯ
Count : ���ÿ� ���� ����Ǿ� �ִ� ������ ��

Overflow : ������ ���� á�� �� �߻�
Underflow : ������ ����� �� �߻�

*/

using UnityEngine;

public class SquareClass : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Square Ŭ������ ����(static) �޼��� GetName() ȣ��
        // ���� �޼��� ȣ�� ��� : Ŭ���� �̸�(Square).�޼��� �̸�(GetName())
        string name = Square.GetName();
        Debug.Log(name);
    }
}

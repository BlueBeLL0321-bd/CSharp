using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class DoubleDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        double pi = 3.141592; // 64��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ
        float f = 3.14f; // 32��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ
        decimal d = 12.34m; // 128��Ʈ �Ǽ��� ������ ���� ���� �� �ʱ�ȭ

        Debug.Log(pi);
        Debug.Log(f);
        Debug.Log(d);

        double doubleMin = double.MinValue;
        double doubleMax = double.MaxValue;

        Debug.Log("double �ּڰ� : " + doubleMin);
        Debug.Log("double �ִ� : " + doubleMax);

        double floatMin = float.MinValue;
        double floatMax = float.MaxValue;

        Debug.Log("float �ּڰ� : " + floatMin);
        Debug.Log("float �ִ� : " + floatMax);
    }
}

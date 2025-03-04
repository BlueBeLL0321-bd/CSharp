using UnityEngine;
using UnityEngine.Rendering;

public class ShortcutOperator : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int x = 3;
        x = x + 2; // x를 2 증가시키는 증가식
        Debug.Log("x : " + x);

        int y = 3;
        // y = y + 2;
        y += 2;
        Debug.Log("y : " + y);
    }
}

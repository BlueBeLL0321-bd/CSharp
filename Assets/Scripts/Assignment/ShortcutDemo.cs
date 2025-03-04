using UnityEngine;

// +=, -=, *=, /=, %=
public class ShortcutDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int a = 3;
        int b = 5;

        // b 변수에 a 변수의 값을 누적하라
        // b = b + a;
        b += a;
        Debug.Log(b); // => 8

        // b 변수에 a 변수의 값을 감산하라
        // b = b - a;
        b -= a;
        Debug.Log(b); // => 5
    }
}

//using 사용할 때
/*
using UnityEngine;

public class UsingDemo : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello World!!!");
    }
    
}
*/



public class UsingDemo : UnityEngine.MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //네임스페이스.클래스.메서드
        UnityEngine.Debug.Log("Hello World!!!");
    }
}
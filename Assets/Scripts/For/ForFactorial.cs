using UnityEngine;

public class ForFactorial : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int n = 10;
        int fact = 1;

        for(int i = 1; i < 11; i++)
        {
            fact = fact * i;
        }

        Debug.Log($"{n}! °ªÀº {fact}");
    }
}
/*
Factorial (n!)
1! = 1
2! = 1 * 2
3! = 1 * 2 * 3
4! = 1 * 2 * 3 * 4
.....
n! = 1 * 2 * 3 * 4 * ... * (n-1) * n
 */

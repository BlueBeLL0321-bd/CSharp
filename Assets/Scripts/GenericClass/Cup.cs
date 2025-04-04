using UnityEngine;

// Generic Class(제네릭 클래스)
// : 형식 매개 변수 T에 지정한 형식으로 클래스와 멤버의 성질이 결정되는 클래스
// Cup<T> 컵 어브 
namespace GenericClass
{
    public class Water { }

    public class Coffee { }

    // 제네릭 클래스 만들기 - 클래스 이름<T>
    public class Cup<T>
    {
        public T Content { get; set; }

        // public Water Content { get; set; }
        // public int Content { get; set; }
        // public string Content { get; set; }

        // 매개 변수로 입력 받은 T 형식 데이터를 출력하라
        public void PrintData(T data)
        {
            Debug.Log($"{data}");
        }
    }
}

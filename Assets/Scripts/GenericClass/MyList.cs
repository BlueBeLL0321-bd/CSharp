using System.Collections;
using UnityEngine;

namespace GenericClass
{
    // 제네릭 클래스 만들기 - 배열 데이터를 저장하는
    public class MyList<T>
    {
        // 필드
        private T[] values;
        private int _length;

        public int Length
        {
            get { return _length; }
        }

        // 생성자 - 매개 변수로 길이를 입력 받아 배열 변수 생성
        public MyList(int length)
        {
            this._length = length;
            values = new T[length];
        }

        // 인덱서
        public T this[int index]
        {
            get { return values[index]; }
            set { values[index] = value; }
        }

        // 반복기
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < _length; i++)
            {
                yield return values[i];
            }
        }
    }
}

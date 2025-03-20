using UnityEngine;

namespace Property
{
    public class PropertyDemo : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1] public 메서드 Get, Set 이용 - 빨간색 자동차
            Car car1 = new Car();
            car1.SetColor("Red");
            Debug.Log(car1.GetColor());

            // [2] public 속성 이용 - 흰색 자동차
            Car car2 = new Car();
            car2.Color = "White";
            Debug.Log(car2.Color);

            // [3] 읽기 전용 속성
            Car car3 = new Car();
            // car3.Maker = "대우 자동차";
            Debug.Log(car3.Maker);

            // [4] 자동 속성, 축약형
            Car myCar = new Car();
            myCar.Name = "붕붕";
            Debug.Log(myCar.Name);
        }
    }
}

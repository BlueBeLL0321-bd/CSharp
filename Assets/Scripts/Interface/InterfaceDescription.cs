using UnityEngine;

namespace Interface
{
    public class InterfaceDescription : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // ICar 인터페이스 인스턴스 생성
            // ICar icar = new ICar();

            // ICar 인터페이스를 상속 받은 Car 클래스의 인스턴스 생성
            Car car = new Car();
            car.Go();
        }
    }
}
/*
Interface(인터페이스)
: 상속 받은 자식 클래스가 특정 멤버를 반드시 구현해야 함을 보증
: 상속 받은 자식 클래스가 특정 멤버를 구현하도록 강제한다
: 인터페이스 이름 작명 시 맨 앞에 있는 문자는 대문자 I를 붙인다

Interface(인터페이스) 형식
public interface (인터페이스 이름)
{
    메서드 이름(); // 메서드 선언 - 구현 부분 생략
    // ....
}

*/

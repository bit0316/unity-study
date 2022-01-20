
using UnityEngine;

public class MyBall : MonoBehaviour
{

    Rigidbody rigid;

    void Start()
    {
        // GetComponent<T> : 자신의 T타입 컴포넌트를 가져옴.
        rigid = GetComponent<Rigidbody>();
    }

    // Rigidbody 관련 코드는 FixedUpdate에 작성!
    void FixedUpdate()
    {
        // 1. 속력 바꾸기
        #region
        // velocity : 현재 이동 속도
        //rigid.velocity = Vector3.forward;
        //rigid.velocity = new Vector3(2, 4, -1);
        #endregion



        // 2. 힘을 가하기
        #region
        
        // AddForce(Vec) : Vec의 방향과 크기로 힘을 줌.
        // ForceMode : 힘을 주는 방식 (가속, 무게 반영)
        // Mass 무게 값이 클수록 움직이는데 더 많은 힘이 필요.
        //rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);

        // Jump
        // AddForce의 힘 방향으로 계속 속도 velocity가 증가
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 5, ForceMode.Impulse);
            Debug.Log(rigid.velocity);
        }

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"),
            0,
            Input.GetAxisRaw("Vertical")
            );

        rigid.AddForce(vec, ForceMode.Impulse);
        
        #endregion



        // 3. 회전력
        #region
        // AddTorque(Vec) : Vec 방향을 축으로 회전력이 생김
        // Vec를 축으로 삼기 때문에 이동 방향에 주의!
        //rigid.AddTorque(Vector3.up);
        #endregion
    }



    // TriggerStay : 콜라이더가 계속 충돌하고 있을 때 호출.
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }





    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}

// 출처 : https://www.youtube.com/watch?v=kYmYCMAiOUk&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=10
// 출처 : https://www.youtube.com/watch?v=salZ7t98xi8&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=12
// 출처 : https://www.youtube.com/watch?v=k4YUJy-otDs&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=13
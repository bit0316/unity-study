
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // 기본 구조
    /*
    void Awake() // 게임 오브젝트 생성할 때, 최초 실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable() // 게임 오브젝트가 활성화 되었을 때
    {
        Debug.Log("플레이어가 로그인했습니다.");
    }

    void Start() // 업데이트 시작 직전, 최초 실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }

    void FixedUpdate() // 물리 연산 업데이트
    {
        Debug.Log("이동~");
    }

    void Update() // 게임 로직 업데이트
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate() // 모든 업데이트 끝난 후
    {
        Debug.Log("경험치 획득");
    }

    void OnDisable() // 게임 오브젝트가 비활성화 되었을 때
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void OnDestroy() // 게임 오브젝트가 삭제될 때
    {
        Debug.Log("플레이어 데이터를 해제하였습니다.");
    }
    */



    // 키보드, 마우스 입력
    /*
    void Update()
    {
        // Input : 게임 내 입력을 관리하는 클래스
        if (Input.anyKeyDown) // anyKeyDown : 아무 입력을 최초로 받을 때 true
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");

        if (Input.anyKey) // anyKey : 아무 입력을 받으면 true
            Debug.Log("플레이어가 아무 키를 누르고 있습니다.");



        // GetKey : 키보드 버튼 입력을 받으면 true
        if (Input.GetKeyDown(KeyCode.Return)) // Return : 엔터
            Debug.Log("아이템을 구입하였습니다.");

        if (Input.GetKey(KeyCode.LeftArrow)) // LeftArrow : 왼쪽 화살표
            Debug.Log("왼쪽으로 이동 중");

        if (Input.GetKeyUp(KeyCode.RightArrow)) // RightArrow : 오른쪽 화살표
            Debug.Log("오른쪽 이동을 멈추었습니다.");



        // GetMouse : 마우스 버튼 입력을 받으면 true
        // (0) : 좌클릭, (1) : 우클릭
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");

        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");



        // GetButton : Input 버튼 입력을 받으면 true
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!");

        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");



        // 오브젝트는 변수 transform을 항상 가지고 있음
        if(Input.GetButton("Horizontal"))
        {
            //Debug.Log("횡 이동 중..." + Input.GetAxis("Horizontal")); // -1.0f ~ 1.0f
            Debug.Log("횡 이동 중..." + Input.GetAxisRaw("Horizontal")); // -1, 0, 1
        }
    }
    */



    // 오브젝트 이동
    /*
    void Start()
    {
        // Transform : 오브젝트 형태에 대한 기본 컴포넌트
        // Translate : 벡터 값을 현재 위치에 더하는 함수
        Vector3 vec = new Vector3(0, 0, 0); // 벡터 값 : 방향과 그에 대한 크기 값
        transform.Translate(vec);

    }
    */



    // 버튼을 통한 위치 이동
    /*
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0); // 벡터 값 : 방향과 그에 대한 크기 값
        transform.Translate(vec);

    }
    */

    

    // Time.deltaTime 사용하는 방법
    /*
    Time.deltaTime : 이전 프레임의 완료까지 걸린 시간 
    deltaTime 값은 프레임이 적으면 크고, 프레임이 많으면 작음
    
    Translate : 벡터에 곱하기
    -> transform.Translate(Vec * Time.deltaTime);

    Vector 함수 : 시간 매개변수에 곱하기
    -> Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
    */ 

}

// 출처 : https://www.youtube.com/watch?v=PyN3JkPTpAI&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=6
// 출처 : https://www.youtube.com/watch?v=wqRwsW03JR4&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=7&t=334s
// 출처 : https://www.youtube.com/watch?v=QGFaA3WYAwk&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=9
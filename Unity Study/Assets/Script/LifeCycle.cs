
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    // �⺻ ����
    /*
    void Awake() // ���� ������Ʈ ������ ��, ���� ����
    {
        Debug.Log("�÷��̾� �����Ͱ� �غ�Ǿ����ϴ�.");
    }

    void OnEnable() // ���� ������Ʈ�� Ȱ��ȭ �Ǿ��� ��
    {
        Debug.Log("�÷��̾ �α����߽��ϴ�.");
    }

    void Start() // ������Ʈ ���� ����, ���� ����
    {
        Debug.Log("��� ��� ì����ϴ�.");
    }

    void FixedUpdate() // ���� ���� ������Ʈ
    {
        Debug.Log("�̵�~");
    }

    void Update() // ���� ���� ������Ʈ
    {
        Debug.Log("���� ���!!");
    }

    void LateUpdate() // ��� ������Ʈ ���� ��
    {
        Debug.Log("����ġ ȹ��");
    }

    void OnDisable() // ���� ������Ʈ�� ��Ȱ��ȭ �Ǿ��� ��
    {
        Debug.Log("�÷��̾ �α׾ƿ��߽��ϴ�.");
    }

    void OnDestroy() // ���� ������Ʈ�� ������ ��
    {
        Debug.Log("�÷��̾� �����͸� �����Ͽ����ϴ�.");
    }
    */



    // Ű����, ���콺 �Է�
    /*
    void Update()
    {
        // Input : ���� �� �Է��� �����ϴ� Ŭ����
        if (Input.anyKeyDown) // anyKeyDown : �ƹ� �Է��� ���ʷ� ���� �� true
            Debug.Log("�÷��̾ �ƹ� Ű�� �������ϴ�.");

        if (Input.anyKey) // anyKey : �ƹ� �Է��� ������ true
            Debug.Log("�÷��̾ �ƹ� Ű�� ������ �ֽ��ϴ�.");



        // GetKey : Ű���� ��ư �Է��� ������ true
        if (Input.GetKeyDown(KeyCode.Return)) // Return : ����
            Debug.Log("�������� �����Ͽ����ϴ�.");

        if (Input.GetKey(KeyCode.LeftArrow)) // LeftArrow : ���� ȭ��ǥ
            Debug.Log("�������� �̵� ��");

        if (Input.GetKeyUp(KeyCode.RightArrow)) // RightArrow : ������ ȭ��ǥ
            Debug.Log("������ �̵��� ���߾����ϴ�.");



        // GetMouse : ���콺 ��ư �Է��� ������ true
        // (0) : ��Ŭ��, (1) : ��Ŭ��
        if (Input.GetMouseButtonDown(0))
            Debug.Log("�̻��� �߻�!");

        if (Input.GetMouseButton(0))
            Debug.Log("�̻��� ������ ��...");

        if (Input.GetMouseButtonUp(0))
            Debug.Log("���� �̻��� �߻�!!");



        // GetButton : Input ��ư �Է��� ������ true
        if (Input.GetButtonDown("Jump"))
            Debug.Log("����!");

        if (Input.GetButton("Jump"))
            Debug.Log("���� ������ ��...");

        if (Input.GetButtonUp("Jump"))
            Debug.Log("���� ����!!");



        // ������Ʈ�� ���� transform�� �׻� ������ ����
        if(Input.GetButton("Horizontal"))
        {
            //Debug.Log("Ⱦ �̵� ��..." + Input.GetAxis("Horizontal")); // -1.0f ~ 1.0f
            Debug.Log("Ⱦ �̵� ��..." + Input.GetAxisRaw("Horizontal")); // -1, 0, 1
        }
    }
    */



    // ������Ʈ �̵�
    /*
    void Start()
    {
        // Transform : ������Ʈ ���¿� ���� �⺻ ������Ʈ
        // Translate : ���� ���� ���� ��ġ�� ���ϴ� �Լ�
        Vector3 vec = new Vector3(0, 0, 0); // ���� �� : ����� �׿� ���� ũ�� ��
        transform.Translate(vec);

    }
    */



    // ��ư�� ���� ��ġ �̵�
    /*
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0); // ���� �� : ����� �׿� ���� ũ�� ��
        transform.Translate(vec);

    }
    */

    

    // Time.deltaTime ����ϴ� ���
    /*
    Time.deltaTime : ���� �������� �Ϸ���� �ɸ� �ð� 
    deltaTime ���� �������� ������ ũ��, �������� ������ ����
    
    Translate : ���Ϳ� ���ϱ�
    -> transform.Translate(Vec * Time.deltaTime);

    Vector �Լ� : �ð� �Ű������� ���ϱ�
    -> Vector3.Lerp(Vec1, Vec2, T * Time.deltaTime);
    */ 

}

// ��ó : https://www.youtube.com/watch?v=PyN3JkPTpAI&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=6
// ��ó : https://www.youtube.com/watch?v=wqRwsW03JR4&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=7&t=334s
// ��ó : https://www.youtube.com/watch?v=QGFaA3WYAwk&list=PLO-mt5Iu5TeZa9dsqMVvXuSfVxwR_2AOz&index=9
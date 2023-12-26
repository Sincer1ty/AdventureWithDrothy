using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed2;
    public GameObject[] hay;//�迭
    [SerializeField] GameObject gameOverText;

    float tl;
    TimeManager time;

    public bool isShield = false;

    public int maxHealth = 3;//�÷��̾� ü��
    public GameObject Shield;
    float hAxis2;
    float vAxis2;
    bool wDown2;//�ȱ� �ִϸ��̼�
    bool jDown;//���� �ִϸ��̼�
    bool isJump;
    bool iDown2;//������ ��ȣ�ۿ�'
    public int shieldnum;
    public int health2 = 3;

    Vector3 moveVec2;

    Rigidbody rigid2;
    Animator anim2;


    GameObject nearObject;
    void Awake()
    {
        gameOverText.SetActive(false);
        rigid2 = GetComponent<Rigidbody>();
        anim2 = GetComponentInChildren<Animator>();

        health2 = maxHealth;
        Shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        GetInput2();
        Move2();
        Turn2();
        Jump();

        if (health2 <= 0)
        {
            //if (!isDie)
            Die();

            return;
        }

    }

    void GetInput2()
    {
        hAxis2 = Input.GetAxisRaw("Horizontal");
        vAxis2 = Input.GetAxisRaw("Vertical");
        //wDown = Input.GetButton("Run");
        jDown = Input.GetButtonDown("Jump");
        iDown2 = Input.GetButtonDown("Interaction");//�����ۻ�ȣ�ۿ�
    }
    void Move2()
    {
        moveVec2 = new Vector3(hAxis2, 0, vAxis2).normalized;

        transform.position += moveVec2 * speed2 * Time.deltaTime;

        anim2.SetBool("isRun", moveVec2 != Vector3.zero);
    }
    void Turn2()
    {
        transform.LookAt(transform.position + moveVec2);//�÷��̾� ȸ��
    }

    void Jump()
    {
        if (jDown && !isJump)
        {
            rigid2.AddForce(Vector3.up * 10, ForceMode.Impulse);
            isJump = true;
        }
    }

    void Die()
    {
        //isDie = true;
        rigid2.velocity = Vector3.zero;
        if ( health2 <= 0)
        {
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }
    /*void Interaction()
	{
        if(iDown && nearObject!=null && !isJump)
		{
			if (nearObject.tag == "Hay")
			{
                HayItem item = nearObject.GetComponent<HayItem>();

                Destroy(nearObject);
            }
		}
	}*/

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isJump = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Hay")
        {
            {
                HayItem item = other.GetComponent<HayItem>();//������ ��ũ��Ʈ ������
                //hayShield = true;
                ActivateShield();
                //�� ����
                shieldnum++;
            }
            Destroy(other.gameObject);
        }
        /*else (other.tag == "Enemy");
        {
            {
                Enemy enemy = other.GetComponent<Enemy>();//�ֳʹ� ��ũ��Ʈ ������ //���ʹ̽�ũ��Ʈ�� ���� �ȵǾ ����� ����?
                if(!isShield)
				{
                    health -= 1;
				}
            }
            Debug.Log(health);
        }*/
    }

    void ActivateShield()
    {
        Shield.SetActive(true);
        isShield = true;

        Invoke("NoShield", 5f);//5���Ŀ� �� ����
    }

    void NoShield()
    {
        Shield.SetActive(false);
        isShield = false;
    }
    /*void OnTriggerStay(Collider other)//�����ۿ� ������ �ٰ���
	{
        if (other.tag == "Hay") 
            nearObject = other.gameObject;

        Debug.Log(nearObject.name);
	}
    void OnTriggerExit(Collider other)//�����ۿ��� �־���
	{
        if (other.tag == "Hay")
            nearObject = null ;
    }*/




}

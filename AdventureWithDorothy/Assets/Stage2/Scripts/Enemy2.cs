using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Enemy2 : MonoBehaviour
{
    public Transform target;//플레이어
    Rigidbody rigid2;
    BoxCollider boxCollider2;
    Material mat2;
    NavMeshAgent nav;
    Animator anim;
    public bool isChase;
    public bool isAttack2;
    Player2 player;

    public int damage = 1;

    // Start is called before the first frame update
    void Awake()
    {
        rigid2 = GetComponent<Rigidbody>();
        boxCollider2 = GetComponent<BoxCollider>();
        mat2 = GetComponentInChildren<MeshRenderer>().material;
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();

        Invoke("ChaseStart", 2);//2초 뒤에 추적 시작
    }

    void OnTriggerEnter(Collider other) //플레이어 만나면
    {
        if (other.tag == "Player")
        {

            Player2 player = other.GetComponent<Player2>();//플레이어 스크립트 가져옴
            if (player.isShield == true)
            {
                return;
            }
            else
            {
                player.health2 -= damage;
            }

            Debug.Log(player.health2);
        }
    }
    // Update is called once per frame

    void ChaseStart()
    {
        isChase = true;
        anim.SetBool("isMove", true);
    }
    void AttackStart()
    {
        isAttack2 = true;
        anim.SetBool("isAttack", true);

    }
    void Update()
    {
        if (isChase)
        {
            nav.SetDestination(target.position);
        }
    }
}

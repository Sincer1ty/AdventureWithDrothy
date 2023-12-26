using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WitchController : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent nvAgent;

    public ThirdManager manager;
    Animator anim;
    public bool isChase;
    public int health;
    // Start is called before the first frame update
    void Awake()
    {
        nvAgent = this.gameObject.GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();

        Invoke("ChaseStart", 2);
    }

    void ChaseStart()
    {
        isChase = true;
        anim.SetBool("isTrace", true);
    }
    // Update is called once per frame
    void Update()
    {
        if(isChase)
            nvAgent.SetDestination(target.position);
        OnDamage();
    }

    void OnDamage()
    {
        if (health <= 0)
        {
            isChase = false;
            //anim.SetTrigger("doDie");
            //Destroy(gameObject, 4);
            manager.nextScence();
        }
    }
}

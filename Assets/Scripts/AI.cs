using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class AI : MonoBehaviour
{
    private Animator animator;
    private Transform player;
    public float distance = 2f;
    private bool stood = false;
    public float speed = 5f;
    bool playerdead;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        Invoke("standanim", 8.267f);
    }

    // Update is called once per frame
    void Update()
    {
        playerdead = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().isplayerdead;
        var navAgent = GetComponent<NavMeshAgent>();
        animator.SetFloat("speed", navAgent.velocity.magnitude);
        
    }
 
    private void OnTriggerStay(Collider other)
    { 
        transform.LookAt(player);
        
        if (stood)
        {
            var navAgent = GetComponent<NavMeshAgent>();

            if (playerdead)
            {
                navAgent.isStopped = true;
                navAgent.ResetPath();
                animator.SetFloat("speed", 0f);
                animator.SetBool("attacks",false);
            }
            if(!playerdead)
            {
                if (Vector3.Distance(gameObject.transform.position, other.transform.position) < distance)
                {
                    navAgent.isStopped = true;
                    animator.SetBool("attacks",true);
                }
                else
                {
                    animator.SetBool("attacks",false);
                    navAgent.SetDestination(other.transform.position);
                    navAgent.isStopped = false;
                }
            }
           
        }
    }

    private void OnTriggerExit(Collider other)
    {
        FindObjectOfType<Audiomanager>().Play("Background");
        var navAgent = GetComponent<NavMeshAgent>();
        navAgent.isStopped = true;
    }

    void standanim()
    {
        stood = true;
    }

    void punchanim()
    {
        animator.SetBool("attacks",true);
    }

    private void OnTriggerEnter(Collider other)
    {
        FindObjectOfType<Audiomanager>().Play("enemyroar");
    }

}

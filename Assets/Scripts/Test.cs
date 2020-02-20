using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System;

public class Test : MonoBehaviour
{
    public Animator Animator;
    public Image enemyHealth;
    public HealthSystem healthsystem;
    public GameObject finger;
    public GameObject EnemyBody;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyHealth.fillAmount= healthsystem.Health / 100;
        healthsystem.Health = Mathf.Clamp(healthsystem.Health, 0, 100);
        if (gameObject.GetComponent<HealthSystem>().Health == 0f)
        {
            StartCoroutine(DeathofEnemy());
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("finger"))
        {
            FindObjectOfType<Audiomanager>().Play("punchofplayer");
            Animator.SetTrigger("damage");
            gameObject.GetComponent<HealthSystem>().Damage(10);
        }

        if (other.gameObject.CompareTag("leg"))
        {
            FindObjectOfType<Audiomanager>().Play("punchofplayer");

            Animator.SetTrigger("damage");
            gameObject.GetComponent<HealthSystem>().Damage(5);
        }
    }

    IEnumerator DeathofEnemy()
    {
       Animator.SetTrigger("Dead");
       yield return new WaitForSeconds(3f);
        Destroy(gameObject);
        Destroy(finger);
        Destroy(EnemyBody);
    }
}

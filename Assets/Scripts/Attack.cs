using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            FindObjectOfType<Audiomanager>().Play("punchofenemy");
            other.gameObject.GetComponent<HealthSystem>().Damage(10);
        }

       
    }
}

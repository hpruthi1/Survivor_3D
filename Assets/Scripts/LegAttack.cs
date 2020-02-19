using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "enemy")
        {
            Debug.Log("dec");
            other.gameObject.GetComponent<HealthSystem>().Damage(5);
        }
    }
}

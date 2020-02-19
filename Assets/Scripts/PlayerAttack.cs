using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "enemy")
        {
            other.gameObject.GetComponent<HealthSystem>().Damage(10);
        }


    }
}

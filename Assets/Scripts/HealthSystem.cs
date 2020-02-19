using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    private HungerSystem hungersystem;
    private float ElapsedTime = 0f, FixedTime = 10f;
    public float Health = 100;
    private void Start()
    {
        hungersystem = GetComponent<HungerSystem>();
    }
    public float Player_Hunger(float health)
    {
        hungersystem.Hunger = Mathf.Clamp(hungersystem.Hunger, 0, 100);
        if (ElapsedTime > FixedTime)
        {
            hungersystem.Hunger += hungersystem.HungerIncreaseFactor;
            ElapsedTime = 0f;
            if (hungersystem.Hunger >= 20f)
            {
                health -= 10f;
            }
        }
        else
        {
            ElapsedTime += Time.deltaTime;
        }
        return health;

    }

    public void Damage(float damage)
    {
        Health -= damage;
    }
}

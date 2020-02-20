using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnergySystem : MonoBehaviour
{

    public float Energy = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Energyinc", 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        Energy = Mathf.Clamp(Energy, 0f, 100f);
    }

    public void Energyinc()
    {
        Energy += 20f;
    }
}

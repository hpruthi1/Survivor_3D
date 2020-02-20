using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergySystem : MonoBehaviour
{
    public float Energy = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("EnergyUP", 10f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        Energy = Mathf.Clamp(Energy, 0f, 100f);
    }

    public void EnergyUP()
    {
        Energy += 20f;
    }

  }


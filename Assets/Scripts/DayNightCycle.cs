using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    public int minutesOf1Day = 1;

    // Update is called once per frame
    void Update()
    {
         transform.RotateAround(Vector3.zero, Vector3.right, 10f * Time.deltaTime);
        
    }
}

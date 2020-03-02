using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeCycle : MonoBehaviour
{
    public Text DayCount;
    public float DayTimeinmin;
    float rotation;
    float elapsedtime=0f;
    float Count=1f;
    void Start()
    {
        rotation =  360/(DayTimeinmin*60);
    }

    void Update()
    {
        transform.RotateAround(Vector3.zero, Vector3.right, rotation*Time.deltaTime);
        if(elapsedtime>DayTimeinmin*60)
        {
            Count++;
            elapsedtime = 0f;
        }
        else
        {
            elapsedtime += Time.deltaTime;
        }
        DayCount.text =Count.ToString();

       if(Count == 3)
        {
            StartCoroutine(ChangeScene());
        }
    
    }
    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(4);
    }
  
}
   


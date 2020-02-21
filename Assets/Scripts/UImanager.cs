using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class UImanager : MonoBehaviour
{
    public GameObject Inventorytab;
    public GameObject[] obj;
    int i;
    public int TimeInMinutes = 1;
    public int currentDay = 0;
    public Text day;
    
    void Start()
    {
        Inventorytab.SetActive(false);
    }
    public void DisplayFoodmenu(GameObject foodmenu)
    {
        bool active = foodmenu.activeSelf;
        foodmenu.SetActive(!active);
    }
    public void DisplayInfo(int i)
    {
      if(i==0)
        {
            bool active = obj[i].activeSelf;
            obj[i].SetActive(!active);
        }
      else if(i==1)
        {
            bool active = obj[i].activeSelf;
            obj[i].SetActive(!active);
        }
    }
    void Update()
    {
      
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            FindObjectOfType<Audiomanager>().Play("popup");
            Inventorytab.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Tab))
        {
            Inventorytab.SetActive(false);
        }
        currentDay = (int)(Time.realtimeSinceStartup / (TimeInMinutes * 60)) + 1;
        day.text = Convert.ToString(currentDay);

        if(currentDay == 3)
        {
            StartCoroutine(SceneLoad());
        }

    }
    public void PopupDisplay(GameObject pop)
    {
        pop.SetActive(true);
    }
    public void PopupInactive(GameObject pop)
    {
        pop.SetActive(false);
    } 
    
   
    IEnumerator SceneLoad()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene(4);
    }

}

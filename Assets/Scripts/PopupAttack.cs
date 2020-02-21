using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupAttack : MonoBehaviour
{
    public GameObject player;
    public EnergySystem energySystem;
    public GameObject powerAttackImage;
    // Start is called before the first frame update
    void Start()
    {
        powerAttackImage.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<EnergySystem>().Energy==40f)
        {
            if (!powerAttackImage.activeInHierarchy)
            {
                PauseGame();
            }
            if (powerAttackImage.activeInHierarchy)
            {
                Time.timeScale = 1;
                powerAttackImage.SetActive(true);

            }
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        powerAttackImage.SetActive(true);
    }
}

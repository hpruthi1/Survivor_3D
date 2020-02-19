using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InfoDisplay : MonoBehaviour
{
    public void Start()
    {
    }
    public void Update()
    {
        
    }
    public void Selected(Itemobject item)
    {
        InventoryManager.instance.selected = true;
        InventoryManager.instance.item = item;
    }
}

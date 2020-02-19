using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName ="New Food Object",menuName ="Inventory/Item/Food")]
public class FoodObject : Itemobject
{
    public float Healthincrease;
    public float hungerDecrease;
    public override void Use(Itemobject _item)
    {
        GameObject.FindGameObjectWithTag("Player").GetComponent<HealthSystem>().Health += Healthincrease;
        GameObject.FindGameObjectWithTag("Player").GetComponent<HungerSystem>().Hunger = hungerDecrease;
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            if (inventory.Container[i].item.type == _item.type)
            {
                if (inventory.Container[i].item.Itemname == _item.Itemname)
                { 
                    inventory.Container[i].amount -= 1;
                    inventory.Container[i].amount = Mathf.Clamp(inventory.Container[i].amount, 0, 100);
                }
                }
            else
            {
                return;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Inventory Object", menuName = "Inventory/Inventory")]
public class InventoryObject : ScriptableObject
{
    public delegate void onitemchanged();

    public onitemchanged onitemchangedcallback;
    public List<InventorySlot> Container = new List<InventorySlot>();
    public void AddItem(Itemobject _item,int _amount)
    {
        bool hasItem = false;
        for (int i = 0; i < Container.Count; i++)
        {
            if(Container[i].item==_item)
            {
                Container[i].AddAmount(_amount);
                hasItem = true;
                break; 
            }
        }
        if (!hasItem)
        {
            Container.Add(new InventorySlot(_item, _amount));
        }
    }
}

[System.Serializable]
public class InventorySlot
{
    public Itemobject item;
    public int amount;
    public InventorySlot(Itemobject _item,int _amount)
    {
        item = _item;
        amount=_amount;
    }
    public void AddAmount(int value)
    {
        amount = Mathf.Clamp(amount, 0, 100);
        amount += value;
    }
    public void DecAmount(int value)
    {
        amount -= value;
    }
}

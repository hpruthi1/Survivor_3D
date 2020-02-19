using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum Type
    {
    Food,
    Equipment
    }
public class Itemobject : ScriptableObject
{
    public string Itemname;
    [TextArea]
    public string Description;
    public GameObject ItemPrefabImage,ItemGameobject;
    public RawImage renderImage;
    public Type type;
    public float Weight;
    public InventoryObject inventory;
    public LayerMask layer;
    public virtual void Use(Itemobject _item)
    {
        Debug.Log("Use");
    }
}

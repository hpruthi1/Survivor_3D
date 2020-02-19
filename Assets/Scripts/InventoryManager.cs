using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public Itemobject item;
    public RawImage RenderingImage;
    public bool selected=false;
    public TextMeshProUGUI description,Itemname;
    public GameObject InfoButton,Usebutton,deleteButton;
    public Player player;
    public InventoryDisplay InventoryDisplay;
    void Start()
    {
        description.text = "";
        Itemname.text = "";
        instance = this;
        item = null;
        InfoButton.SetActive(false);
        Usebutton.SetActive(false);
        deleteButton.SetActive(false);
    }

    void Update()
    {
       if(selected==true)
        {
            InfoButton.SetActive(true);
            Usebutton.SetActive(true);
            deleteButton.SetActive(true);
        }
        else
        {
            InfoButton.SetActive(false);
            Usebutton.SetActive(false);
            deleteButton.SetActive(false);
        }
    }
    public void Show()
    {
        if (selected == true)
        {
            description.text = "Description:-\n" + item.Description;
            Itemname.text = item.name;
            RenderingImage.texture = item.renderImage.texture;
            selected = false;
        }
        else
        {
            description.text = "";
            Itemname.text ="";
            RenderingImage.texture = null;
        }
    }
    public void UseButton()
    {
        if(selected==true)
        {
            item.Use(item);
            selected = false;
        }
    }
    public void DeleteItems()
    {
        if(selected==true)
        {
            player.Spawn(item.ItemGameobject);
            InventoryDisplay.RemoveItem(item);
            selected = false;
        }
    }
}

using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public int avocadoCount;
    public Text avocadoCountText;

    public List<Item> content = new List<Item>();
    public int contentCurrentItem = 0;
    public Image orbe1;
    public Image orbe2;

    public static Inventory instance;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Inventory dans la sc�ne");
            return;
        }
        instance = this;
        orbe1.enabled = true;
        orbe2.enabled = false;
    }

    public void GetNextItem()
    {
        contentCurrentItem++;
        if (contentCurrentItem > content.Count - 1)
        {
            contentCurrentItem = 0;
            orbe1.enabled = true;
            orbe2.enabled = false;

        }
        else
        {
            orbe1.enabled = false;
            orbe2.enabled = true;
        }
    }
    public void GetPreviousItem()
    {
        contentCurrentItem--;
        if(contentCurrentItem < content.Count - 1)
        {
            contentCurrentItem = 0;
            orbe1.enabled = false;
            orbe2.enabled = true;

        }
        else
        {
            orbe1.enabled = true;
            orbe2.enabled = false;
        }
    }


    public void UseItem()
    {
        Item currentItem = content[contentCurrentItem];
        if (contentCurrentItem == 0)
        {
            
        }

        if (contentCurrentItem == 1)
        {
            PlayerHealth.instance.HealPlayer(20);
            
        }
    }   
}
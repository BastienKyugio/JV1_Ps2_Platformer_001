using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System;

public class Inventory : MonoBehaviour
{
    public int featherCount;
    public Text featherCountText;



    public static Inventory instance;


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Inventory dans la sc�ne");
            return;
        }
        instance = this;

    }


    public void AddFeathers(int count)
    {
        featherCount += count;
        UdpateTextUI();
    }
    public void RemoveFeathers(int count)
    {
        featherCount -= count;
        UdpateTextUI();
    }
    public void UdpateTextUI()
    {
        featherCountText.text = featherCount.ToString();
    }
}
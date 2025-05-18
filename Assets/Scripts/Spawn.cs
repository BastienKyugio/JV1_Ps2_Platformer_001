using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{

    public GameObject monPersoSpawn;

    public static Spawn instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de Spawn dans la scène");
            return;
        }

        instance = this;


    
        
    }
    private void Start()
    {
        CharacterMovement.instance.playercollider.transform.position = gameObject.transform.position;
    }

}

using UnityEngine;

public class CurrentSceneManager : MonoBehaviour
{

    public GameObject perso;
    public static CurrentSceneManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de CurrentSceneManager dans la scène");
            return;
        }

        instance = this;

        GameObject.FindGameObjectWithTag("player").transform.position = transform.position;

    }

}
using UnityEngine;

public class LoadAndSaveData : MonoBehaviour
{
    public static LoadAndSaveData instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogWarning("Il y a plus d'une instance de LoadAndSaveData dans la sc�ne");
            return;
        }

        instance = this;
    }
    void Start()
    {

    }

    public void SaveData()
    {

    }

}

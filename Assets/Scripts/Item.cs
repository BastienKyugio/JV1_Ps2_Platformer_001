using UnityEngine;
[CreateAssetMenu(fileName = "Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject
{
    public int id;
    public string _name;
    public string description;
    public Sprite image;
    public int effectDuration;
    public int healPoints;

}
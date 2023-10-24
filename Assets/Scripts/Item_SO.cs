using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Item")]
public class Item_SO : ScriptableObject
{
    public Sprite icon;
    new public string name;
    public string displayName;
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "ScriptableObjects/Item")]
public class Item_SO : ScriptableObject
{
    public Sprite icon;
    public string name;
    public string name_display;
    
}

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public List<Item_SO> inventory = new List<Item_SO>();
    public List<GameObject> itemPrefabs = new List<GameObject>();

    [SerializeField] Transform itemContainer;
    
    [SerializeField] GameObject itemPrefab;

    public void AddItem(Item_SO item)
    {
        inventory.Add(item);
        CreateItemPrefab(item);
    }

    void CreateItemPrefab(Item_SO item)
    {
        GameObject itemObj = Instantiate(itemPrefab, itemContainer);
        itemObj.name = item.name;
        itemObj.GetComponent<Image>().sprite = item.icon;
        itemPrefabs.Add(itemObj);
    }

    public void RemoveItem(Item_SO item)
    {
        foreach (GameObject itemObj in itemPrefabs)
        {
            if (item.name.Equals(itemObj.name))
            {
                inventory.Remove(item);
                itemPrefabs.Remove(itemObj);
                Destroy(itemObj);
                return;
            }
        }
    }

    public bool ContainsItem(Item_SO item)
    {
        return inventory.Contains(item);
    }

/*#if UNITY_EDITOR
    private void OnGUI()
    {
        if (GUI.Button(new Rect(0, 0, 200, 30), "Add Item \"Key 1\""))
        {
            AddItem(key_1);
        }

        if (GUI.Button(new Rect(0, 30, 200, 30), "Remove Item \"Key 1\""))
        {
            RemoveItem(key_1);
        }

        if (GUI.Button(new Rect(0, 60, 200, 30), "Check for Item \"Key 1\""))
        {
            Debug.Log(ContainsItem(key_1));
        }
    }
#endif*/
}

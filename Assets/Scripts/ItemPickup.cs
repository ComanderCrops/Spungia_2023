using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPickup : IInteractible
{
    [SerializeField] Item_SO item;

    InventoryManager inventory;

    void Start()
    {
        inventory = Camera.main.GetComponent<InventoryManager>();
    }

    public override void OnPointerClick(PointerEventData pointerEventData)
    {
        inventory.AddItem(item);
        Destroy(gameObject);
    }
}

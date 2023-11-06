using UnityEngine;
using UnityEngine.EventSystems;

public class ItemPickup : IInteractible
{
    [SerializeField] Item_SO item;

    InventoryManager inventory;
    UImanager uiManager;

    void Start()
    {
        inventory = Camera.main.GetComponent<InventoryManager>();
        uiManager = Camera.main.GetComponent<UImanager>();
    }

    public override void OnPointerClick(PointerEventData pointerEventData)
    {
        /*if (item.name.Equals("glowing_bunny"))
        {
            Debug.Log("The Glowing Bunny is now happy. You got radiation poisoning. Item added to inventory!");
        }*/

        inventory.AddItem(item);
        uiManager.HideTooltip();
        Destroy(gameObject);
    }

    public override void OnPointerEnter(PointerEventData pointerEventData)
    {
        /*if (item.name.Equals("glowing_bunny"))
        {
            uiManager.UpdateTooltip("Pet the Glowing Bunny", transform.position);
        }
        else
        {
            uiManager.UpdateTooltip("Pick Up " + item.displayName, transform.position);
        }*/
        uiManager.UpdateTooltip("Pick Up " + item.displayName, transform.position);
        base.OnPointerEnter(pointerEventData);
    }

    public override void OnPointerExit(PointerEventData pointerEventData)
    {
        uiManager.HideTooltip();
        base.OnPointerExit(pointerEventData);
    }
}

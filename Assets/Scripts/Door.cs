using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Door : IInteractible
{
    [SerializeField] UnityEvent doorOpenEvent;

    [SerializeField] string tooltip;

    [SerializeField] bool locked = false;
    [SerializeField] Item_SO key;

    float radius = 0.5f;

    bool doorUsed = false;

    GameObject player;
    InventoryManager inventory;
    UImanager uiManager;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventory = Camera.main.GetComponent<InventoryManager>();
        uiManager = Camera.main.GetComponent<UImanager>();
    }

    public override void OnPointerClick(PointerEventData pointerEventData)
    {
        if (doorUsed)
        {
            return;
        }

        if (locked)
        {
            if (!inventory.ContainsItem(key))
            {
                Debug.Log(key.displayName + " (" + key.name + ") required to unlock door");
                return;
            }
            else
            {
                locked = false;
                inventory.RemoveItem(key);
                tooltip = "Open Door";
            }
        }

        doorUsed = true;

        if (Vector2.Distance(player.transform.position, transform.position) < radius)
        {
            runDoorOpenEvent();
        }
        else
        {
            player.transform.DOMove(transform.position, 4).onComplete = runDoorOpenEvent;
        }
    }

    void runDoorOpenEvent()
    {
        doorUsed = false;
        doorOpenEvent.Invoke();
    }

    public override void OnPointerEnter(PointerEventData pointerEventData)
    {
        uiManager.UpdateTooltip(tooltip, transform.position);
        base.OnPointerEnter(pointerEventData);
    }

    public override void OnPointerExit(PointerEventData pointerEventData)
    {
        uiManager.HideTooltip();
        base.OnPointerExit(pointerEventData);
    }
}

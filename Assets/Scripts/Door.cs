using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Door : IInteractible
{
    [SerializeField] UnityEvent doorOpenEvent;

    [SerializeField] bool locked = false;
    [SerializeField] Item_SO key;

    float radius = 0.5f;

    bool doorUsed = false;

    GameObject player;
    InventoryManager inventoryManager;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        inventoryManager = Camera.main.GetComponent<InventoryManager>();
    }

    public override void OnPointerClick(PointerEventData pointerEventData)
    {
        if (doorUsed)
        {
            return;
        }

        if (locked && !inventoryManager.ContainsItem(key))
        {
            Debug.Log(key.displayName + " (" + key.name + ") required to unlock door");
            return;
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

    /*void OnPointerEnter(PointerEventData pointerEventData)
    {
        //doorOpenEvent = null;
    }

    void OnPointerExit(PointerEventData pointerEventData)
    {
        //doorOpenEvent = null;
    }*/
}

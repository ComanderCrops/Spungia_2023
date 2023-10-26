using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Door : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] UnityEvent doorOpenEvent;

    float radius = 0.5f;

    [SerializeField] bool doorUsed = false;

    GameObject player;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
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
